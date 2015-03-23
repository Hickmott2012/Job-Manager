//Programer: Benjamin Hickmott
//Project Name: Job Manager
//Start Date: 02/27/15

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GlobalVariables;

namespace TimeSheetProgram
{
    class userControls
    {
        private string userName;
        public const string REQUIREDFOLDER = GlobalVars.REQUIREDFOLDER;
        public const string PASSWORDFILE = GlobalVars.PASSWORDFILE;
        public const string JOBFILEEXTENSHION = GlobalVars.JOBFILEEXTENSHION;
        public string UserName
        {
            get 
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        public void createUser(string usernameToCreate, string passwordToCreate)
        {
            usernameToCreate.ToLower();
            try
            {
                Directory.CreateDirectory(REQUIREDFOLDER + usernameToCreate);
                using (FileStream WritePassword = new FileStream(REQUIREDFOLDER + usernameToCreate + "\\" + PASSWORDFILE,
                FileMode.CreateNew, FileAccess.Write))
                {
                    using (StreamWriter write = new StreamWriter(WritePassword))
                    {
                        write.WriteLine(passwordToCreate);
                        write.Close();
                    }
                    WritePassword.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Oh No... User Not Created.");
            }
        }

        public void deleteUser(string userToDelete)
        {
            if (MessageBox.Show("Are You Sure You Want to Delete " + userToDelete
                +  " and all there Jobs?", "Delete User", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Directory.Delete(REQUIREDFOLDER + userToDelete, true);
            }
        }

        public void createNewJobForSelectedUser(string selectedUser, string newJobNumber, string newJobName)
        {
            string newJobDirectory;
            newJobDirectory = REQUIREDFOLDER + selectedUser + "\\" + newJobNumber + JOBFILEEXTENSHION;
            FileStream creatJob = new FileStream(newJobDirectory, FileMode.Create, FileAccess.Write);
            StreamWriter write = new StreamWriter(creatJob);
            write.WriteLine(newJobName);
            write.WriteLine("JOB");
            write.WriteLine(DateTime.Now);
            write.WriteLine(DateTime.Now);
            write.WriteLine("");
            write.WriteLine(0);
            write.WriteLine("No Job Selcted");
            write.Write("");
            write.Close();
            creatJob.Close();
        }
        
        public void deleteJobForSelectedUser(string selectedUser, string selectedUserJob)
        {
            int cutAt = selectedUserJob.IndexOf(" ");
            selectedUserJob = selectedUserJob.Remove(cutAt);
            File.Delete(REQUIREDFOLDER + selectedUser + "\\" + selectedUserJob + JOBFILEEXTENSHION);
        }
    }
}
