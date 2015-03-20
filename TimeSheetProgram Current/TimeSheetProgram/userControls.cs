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

        //Constructor
        public userControls()
        {

        }
        public void creatUser(string username, string password)
        {
            
        }
        public void editUser()
        {

        }
        public void deleteUser()
        {

        }
       //public static void openUserFile()
       // {
            
       //     if (UserName != "" && Directory.Exists(DirectoryName))
       //     {
       //         //Open Passsword file to check if password matches
       //         string fileName = "";

       //         //set password file
       //         fileName = DirectoryName + PASSWORDFILE;

       //         try
       //         {
       //             using (FileStream ReadUser = new FileStream(fileName,
       //             FileMode.Open, FileAccess.Read))
       //             {
       //                 using (StreamReader read = new StreamReader(ReadUser))
       //                 {
       //                     string foundPassword;

       //                     foundPassword = read.ReadLine();
       //                     if (Password == foundPassword)
       //                     {
       //                         success = true;
       //                     }
       //                     else
       //                     {
       //                         success = false;
       //                     }
       //                     read.Close();
       //                 }
       //                 ReadUser.Close();
       //             }
       //         }
       //         catch (Exception)
       //         {
       //             MessageBox.Show("Oh No... File corrupted.");
       //             success = false;
       //         }
       //     }
       //     else
       //     {
       //         success = false;
       //     }
       //     return success;
       // }
        //}
    }
}
