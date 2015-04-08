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
    public partial class newJobFrm : Form
    {
        private string returnJobNumber;
        private string returnJobName;
        private int jobNumberInt;
        private int oldJobNumber;
        private string userName;
        private bool oldNumberSupplied = false;
        public const string REQUIREDFOLDER = GlobalVars.REQUIREDFOLDER;
        public const string JOBFILEEXTENSHION = GlobalVars.JOBFILEEXTENSHION;
        
        public newJobFrm(string recievedUserName)
        {
            InitializeComponent();
            userName = recievedUserName;    
        }

        public newJobFrm(string recievedUserName, int oldJobNumberToChange)
        {
            InitializeComponent();
            userName = recievedUserName;
            oldJobNumber = oldJobNumberToChange;
            oldNumberSupplied = true;
        }

        public string UserName
        {
            get
            {
                return userName;
            }
        }

        public string ReturnJobNumber
        {
            get
            {
                return returnJobNumber;
            }
        }

        public string ReturnJobName
        {
            get
            {
                return returnJobName;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void newJobSubmitBtn_Click(object sender, EventArgs e)
        {
            if (newJobNumberTextBox.Text != "" && newJobNameTextBox.Text != "" && int.TryParse(newJobNumberTextBox.Text, out jobNumberInt) && !doseFileExist(newJobNumberTextBox.Text.ToString()))
            {
                returnJobNumber = newJobNumberTextBox.Text;
                returnJobName = newJobNameTextBox.Text;
                DialogResult = DialogResult.OK;
            }
            else if (newJobNumberTextBox.Text != "" && newJobNameTextBox.Text != "" && int.TryParse(newJobNumberTextBox.Text, out jobNumberInt) && doseFileExist(newJobNumberTextBox.Text.ToString()))
            {
                if (oldNumberSupplied && oldJobNumber == Convert.ToInt32(newJobNumberTextBox.Text))
                {
                    returnJobNumber = newJobNumberTextBox.Text;
                    returnJobName = newJobNameTextBox.Text;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    errorNumExistLabel.Visible = true;
                }
            }
            else
            {
                errorLable.Visible = true;
            }
        }

        public bool doseFileExist(string jobNumber)
        {
            return File.Exists(REQUIREDFOLDER + UserName + "\\" + jobNumber + JOBFILEEXTENSHION);
        }

    }
}
