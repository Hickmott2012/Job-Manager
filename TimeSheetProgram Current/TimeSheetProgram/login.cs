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
    public partial class login : Form
    {
        private static string username = "";
        private static string password = "";
        private static bool loginSuccess = false;
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
                userScreenFrm UserScreen = new userScreenFrm(Username, Password);
                UserScreen.Show();
                this.Hide();                
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
                MessageBox.Show("User Password Was NOT changed");
            }
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void login_Load(object sender, EventArgs e)
        {
            //Check to see if the Required ProgramFiles folder exist
            if (!Directory.Exists(GlobalVars.REQUIREDFOLDER))
            {
                Directory.CreateDirectory(GlobalVars.REQUIREDFOLDER);
            }
            
            //Remember to create admin account here

            //Checks to see if the Job codes file exist
            if (!File.Exists(GlobalVars.REQUIREDFOLDER + GlobalVars.JOBCODESFILE))
            {
                //Create the job Codes File Here
                FileStream createJobCodesFile = new FileStream(GlobalVars.REQUIREDFOLDER + GlobalVars.JOBCODESFILE,
                    FileMode.Create, FileAccess.Write);
                StreamWriter write = new StreamWriter(createJobCodesFile);
                write.WriteLine("JOB");
                write.Close();
                createJobCodesFile.Close();
            }
        }
    }
}

