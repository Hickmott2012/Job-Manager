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
    public partial class login : Form
    {
        private static string username = "";
        private static string password = "";
        private static bool loginSuccess = false;
        public const string REQUIREDFOLDER = GlobalVars.REQUIREDFOLDER;
        public const string JOBCODESFILE = GlobalVars.JOBCODESFILE;
        public static string Username
        {
            get
            {
                return username;
            }
        }
        public static string Password
        {
            get
            {
                return password;
            }
        }

        public login()
        {
            InitializeComponent();
        }
        public static bool LoginSuccess
        {
            get
            {
                return loginSuccess;
            }
        }
        

        private void submitButton_Click(object sender, EventArgs e)
        {
            
            //Take in information
            username = userNameTextBox.Text.ToLower();
            username = username.Substring(0, 1).ToUpper() + username.Substring(1);
            password = passwordMaskedTextBox.Text;

            userLogin user = new userLogin(Username, Password);
            
            loginSuccess = user.accountLogin();
            if (loginSuccess == true)
            {
                if (Username.ToLower() != "admin")
                {
                    JobControlScreenFrm UserScreen = new JobControlScreenFrm(Username, Password);
                    UserScreen.Show();
                    this.Hide();
                }
                else
                {
                    userScreenFrm UserScreen = new userScreenFrm(Username, Password);
                    UserScreen.Show();
                    this.Hide();
                }
            }
            else
            {
                incorrectPasswordLabel.Show();
                passwordMaskedTextBox.SelectAll();
            }

        }

        private void forgotPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotPasswordFrm forgotpassword = new forgotPasswordFrm();
            forgotpassword.ShowDialog();
            if (forgotpassword.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("User Password Was NOT changed", "Password Not Changed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void login_Load(object sender, EventArgs e)
        {
            //Check to see if the Required ProgramFiles folder exist
            if (!Directory.Exists(REQUIREDFOLDER))
            {
                Directory.CreateDirectory(REQUIREDFOLDER);
            }
            
            if (!Directory.Exists(REQUIREDFOLDER + "Admin"))
            {
                userControls creatTheAdminUser = new userControls();
                creatTheAdminUser.createUser("admin", "admin");
                creatTheAdminUser = null;
            }

            //Checks to see if the Job codes file exist
            if (!File.Exists(REQUIREDFOLDER + JOBCODESFILE))
            {
                //Create the job Codes File Here
                FileStream createJobCodesFile = new FileStream(REQUIREDFOLDER + JOBCODESFILE,
                    FileMode.Create, FileAccess.Write);
                StreamWriter write = new StreamWriter(createJobCodesFile);
                write.WriteLine("JOB");
                write.Close();
                createJobCodesFile.Close();
            }
        }
    }
}

