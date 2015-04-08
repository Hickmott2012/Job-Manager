//Programer: Benjamin Hickmott
//Project Name: Job Manager
//Start Date: 02/27/15

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
    public partial class userScreenFrm : Form
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

        #region UserScreen
        //Constructor
        public userScreenFrm(string receivedUserName, string receivedPassword)
        {
            username = receivedUserName;
            password = receivedPassword;
            InitializeComponent();
            fillCurrentUsersList();
            fillJobCodesList();
            this.Text = Username + "\'s User Control Screen";
        } 
        
        //Screen Close
        private void userScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        //Screen Load
        private void userScreen_Load(object sender, EventArgs e)
        {
            userNameLabel.Text = Username;
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
                MessageBox.Show("User Password Was NOT changed", "Password Not Changed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            changeCurrentUserPassword = null;
        }
        #endregion

        #region User Controls

        public void fillCurrentUsersList()
        {
            newUserErrorLabel.Visible = false;
            userNamesListBox.ClearSelected();
            userNamesListBox.Items.Clear();
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(REQUIREDFOLDER); 
            foreach (System.IO.DirectoryInfo users in dir.GetDirectories())
            {
                if (users.ToString() != "Admin")
                {
                    userNamesListBox.Items.Add(users.ToString());
                }
            }
        }

        public void fillSelectedUsersJobList(string selectedUserToFillJobList)
        {
            selectedUsersJobListBox.Items.Clear();
            selectedUsersJobListBox.ClearSelected();
            foreach (string jobNumberFile in Directory.EnumerateFiles(REQUIREDFOLDER + selectedUserToFillJobList, "*.job"))
            {
                string jobNumber = jobNumberFile.Replace(".job", "");
                jobNumber = jobNumber.Replace(REQUIREDFOLDER + selectedUserToFillJobList + "\\", "");
                FileStream ReadJobName = new FileStream(jobNumberFile, FileMode.Open, FileAccess.Read);
                StreamReader read = new StreamReader(ReadJobName);
                string jobName = read.ReadLine();
                if (jobName != "" && jobName != null)
                {
                    selectedUsersJobListBox.Items.Add(jobNumber + " " + jobName);
                }
                else
                {
                    selectedUsersJobListBox.Items.Add(jobNumber + " " + "Unnamed");
                }
                ReadJobName.Close();
                read.Close();
            }
        }

        private void deleteUserBtn2_Click(object sender, EventArgs e)
        {
            if (userNamesListBox.SelectedItem.ToString().ToLower() != "admin")
            {
                userControls deleteSelectedUser = new userControls();
                deleteSelectedUser.deleteUser(userNamesListBox.SelectedItem.ToString());
                deleteSelectedUser = null;
                fillCurrentUsersList();
            }
            else
            {
                MessageBox.Show("Error: You Can't Delete the Admin Account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void userNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userNamesListBox.SelectedIndex != -1)
            {
                deleteUserBtn2.Visible = true;
                fillSelectedUsersJobList(userNamesListBox.SelectedItem.ToString());
                selectedUsersJobListBox.Visible = true;
                newJobPanel.Visible = true;
            }
            else
            {
                deleteUserBtn2.Visible = false;
                selectedUsersJobListBox.Visible = false;
                newJobPanel.Visible = false;
            }
        }

        private void newUserBtn2_Click(object sender, EventArgs e)
        {
            string newUserName = newUserNameTextBox.Text;
            string newPassword = newUserPassowrdTextBox.Text;

            if (newUserName != "" && newPassword != "" && !Directory.Exists(REQUIREDFOLDER + newUserName.ToLower()))
            {
                userControls createNewUser = new userControls();
                createNewUser.createUser(newUserNameTextBox.Text, newUserPassowrdTextBox.Text);
                fillCurrentUsersList();
                createNewUser = null;
            }
            else
            {
                newUserErrorLabel.Visible = true;
            }
        }


        private void selectedUsersJobListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedUsersJobListBox.SelectedIndex != -1)
            {
                try
                {
                    deleteSelectedUserJobBtn.Visible = true;
                    editSelectedfUserJobBtn.Visible = true;
                }
                catch
                {

                }
            }
            else
            {
                deleteSelectedUserJobBtn.Visible = false;
                editSelectedfUserJobBtn.Visible = false;
            }
        }

        private void deleteSelectedUserJobBtn_Click(object sender, EventArgs e)
        {
            userControls deleteSelectedUserJob = new userControls();
            deleteSelectedUserJob.deleteJobForSelectedUser(userNamesListBox.SelectedItem.ToString(), selectedUsersJobListBox.SelectedItem.ToString());
            fillSelectedUsersJobList(userNamesListBox.SelectedItem.ToString());
            deleteSelectedUserJobBtn = null;
        }

        private void newJobBtn2_Click(object sender, EventArgs e)
        {
            int jobNumberInt;
            if (newJobNameTextBox.Text != "" && newJobNumberTextBox.Text != "" && int.TryParse(newJobNumberTextBox.Text, out jobNumberInt) && !doseFileExist(newJobNumberTextBox.Text.ToString()))
            {
                newJobErrorLabel.Visible = false;
                errorNumExistLabel.Visible = false;
                userControls createNewJobForSelectedUser = new userControls();
                createNewJobForSelectedUser.createNewJobForSelectedUser(userNamesListBox.SelectedItem.ToString(), newJobNumberTextBox.Text, newJobNameTextBox.Text);
                newJobNameTextBox.Text = "";
                newJobNumberTextBox.Text = "";
                fillSelectedUsersJobList(userNamesListBox.SelectedItem.ToString());
            }
            else if (newJobNumberTextBox.Text != "" && newJobNameTextBox.Text != "" && int.TryParse(newJobNumberTextBox.Text, out jobNumberInt) && doseFileExist(newJobNumberTextBox.Text.ToString()))
            {
                errorNumExistLabel.Visible = true;
            }
            else
            {
                newJobErrorLabel.Visible = true;
            }
        }

        public bool doseFileExist(string jobNumber)
        {
            return File.Exists(REQUIREDFOLDER + userNamesListBox.SelectedItem.ToString() + "\\" + jobNumber + JOBFILEEXTENSHION);
        }

        private void editSelectedfUserJobBtn_Click(object sender, EventArgs e)
        {
            editJob editSelectedUsersJob = new editJob(userNamesListBox.SelectedItem.ToString(), selectedUsersJobListBox.SelectedItem.ToString());
            editSelectedUsersJob.ShowDialog();
            if (editSelectedUsersJob.DialogResult != DialogResult.OK)
            {
                MessageBox.Show("Current Job Was Not Saved", "Error Job Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fillJobCodesList()
        {
            jobCodesListBox.ClearSelected();
            jobCodesListBox.Items.Clear();
            string jobCodeString;
            FileStream ReadJobCodes = new FileStream(REQUIREDFOLDER + JOBCODESFILE, FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(ReadJobCodes);

            jobCodeString = read.ReadLine();

            while (jobCodeString != null)
            {
                jobCodesListBox.Items.Add(jobCodeString);
                jobCodeString = read.ReadLine();
            }
            read.Close();
            ReadJobCodes.Close();
        }

        private void jobCodesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jobCodesListBox.SelectedIndex != -1)
            {
                deleteJobCodeBtn.Visible = true;
            }
            else
            {
                deleteJobCodeBtn.Visible = false;
            }
        }

        private void createJobCodeBtn_Click(object sender, EventArgs e)
        {
            if (newJobCodeTextBox.Text != "")
            {
                jobControls addNewJobCode = new jobControls(Username);
                addNewJobCode.addJobCode(newJobCodeTextBox.Text);
                addNewJobCode = null;
                fillJobCodesList();
                newJobCodeTextBox.Text = "";
            }
            else
            {
                newJobCodeErrorLabel.Visible = true;
            }

        }

        private void deleteJobCodeBtn_Click(object sender, EventArgs e)
        {
            jobControls deleteJobCode = new jobControls(Username);
            deleteJobCode.deleteJobCode(jobCodesListBox.SelectedItem.ToString());
            fillJobCodesList();
            deleteJobCode = null;
        }
        #endregion
    }
}
