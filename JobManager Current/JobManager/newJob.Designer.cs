namespace JobManager
{
    partial class newJobFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newJobFrm));
            this.errorLable = new System.Windows.Forms.Label();
            this.newJobNameTextBox = new System.Windows.Forms.TextBox();
            this.newJobNumberLable = new System.Windows.Forms.Label();
            this.newJobLable = new System.Windows.Forms.Label();
            this.newJobNumberTextBox = new System.Windows.Forms.TextBox();
            this.newJobSubmitBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.errorNumExistLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // errorLable
            // 
            this.errorLable.AutoSize = true;
            this.errorLable.ForeColor = System.Drawing.Color.Red;
            this.errorLable.Location = new System.Drawing.Point(12, 112);
            this.errorLable.Name = "errorLable";
            this.errorLable.Size = new System.Drawing.Size(244, 17);
            this.errorLable.TabIndex = 6;
            this.errorLable.Text = "Error: Enter a Job Name and Number";
            this.errorLable.Visible = false;
            // 
            // newJobNameTextBox
            // 
            this.newJobNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newJobNameTextBox.Location = new System.Drawing.Point(16, 29);
            this.newJobNameTextBox.Name = "newJobNameTextBox";
            this.newJobNameTextBox.Size = new System.Drawing.Size(240, 24);
            this.newJobNameTextBox.TabIndex = 1;
            // 
            // newJobNumberLable
            // 
            this.newJobNumberLable.AutoSize = true;
            this.newJobNumberLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newJobNumberLable.Location = new System.Drawing.Point(13, 59);
            this.newJobNumberLable.Name = "newJobNumberLable";
            this.newJobNumberLable.Size = new System.Drawing.Size(128, 18);
            this.newJobNumberLable.TabIndex = 58;
            this.newJobNumberLable.Text = "New Job Number:";
            // 
            // newJobLable
            // 
            this.newJobLable.AutoSize = true;
            this.newJobLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newJobLable.Location = new System.Drawing.Point(13, 6);
            this.newJobLable.Name = "newJobLable";
            this.newJobLable.Size = new System.Drawing.Size(115, 18);
            this.newJobLable.TabIndex = 57;
            this.newJobLable.Text = "New Job Name:";
            // 
            // newJobNumberTextBox
            // 
            this.newJobNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newJobNumberTextBox.Location = new System.Drawing.Point(16, 82);
            this.newJobNumberTextBox.Name = "newJobNumberTextBox";
            this.newJobNumberTextBox.Size = new System.Drawing.Size(240, 24);
            this.newJobNumberTextBox.TabIndex = 2;
            // 
            // newJobSubmitBtn
            // 
            this.newJobSubmitBtn.Location = new System.Drawing.Point(15, 136);
            this.newJobSubmitBtn.Name = "newJobSubmitBtn";
            this.newJobSubmitBtn.Size = new System.Drawing.Size(117, 26);
            this.newJobSubmitBtn.TabIndex = 3;
            this.newJobSubmitBtn.Text = "Submit";
            this.newJobSubmitBtn.UseVisualStyleBackColor = true;
            this.newJobSubmitBtn.Click += new System.EventHandler(this.newJobSubmitBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(138, 136);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(117, 26);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // errorNumExistLabel
            // 
            this.errorNumExistLabel.AutoSize = true;
            this.errorNumExistLabel.ForeColor = System.Drawing.Color.Red;
            this.errorNumExistLabel.Location = new System.Drawing.Point(138, 61);
            this.errorNumExistLabel.Name = "errorNumExistLabel";
            this.errorNumExistLabel.Size = new System.Drawing.Size(131, 17);
            this.errorNumExistLabel.TabIndex = 59;
            this.errorNumExistLabel.Text = "Error: Number Exist";
            this.errorNumExistLabel.Visible = false;
            // 
            // newJobFrm
            // 
            this.AcceptButton = this.newJobSubmitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(272, 171);
            this.Controls.Add(this.errorNumExistLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.newJobNumberTextBox);
            this.Controls.Add(this.newJobNameTextBox);
            this.Controls.Add(this.newJobNumberLable);
            this.Controls.Add(this.newJobLable);
            this.Controls.Add(this.newJobSubmitBtn);
            this.Controls.Add(this.errorLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newJobFrm";
            this.Text = "New Job";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLable;
        private System.Windows.Forms.TextBox newJobNameTextBox;
        private System.Windows.Forms.Label newJobNumberLable;
        private System.Windows.Forms.Label newJobLable;
        private System.Windows.Forms.TextBox newJobNumberTextBox;
        private System.Windows.Forms.Button newJobSubmitBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label errorNumExistLabel;
    }
}