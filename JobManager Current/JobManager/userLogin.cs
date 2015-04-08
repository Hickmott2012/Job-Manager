//Programer: Benjamin Hickmott
//Project Name: Job Manager
//Start Date: 02/27/15

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using GlobalVariables;

namespace JobManager
{
    public class userLogin
    {        
        //Private Variables
        private static string username = "";
        private static string password = "";
        private static string directoryName;
        private static bool success = false;
        
        //Public Varables
        public const string REQUIREDFOLDER = GlobalVars.REQUIREDFOLDER;
        public const string PASSWORDFILE = GlobalVars.PASSWORDFILE;


        //Public Accessors
        public string UserName
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public static string DirectoryName
        {
            get
            {
                return directoryName;
            }
            set
            {
                directoryName = REQUIREDFOLDER + value + "\\";
            }
        }

        //Defult Constructor
        public userLogin()
        {
            password = "";
            username = "";

        }
        //Overloaded Constructor
        public userLogin(string usernamePassed, string passwordPassed)
        {
            username = usernamePassed;
            password = passwordPassed;
        }

        //Open Accounts file and check login cridentials
        public bool accountLogin()
        {      

            DirectoryName = UserName;
            if (UserName != "" && Directory.Exists(DirectoryName))
            {
                //Open Passsword file to check if password matches
                string fileName = "";

                //set password file
                fileName = DirectoryName + PASSWORDFILE;

                try
                {
                    using (FileStream ReadUser = new FileStream(fileName,
                    FileMode.Open, FileAccess.Read))
                    {
                        using (StreamReader read = new StreamReader(ReadUser))
                        {
                            string foundPassword;

                            foundPassword = read.ReadLine();
                            if (Password == foundPassword)
                            {
                                success = true;
                            }
                            else
                            {
                                success = false;
                            }
                            read.Close();
                        }
                        ReadUser.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Oh No... File corrupted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    success = false;
                }
            }
            else
            {
                success = false;
            }
            return success;
        }
    }
}
