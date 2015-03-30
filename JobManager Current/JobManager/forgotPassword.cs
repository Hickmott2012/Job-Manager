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

namespace TimeSheetProgram
{
    public partial class forgotPasswordFrm : Form
    {
        //Variables
        public const string REQUIREDFOLDER = GlobalVars.REQUIREDFOLDER;
        public const string PASSWORDFILE = GlobalVars.PASSWORDFILE;

        //Deafult Constructor
        public forgotPasswordFrm()
        {
            InitializeComponent();
        }

        //Constructor
        public forgotPasswordFrm(string currentUserName)
        {
            InitializeComponent();
            userNameTextBox.Text = currentUserName;
            userNameTextBox.Enabled = false;
        }
        
        private void submitButton_Click(object sender, EventArgs e)
        {
            bool changePasswordSucess = false;
            string strUserName = userNameTextBox.Text;
            string strPassword = passwordTextBox.Text;

            changePasswordSucess = changeUsersPassword(strUserName, strPassword);

            if (changePasswordSucess == true)
            {
                DialogResult = DialogResult.OK;
                MessageBox.Show("The Password for " + strUserName +" account has been changed",
                    "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult = DialogResult.None;
                errorLabel.Show();
                
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public string getUserDirectory(string username)
        {
                return REQUIREDFOLDER + username + "\\";
        }

        public string getUserPasswordFile(string username)
        {
                return REQUIREDFOLDER + username + "\\" + PASSWORDFILE;
        }

        public bool changeUsersPassword(string username, string newpassword)
        {
            bool changePasswordResults = false;
            string userName = username;
            string newPassword = newpassword;

            if (userName == "" || newPassword == "")
            {
                changePasswordResults = false;
            }
            else if (Directory.Exists(getUserDirectory(userName)))
            {
                string fileName = getUserPasswordFile(userName);

                try
                {
                    using (FileStream WritePassword = new FileStream(fileName,
                    FileMode.Truncate, FileAccess.Write))
                    {
                        using (StreamWriter write = new StreamWriter(WritePassword))
                        {
                            write.WriteLine(newPassword);
                            write.Close();
                        }
                        WritePassword.Close();
                        changePasswordResults = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Oh No... File corrupted.");
                    changePasswordResults = false;
                }
            }

            return changePasswordResults;
        }
    }
}
