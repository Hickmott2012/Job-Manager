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

namespace JobManager
{
    public partial class JobControlScreenFrm : Form
    {

        #region Variables and Properites
        //Variables
        public const string REQUIREDFOLDER = GlobalVars.REQUIREDFOLDER;
        public const string JOBCODESFILE = GlobalVars.JOBCODESFILE;
        public const string JOBFILEEXTENSHION = GlobalVars.JOBFILEEXTENSHION;
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
        #endregion

        #region JobScreen
        public JobControlScreenFrm(string receivedUserName, string receivedPassword)
        {
            InitializeComponent();
            username = receivedUserName;
            password = receivedPassword;
        }

        private void JobControlScreenFrm_Load(object sender, EventArgs e)
        {
            this.Text = Username + "\'s Job Screen";
            userNameLabel.Text = Username;
            fillJobList();
        }

        private void JobControlScreenFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
            //TODO: call the close function to save and close all windows
        }
        #endregion

        #region MenuStrip
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            //TODO: call the close function to save and close all windows
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
                MessageBox.Show("User Password Was NOT changed", "Password Not Changed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            changeCurrentUserPassword = null;
        }
        #endregion

        #region Job Controls
        private void newJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //New Job
            string newJobNumber, newJobName;
            newJobFrm newJob = new newJobFrm(Username);

            newJob.ShowDialog();
            if (newJob.DialogResult == DialogResult.OK)
            {
                newJobNumber = newJob.ReturnJobNumber;
                newJobName = newJob.ReturnJobName;

                jobControls newJobControls = new jobControls(Username);
                newJobControls.newJob(newJobName, newJobNumber);
                fillJobList(newJobName, newJobNumber);
                newJob = null;
            }
        }

        private void deleteJobButton_Click(object sender, EventArgs e)
        {
            jobControls deleteJob = new jobControls(Username);
            deleteJob.deleteJob(jobNumbersListBox.SelectedItem.ToString());
            removeJobTab(jobNamesListBox.SelectedItem.ToString(), jobNumbersListBox.SelectedItem.ToString());
            jobNumbersListBox.SelectedIndex = -1;
            fillJobList();
            deleteJob = null;
        }

        private void fillJobList()
        {
            jobNamesListBox.Items.Clear();
            jobNumbersListBox.Items.Clear();
            jobNamesListBox.SelectedIndex = -1;
            jobNumbersListBox.SelectedIndex = -1;
            hideShowButtons();
            foreach (string jobNumberFile in Directory.EnumerateFiles(DirectoryName, "*.job"))
            {
                string jobNumber = jobNumberFile.Replace(".job", "");
                jobNumber = jobNumber.Replace(DirectoryName, "");
                FileStream ReadJobName = new FileStream(jobNumberFile, FileMode.Open, FileAccess.Read);
                StreamReader read = new StreamReader(ReadJobName);
                string jobName = read.ReadLine();
                if (jobName != "" && jobName != null)
                {
                    jobNamesListBox.Items.Add(jobName);
                    jobNumbersListBox.Items.Add(jobNumber);
                }
                ReadJobName.Close();
                read.Close();
            }
        }

        private void fillJobList(string jobNameToFocusOn, string jobNumberToFocusOn)
        {
            fillJobList();
            focusOnJob(jobNameToFocusOn, jobNumberToFocusOn);
        }

        private void jobNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            jobNumbersListBox.SelectedIndex = jobNamesListBox.SelectedIndex;
            hideShowButtons();
        }

        private void jobNumbersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            jobNamesListBox.SelectedIndex = jobNumbersListBox.SelectedIndex;
            hideShowButtons();
        }

        private void openJobButton_Click(object sender, EventArgs e)
        {
            string selectedJobName = jobNamesListBox.SelectedItem.ToString();
            string selectedJobNumber = jobNumbersListBox.SelectedItem.ToString();

            openSelectedJob(selectedJobName, selectedJobNumber);
        }

        private void changeJobNameBtn_Click(object sender, EventArgs e)
        {
            string jobNumberSelected = jobNumbersListBox.SelectedItem.ToString();
            string jobNameSelected = jobNamesListBox.SelectedItem.ToString();
            jobControls changeJobName = new jobControls(Username);
            changeJobName.editJobNameAndNumber(jobNumberSelected, jobNameSelected);
            if (isJobOpenInTab(jobNamesListBox.SelectedItem.ToString(), jobNumbersListBox.SelectedItem.ToString()))
            {
                removeJobTab(jobNumberSelected + "Tab");
                openSelectedJob(changeJobName.JobName, changeJobName.JobNumber, false);
            }
            fillJobList();
            changeJobName = null;
        }

        public void removeJobTab(string jobName, string jobNumber)
        {
            string jobToRemove = jobName + " " + jobNumber;
            for (int i = 0; i < jobTabControl.TabPages.Count; i++)
            {
                if (jobTabControl.TabPages[i].Text.Equals(jobToRemove, StringComparison.OrdinalIgnoreCase))
                {
                    jobTabControl.TabPages.RemoveAt(i);
                    break;
                }
            }
        }

        public void removeJobTab(string jobTabName)
        {
            for (int i = 0; i < jobTabControl.TabPages.Count; i++)
            {
                if (jobTabControl.TabPages[i].Name.Equals(jobTabName, StringComparison.OrdinalIgnoreCase))
                {
                    jobTabControl.TabPages.RemoveAt(i);
                    break;
                }
            }
        }

        public void focusOnJob(string jobNameToFocusOn, string jobNumberToFocusOn)
        {
            string jobToFocusOn = jobNameToFocusOn + " " + jobNumberToFocusOn;
            for (int i = 0; i < jobTabControl.TabPages.Count; i++)
            {
                if (jobTabControl.TabPages[i].Text.Equals(jobToFocusOn, StringComparison.OrdinalIgnoreCase))
                {
                    jobTabControl.SelectedIndex = i;
                    break;
                }
            }
        }

        public bool isJobOpenInTab(string jobName, string jobNumber)
        {
            string jobToFind = jobName + " " + jobNumber;
            bool isJobOpen = false;
            for (int i = 0; i < jobTabControl.TabPages.Count; i++)
            {
                if (jobTabControl.TabPages[i].Text.Equals(jobToFind, StringComparison.OrdinalIgnoreCase))
                {
                    isJobOpen = true;
                    break;
                }
            }
            return isJobOpen;
        }

        public void openSelectedJob(string recevedJobName, string recevedJobNumber)
        {
            openSelectedJob(recevedJobName, recevedJobNumber, true);
        }

        public void openSelectedJob(string recevedJobName, string recevedJobNumber, bool focusOnNewJob)
        {
            if (!isJobOpenInTab(recevedJobName, recevedJobNumber))
            {
                JobUserControl openedJobs = new JobUserControl(Username, recevedJobNumber); //Creats instance of our new job screen
                openedJobs.Dock = DockStyle.Fill; //set it to fill its parrents container
                TabPage newJobPage = new TabPage(recevedJobName + " " + recevedJobNumber); //creating new tab instance
                newJobPage.Name = recevedJobNumber + "Tab";
                openedJobs.Parent = newJobPage; //setting user controls parrent to the new tab
                jobTabControl.TabPages.Add(newJobPage); //adding the new tab to the tab list
                if (focusOnNewJob)
                {
                    focusOnJob(recevedJobName, recevedJobNumber);
                }
            }
            else
            {
                if (focusOnNewJob)
                {
                    focusOnJob(recevedJobName, recevedJobNumber);
                }
            }
        }

        private void jobTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jobTabControl.SelectedIndex == 0)
            {
                fillJobList();
            }
        }

        public void hideShowButtons()
        {
            if (jobNamesListBox.SelectedIndex != -1 || jobNumbersListBox.SelectedIndex != -1)
            {
                openJobButton.Visible = true;
                deleteJobBtn.Visible = true;
                deleteJobToolStripMenuItem.Visible = true;
                changeJobNameBtn.Visible = true;
            }
            else
            {
                openJobButton.Visible = false;
                deleteJobBtn.Visible = false;
                deleteJobToolStripMenuItem.Visible = false;
                changeJobNameBtn.Visible = false;
            }
        }
        #endregion

    }
}
