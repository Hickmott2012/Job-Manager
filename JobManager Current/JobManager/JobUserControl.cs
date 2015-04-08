using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GlobalVariables;

namespace JobManager
{
    public partial class JobUserControl : UserControl
    {

        private string jobName, jobNumber, currentUsername;
        public const string REQUIREDFOLDER = GlobalVars.REQUIREDFOLDER;
        public const string JOBFILEEXTENSHION = GlobalVars.JOBFILEEXTENSHION;
        public const string JOBCODESFILE = GlobalVars.JOBCODESFILE;
        public string JobName
        {
            get
            {
                return jobName;
            }
        }

        public string JobNumber
        {
            get
            {
                return jobNumber;
            }
        }

        public string CurrentUsername
        {
            get
            {
                return currentUsername;
            }
        }

        public string JobStatus
        {
            get
            {
                if (completJobStatRadioButton.Checked == true)
                {
                    return "Complete";
                }
                else if (inProgressJobStatRadioButton.Checked == true)
                {
                    return "In Progress";
                }
                else if (delayedJobStatRadioButton.Checked == true)
                {
                    return "Delayed";
                }
                else
                {
                    return "No Job Selected";
                }
            }
            set
            {
                switch (value)
                {
                    case "Complete":
                        completJobStatRadioButton.Checked = true;
                        break;
                    case "In Progress":
                        inProgressJobStatRadioButton.Checked = true;
                        break;
                    case "Delayed":
                        delayedJobStatRadioButton.Checked = true;
                        break;
                    default:
                        //No Job Status Selected Leave all Unchecked
                        completJobStatRadioButton.Checked = false;
                        inProgressJobStatRadioButton.Checked = false;
                        delayedJobStatRadioButton.Checked = false;
                        break;
                }
            }
        }
                
        public JobUserControl(string recivedUsername, string recivedJobNumber)
        {
            InitializeComponent();
            fillJobCodesList();
            jobNumberLabel.Text = recivedJobNumber;
            jobNumber = recivedJobNumber;
            currentUsername = recivedUsername;

            jobControls loadSelectedJob = new jobControls(currentUsername);
            loadSelectedJob.loadJob(recivedJobNumber);
            if (!String.IsNullOrWhiteSpace(loadSelectedJob.JobCode))
            {
                if (jobCodesComboBox.Items.Contains(loadSelectedJob.JobCode))
                {
                    jobCodesComboBox.SelectedItem = loadSelectedJob.JobCode;
                }
                jobName = loadSelectedJob.JobName;
                jobStartDateTimePicker.Value = loadSelectedJob.StartDate;
                jobEndDateTimePicker.Value = loadSelectedJob.EndDate;
                jobEstimateTextBox.Text = Convert.ToString(loadSelectedJob.JobEstimateCost);
                JobStatus = loadSelectedJob.JobStatus;
                jobNotesTextBox.Text = loadSelectedJob.JobNotes;
                string[] jobEmployList = loadSelectedJob.jobEmployees;
                employeeListBox.Items.Clear();
                if (jobEmployList != null)
                {
                    for (int i = 0; i < jobEmployList.Length; i++)
                    {
                        employeeListBox.Items.Add(jobEmployList[i]);
                    }
                }
            }
            DateTime lastWriteTime =
                File.GetLastWriteTime(REQUIREDFOLDER + currentUsername + "\\" + recivedJobNumber + JOBFILEEXTENSHION);

            lastTimeUpdateLabel.Text = String.Format("Last Time Updated: {0}{1}{2}{3}", Environment.NewLine,
                lastWriteTime.ToShortDateString(), Environment.NewLine, lastWriteTime.ToShortDateString());

            jobNameLabel.Text = JobName;
            loadSelectedJob = null;

        }

        private void fillJobCodesList()
        {
            jobCodeErrorLabel.Visible = false;
            jobCodesComboBox.Items.Clear();
            string jobCodeString;
            FileStream ReadJobCodes = new FileStream(REQUIREDFOLDER + JOBCODESFILE, FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(ReadJobCodes);

            jobCodeString = read.ReadLine();

            while (jobCodeString != null)
            {
                jobCodesComboBox.Items.Add(jobCodeString);
                jobCodeString = read.ReadLine();
            }
            read.Close();
            ReadJobCodes.Close();
        }

        private void saveJobButton_Click(object sender, EventArgs e)
        {
            //Vairables
            bool saveSuccessful = true;
            string currentJobNumber = JobNumber;
            string currentJobName = JobName;
            DateTime startDate = jobStartDateTimePicker.Value;
            DateTime endDate = jobEndDateTimePicker.Value;
            int amountOfEmployees = employeeListBox.Items.Count;
            string[] jobEmployees = new string[amountOfEmployees];
            string jobCode = jobCodesComboBox.Text;
            double jobEstimateCost;
            string jobStatus = JobStatus;
            string jobNotes = jobNotesTextBox.Text;


            //Fill Employees array
            for (int i = 0; i < amountOfEmployees; i++)
                jobEmployees[i] = employeeListBox.Items[i].ToString();


            //try checking if the estimate total is an int
            if (double.TryParse(jobEstimateTextBox.Text, out jobEstimateCost) == false)
            {
                //Error Job Estimate is not a number
                saveSuccessful = false;
                jobEstimateErrorLabel.Visible = true;
            }
            else
            {
                jobEstimateErrorLabel.Visible = false;
            }

            //Check to make sure the end date is after the start date
            if (endDate < startDate)
            {
                saveSuccessful = false;
                jobEndDateErrorLabel.Visible = true;
            }
            else
            {
                jobEndDateErrorLabel.Visible = false;
            }

            //Check to make sure there is a job code selected
            if (!jobCodesComboBox.Items.Contains(jobCodesComboBox.Text))
            {
                saveSuccessful = false;
                jobCodeErrorLabel.Visible = true;
            }
            else
            {
                jobCodeErrorLabel.Visible = false;
            }

            //Check to see if there is a job status selected
            if (JobStatus == "No Job Selected")
            {
                saveSuccessful = false;
                jobStatusErrorLabel.Visible = true;
            }
            else
            {
                jobStatusErrorLabel.Visible = false;
            }

            //if all information is filled in
            if (saveSuccessful)
            {
                jobControls saveCurrentJob = new jobControls(currentUsername);
                saveCurrentJob.saveJob(currentJobName, currentJobNumber, startDate, endDate,
                    jobEmployees, jobCode, jobEstimateCost, jobStatus, jobNotes);
                saveCurrentJob = null;
                closeJob();
            }
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            //Add employee
            if (!String.IsNullOrWhiteSpace(newEmployeeTextBox.Text))
            {
                employeeListBox.Items.Add(newEmployeeTextBox.Text);
                newEmployeeTextBox.Text = String.Empty;
                newEmployeeTextBox.Focus();
            }
        }

        private void deleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            employeeListBox.Items.Remove(employeeListBox.SelectedItem);
        }

        private void deleteJobBtn_Click(object sender, EventArgs e)
        {
            jobControls deleteJob = new jobControls(CurrentUsername);
            deleteJob.deleteJob(JobNumber);
            closeJob();
            deleteJob = null;
        }

        public void closeJob()
        {
            this.Parent.Parent.Controls.Remove(this.Parent);
            this.Parent.TabIndex = 0;
            this.Dispose();
        }
    }
}
