using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GlobalVariables;

namespace TimeSheetProgram
{
    public partial class userScreenFrm : Form
    {

        #region Variables and Properites          
        //Variables
        public const string REQUIREDFOLDER = GlobalVars.REQUIREDFOLDER;
        public const string JOBCODESFILE = GlobalVars.JOBCODESFILE;
        private string username, password;

        //Properties
        public string Username
        {
            get
            {
                return username;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
        }
        public string DirectoryName
        {
            get
            {
                return REQUIREDFOLDER + Username + "\\"; ;
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
                switch(value)
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
        #endregion

        #region UserScreen
        //Constructor
        public userScreenFrm(string receivedUserName, string receivedPassword)
        {
            username = receivedUserName;
            password = receivedPassword;
            InitializeComponent();
            if (Username.ToLower() == "admin")
            {
                usersToolStripMenuItem.Visible = true;
                //this.mainTabControl.Controls.Add(this.userControlsTab);

            }
            else
            {
                //this.mainTabControl.Controls.Add(this.jobControlsTab);
            }
        } 
        
        //Screen Close
        private void userScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        //Screen Load
        private void userScreen_Load(object sender, EventArgs e)
        {
            fillJobList();
            fillJobCodesList();
            userNameLabel.Text = Username;
            this.Text = Username + "\'s Account Screen";
        }

        #endregion

        #region MenuStrip
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sign out menu
            login loginScreen = new login();
            this.Hide();
            loginScreen.Show();
           
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Change password
            forgotPasswordFrm changeCurrentUserPassword = new forgotPasswordFrm(Username);
            changeCurrentUserPassword.ShowDialog();
            if (changeCurrentUserPassword.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("User Password Was NOT changed");
            }
        }
        #endregion

        #region Job Controls
        private void newJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //New Job
            string newJobNumber, newJobName;
            newJobFrm newJob = new newJobFrm();

            newJob.ShowDialog();
            if (newJob.DialogResult == DialogResult.OK)
            {
                newJobNumber = newJob.ReturnJobNumber;
                newJobName = newJob.ReturnJobName;

                jobControls newJobControls = new jobControls(Username);
                newJobControls.newJob(newJobName, newJobNumber);
                fillJobList(newJobNumber);
            }
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            //Add employee
            if (newEmployeeTextBox.Text != "")
            {
                employeeListBox.Items.Add(newEmployeeTextBox.Text);
                newEmployeeTextBox.Text = "";
                newEmployeeTextBox.Focus();
            }
        }

        private void jobNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            jobNumberComboBox.SelectedIndex = jobNameComboBox.SelectedIndex;
            if (jobNameComboBox.SelectedIndex != -1 || jobNumberComboBox.SelectedIndex != -1)
            {
                jobControls loadSelectedJob = new jobControls(Username);
                loadSelectedJob.loadJob(jobNumberComboBox.Text);
                if (loadSelectedJob.JobCode != null)
                {
                    if (jobCodesComboBox.Items.Contains(loadSelectedJob.JobCode))
                    {
                        jobCodesComboBox.SelectedItem = loadSelectedJob.JobCode;
                    }
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
                lastTimeUpdateLabel.Text = "Last Time Updated: \n" 
                    + File.GetLastWriteTime(DirectoryName + jobNumberComboBox.Text + GlobalVars.JOBFILEEXTENSHION).ToShortDateString() 
                    + "\n" + File.GetLastWriteTime(DirectoryName + jobNumberComboBox.Text + GlobalVars.JOBFILEEXTENSHION).ToShortTimeString();
                jobNameComboBox.Enabled = false;
                jobNumberComboBox.Enabled = false;
                jobControlPanel.Visible = true;
                saveJobButton.Visible = true;
                deleteJobBtn.Visible = true;
                deleteJobToolStripMenuItem.Visible = true;
                editJobToolStripMenuItem.Visible = true;
                editJobNameButton.Visible = true;
            }
            else
            {
                jobNameComboBox.Enabled = true;
                jobNumberComboBox.Enabled = true;
                jobControlPanel.Visible = false;
                deleteJobBtn.Visible = false;
                saveJobButton.Visible = false;
                deleteJobToolStripMenuItem.Visible = false;
                editJobToolStripMenuItem.Visible = false;
                editJobNameButton.Visible = false;

            }
        }

        private void jobNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            jobNameComboBox.SelectedIndex = jobNumberComboBox.SelectedIndex;
        }

        private void deleteJobButton_Click(object sender, EventArgs e)
        {
            jobControls deleteJob = new jobControls(Username);
            deleteJob.deleteJob(Convert.ToString(jobNumberComboBox.Text));
            jobNumberComboBox.SelectedIndex = -1;
            fillJobList();
        }

        private void saveJobButton_Click(object sender, EventArgs e)
        {
            //Vairables
            bool saveSuccessful = true;
            string currentJobNumber = jobNumberComboBox.Text;
            string currentJobName = jobNameComboBox.Text;
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
            if(JobStatus == "No Job Selected")
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
                jobControls saveCurrentJob = new jobControls(Username);
                saveCurrentJob.saveJob(currentJobName, currentJobNumber, startDate, endDate,
                    jobEmployees, jobCode, jobEstimateCost, jobStatus, jobNotes);
                jobNumberComboBox.SelectedIndex = -1;
                fillJobList();
            }
        }

        private void editJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jobControls editJob = new jobControls(Username);
            editJob.editJob(jobNumberComboBox.Text, jobNameComboBox.Text);
            fillJobList(editJob.JobNumber);
        }

        private void deleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            employeeListBox.Items.Remove(employeeListBox.SelectedItem);
        } 

        private void fillJobList()
        {
            jobNumberComboBox.Items.Clear();
            jobNameComboBox.Items.Clear();
            jobNameComboBox.Text = "Search By Job";
            jobNumberComboBox.Text = "Search By Job #";
            foreach (string jobNumberFile in Directory.EnumerateFiles(DirectoryName, "*.job"))
            {
                string jobNumber = jobNumberFile.Replace(".job", "");
                jobNumber = jobNumber.Replace(DirectoryName, "");
                FileStream ReadJobName = new FileStream(jobNumberFile, FileMode.Open, FileAccess.Read);
                StreamReader read = new StreamReader(ReadJobName);
                string jobName = read.ReadLine();
                if (jobName != "" && jobName != null)
                {
                    jobNameComboBox.Items.Add(jobName);
                }
                else
                {
                    jobNameComboBox.Items.Add("Unnamed");
                }
                jobNumberComboBox.Items.Add(jobNumber);
                ReadJobName.Close();
                read.Close();
            }
        }

        private void fillJobList(string jobNumberToFocusOn)
        {
            fillJobList();
            jobNumberComboBox.SelectedItem = jobNumberToFocusOn;
        }

        private void fillJobCodesList()
        {
            string jobCodeString;
            FileStream ReadJobCodes = new FileStream(REQUIREDFOLDER + JOBCODESFILE, FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(ReadJobCodes);

            jobCodeString = read.ReadLine();
            
            while (jobCodeString != null)
            {
                jobCodesComboBox.Items.Add(jobCodeString);
                jobCodesListBox.Items.Add(jobCodeString);
                jobCodeString = read.ReadLine();
            }
            read.Close();
            ReadJobCodes.Close();
        }

        #endregion
    }
}
