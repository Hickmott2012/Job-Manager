using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSheetProgram
{
    public partial class newJobFrm : Form
    {
        private string returnJobNumber;
        private string returnJobName;
        private int jobNumberInt;

        public newJobFrm()
        {
            InitializeComponent();
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
            if (newJobNumberTextBox.Text != "" && newJobNameTextBox.Text != "" && int.TryParse(newJobNumberTextBox.Text, out jobNumberInt))
            {
                returnJobNumber = newJobNumberTextBox.Text;
                returnJobName = newJobNameTextBox.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                errorLable.Visible = true;
            }
        }

    }
}
