namespace JobManager
{
    partial class JobUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.jobNumberLabel = new System.Windows.Forms.Label();
            this.jobNumberLabelText = new System.Windows.Forms.Label();
            this.jobNameLabel = new System.Windows.Forms.Label();
            this.jobNameLabelText = new System.Windows.Forms.Label();
            this.jobControlPanel = new System.Windows.Forms.Panel();
            this.deleteJobBtn = new System.Windows.Forms.Button();
            this.jobCodesComboBox = new System.Windows.Forms.ComboBox();
            this.jobStatusErrorLabel = new System.Windows.Forms.Label();
            this.jobCodeErrorLabel = new System.Windows.Forms.Label();
            this.jobEndDateErrorLabel = new System.Windows.Forms.Label();
            this.jobEstimateErrorLabel = new System.Windows.Forms.Label();
            this.jobEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.jobStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.jobEndDateLabel = new System.Windows.Forms.Label();
            this.jobStartDateLabel = new System.Windows.Forms.Label();
            this.lastTimeUpdateLabel = new System.Windows.Forms.Label();
            this.saveJobButton = new System.Windows.Forms.Button();
            this.jobEstimateTextBox = new System.Windows.Forms.TextBox();
            this.jobCostEstimateLabel = new System.Windows.Forms.Label();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.jobEmployeesPanel = new System.Windows.Forms.Panel();
            this.newEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.deleteEmployeeBtn = new System.Windows.Forms.Button();
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.jobStatusPanel = new System.Windows.Forms.Panel();
            this.delayedJobStatRadioButton = new System.Windows.Forms.RadioButton();
            this.inProgressJobStatRadioButton = new System.Windows.Forms.RadioButton();
            this.completJobStatRadioButton = new System.Windows.Forms.RadioButton();
            this.jobStatusLabel = new System.Windows.Forms.Label();
            this.jobCodeLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.jobNotesTextBox = new System.Windows.Forms.TextBox();
            this.jobControlPanel.SuspendLayout();
            this.jobEmployeesPanel.SuspendLayout();
            this.jobStatusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // jobNumberLabel
            // 
            this.jobNumberLabel.AutoSize = true;
            this.jobNumberLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobNumberLabel.Location = new System.Drawing.Point(427, 23);
            this.jobNumberLabel.Name = "jobNumberLabel";
            this.jobNumberLabel.Size = new System.Drawing.Size(150, 22);
            this.jobNumberLabel.TabIndex = 64;
            this.jobNumberLabel.Text = "Job Number Here";
            // 
            // jobNumberLabelText
            // 
            this.jobNumberLabelText.AutoSize = true;
            this.jobNumberLabelText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobNumberLabelText.Location = new System.Drawing.Point(303, 23);
            this.jobNumberLabelText.Name = "jobNumberLabelText";
            this.jobNumberLabelText.Size = new System.Drawing.Size(112, 22);
            this.jobNumberLabelText.TabIndex = 63;
            this.jobNumberLabelText.Text = "Job Number:";
            // 
            // jobNameLabel
            // 
            this.jobNameLabel.AutoSize = true;
            this.jobNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobNameLabel.Location = new System.Drawing.Point(122, 24);
            this.jobNameLabel.Name = "jobNameLabel";
            this.jobNameLabel.Size = new System.Drawing.Size(133, 22);
            this.jobNameLabel.TabIndex = 62;
            this.jobNameLabel.Text = "Job Name Here";
            // 
            // jobNameLabelText
            // 
            this.jobNameLabelText.AutoSize = true;
            this.jobNameLabelText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobNameLabelText.Location = new System.Drawing.Point(15, 24);
            this.jobNameLabelText.Name = "jobNameLabelText";
            this.jobNameLabelText.Size = new System.Drawing.Size(95, 22);
            this.jobNameLabelText.TabIndex = 61;
            this.jobNameLabelText.Text = "Job Name:";
            // 
            // jobControlPanel
            // 
            this.jobControlPanel.Controls.Add(this.deleteJobBtn);
            this.jobControlPanel.Controls.Add(this.jobCodesComboBox);
            this.jobControlPanel.Controls.Add(this.jobStatusErrorLabel);
            this.jobControlPanel.Controls.Add(this.jobCodeErrorLabel);
            this.jobControlPanel.Controls.Add(this.jobEndDateErrorLabel);
            this.jobControlPanel.Controls.Add(this.jobEstimateErrorLabel);
            this.jobControlPanel.Controls.Add(this.jobEndDateTimePicker);
            this.jobControlPanel.Controls.Add(this.jobStartDateTimePicker);
            this.jobControlPanel.Controls.Add(this.jobEndDateLabel);
            this.jobControlPanel.Controls.Add(this.jobStartDateLabel);
            this.jobControlPanel.Controls.Add(this.lastTimeUpdateLabel);
            this.jobControlPanel.Controls.Add(this.saveJobButton);
            this.jobControlPanel.Controls.Add(this.jobEstimateTextBox);
            this.jobControlPanel.Controls.Add(this.jobCostEstimateLabel);
            this.jobControlPanel.Controls.Add(this.employeeLabel);
            this.jobControlPanel.Controls.Add(this.jobEmployeesPanel);
            this.jobControlPanel.Controls.Add(this.jobStatusPanel);
            this.jobControlPanel.Controls.Add(this.jobCodeLabel);
            this.jobControlPanel.Controls.Add(this.notesLabel);
            this.jobControlPanel.Controls.Add(this.jobNotesTextBox);
            this.jobControlPanel.Location = new System.Drawing.Point(3, 66);
            this.jobControlPanel.Name = "jobControlPanel";
            this.jobControlPanel.Size = new System.Drawing.Size(750, 370);
            this.jobControlPanel.TabIndex = 58;
            // 
            // deleteJobBtn
            // 
            this.deleteJobBtn.Location = new System.Drawing.Point(9, 337);
            this.deleteJobBtn.Name = "deleteJobBtn";
            this.deleteJobBtn.Size = new System.Drawing.Size(146, 26);
            this.deleteJobBtn.TabIndex = 59;
            this.deleteJobBtn.Text = "Delete Job";
            this.deleteJobBtn.UseVisualStyleBackColor = true;
            this.deleteJobBtn.Click += new System.EventHandler(this.deleteJobBtn_Click);
            // 
            // jobCodesComboBox
            // 
            this.jobCodesComboBox.FormattingEnabled = true;
            this.jobCodesComboBox.Location = new System.Drawing.Point(304, 45);
            this.jobCodesComboBox.Name = "jobCodesComboBox";
            this.jobCodesComboBox.Size = new System.Drawing.Size(160, 24);
            this.jobCodesComboBox.TabIndex = 58;
            // 
            // jobStatusErrorLabel
            // 
            this.jobStatusErrorLabel.AutoSize = true;
            this.jobStatusErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.jobStatusErrorLabel.Location = new System.Drawing.Point(331, 230);
            this.jobStatusErrorLabel.Name = "jobStatusErrorLabel";
            this.jobStatusErrorLabel.Size = new System.Drawing.Size(131, 17);
            this.jobStatusErrorLabel.TabIndex = 57;
            this.jobStatusErrorLabel.Text = "Chose a Job Status";
            this.jobStatusErrorLabel.Visible = false;
            // 
            // jobCodeErrorLabel
            // 
            this.jobCodeErrorLabel.AutoSize = true;
            this.jobCodeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.jobCodeErrorLabel.Location = new System.Drawing.Point(323, 74);
            this.jobCodeErrorLabel.Name = "jobCodeErrorLabel";
            this.jobCodeErrorLabel.Size = new System.Drawing.Size(123, 17);
            this.jobCodeErrorLabel.TabIndex = 56;
            this.jobCodeErrorLabel.Text = "Select a Job Code";
            this.jobCodeErrorLabel.Visible = false;
            // 
            // jobEndDateErrorLabel
            // 
            this.jobEndDateErrorLabel.AutoSize = true;
            this.jobEndDateErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.jobEndDateErrorLabel.Location = new System.Drawing.Point(28, 89);
            this.jobEndDateErrorLabel.Name = "jobEndDateErrorLabel";
            this.jobEndDateErrorLabel.Size = new System.Drawing.Size(224, 17);
            this.jobEndDateErrorLabel.TabIndex = 55;
            this.jobEndDateErrorLabel.Text = "End Date Must Be After Start Date";
            this.jobEndDateErrorLabel.Visible = false;
            // 
            // jobEstimateErrorLabel
            // 
            this.jobEstimateErrorLabel.AutoSize = true;
            this.jobEstimateErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.jobEstimateErrorLabel.Location = new System.Drawing.Point(525, 74);
            this.jobEstimateErrorLabel.Name = "jobEstimateErrorLabel";
            this.jobEstimateErrorLabel.Size = new System.Drawing.Size(183, 17);
            this.jobEstimateErrorLabel.TabIndex = 54;
            this.jobEstimateErrorLabel.Text = "Estimate Must Be a Number";
            this.jobEstimateErrorLabel.Visible = false;
            // 
            // jobEndDateTimePicker
            // 
            this.jobEndDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.jobEndDateTimePicker.Location = new System.Drawing.Point(148, 63);
            this.jobEndDateTimePicker.Name = "jobEndDateTimePicker";
            this.jobEndDateTimePicker.Size = new System.Drawing.Size(119, 22);
            this.jobEndDateTimePicker.TabIndex = 53;
            // 
            // jobStartDateTimePicker
            // 
            this.jobStartDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.jobStartDateTimePicker.Location = new System.Drawing.Point(148, 18);
            this.jobStartDateTimePicker.Name = "jobStartDateTimePicker";
            this.jobStartDateTimePicker.Size = new System.Drawing.Size(119, 22);
            this.jobStartDateTimePicker.TabIndex = 2;
            // 
            // jobEndDateLabel
            // 
            this.jobEndDateLabel.AutoSize = true;
            this.jobEndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobEndDateLabel.Location = new System.Drawing.Point(10, 65);
            this.jobEndDateLabel.Name = "jobEndDateLabel";
            this.jobEndDateLabel.Size = new System.Drawing.Size(102, 18);
            this.jobEndDateLabel.TabIndex = 51;
            this.jobEndDateLabel.Text = "Job End Date:";
            // 
            // jobStartDateLabel
            // 
            this.jobStartDateLabel.AutoSize = true;
            this.jobStartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobStartDateLabel.Location = new System.Drawing.Point(10, 20);
            this.jobStartDateLabel.Name = "jobStartDateLabel";
            this.jobStartDateLabel.Size = new System.Drawing.Size(107, 18);
            this.jobStartDateLabel.TabIndex = 49;
            this.jobStartDateLabel.Text = "Job Start Date:";
            // 
            // lastTimeUpdateLabel
            // 
            this.lastTimeUpdateLabel.AutoSize = true;
            this.lastTimeUpdateLabel.Location = new System.Drawing.Point(330, 289);
            this.lastTimeUpdateLabel.Name = "lastTimeUpdateLabel";
            this.lastTimeUpdateLabel.Size = new System.Drawing.Size(132, 51);
            this.lastTimeUpdateLabel.TabIndex = 47;
            this.lastTimeUpdateLabel.Text = "Last Time Updated:\r\nMM/DD/YYYY\r\n00:00:00 am";
            this.lastTimeUpdateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveJobButton
            // 
            this.saveJobButton.Location = new System.Drawing.Point(589, 337);
            this.saveJobButton.Name = "saveJobButton";
            this.saveJobButton.Size = new System.Drawing.Size(146, 26);
            this.saveJobButton.TabIndex = 1;
            this.saveJobButton.Text = "Save and Close Job";
            this.saveJobButton.UseVisualStyleBackColor = true;
            this.saveJobButton.Click += new System.EventHandler(this.saveJobButton_Click);
            // 
            // jobEstimateTextBox
            // 
            this.jobEstimateTextBox.Location = new System.Drawing.Point(536, 45);
            this.jobEstimateTextBox.Name = "jobEstimateTextBox";
            this.jobEstimateTextBox.Size = new System.Drawing.Size(160, 22);
            this.jobEstimateTextBox.TabIndex = 45;
            // 
            // jobCostEstimateLabel
            // 
            this.jobCostEstimateLabel.AutoSize = true;
            this.jobCostEstimateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobCostEstimateLabel.Location = new System.Drawing.Point(533, 20);
            this.jobCostEstimateLabel.Name = "jobCostEstimateLabel";
            this.jobCostEstimateLabel.Size = new System.Drawing.Size(135, 18);
            this.jobCostEstimateLabel.TabIndex = 44;
            this.jobCostEstimateLabel.Text = "Job Cost Estimate:";
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLabel.Location = new System.Drawing.Point(6, 107);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(111, 18);
            this.employeeLabel.TabIndex = 42;
            this.employeeLabel.Text = "Job Employees";
            // 
            // jobEmployeesPanel
            // 
            this.jobEmployeesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jobEmployeesPanel.Controls.Add(this.newEmployeeTextBox);
            this.jobEmployeesPanel.Controls.Add(this.deleteEmployeeBtn);
            this.jobEmployeesPanel.Controls.Add(this.addEmployeeBtn);
            this.jobEmployeesPanel.Controls.Add(this.employeeListBox);
            this.jobEmployeesPanel.Location = new System.Drawing.Point(9, 133);
            this.jobEmployeesPanel.Name = "jobEmployeesPanel";
            this.jobEmployeesPanel.Size = new System.Drawing.Size(258, 198);
            this.jobEmployeesPanel.TabIndex = 41;
            // 
            // newEmployeeTextBox
            // 
            this.newEmployeeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmployeeTextBox.Location = new System.Drawing.Point(8, 12);
            this.newEmployeeTextBox.Name = "newEmployeeTextBox";
            this.newEmployeeTextBox.Size = new System.Drawing.Size(125, 27);
            this.newEmployeeTextBox.TabIndex = 3;
            // 
            // deleteEmployeeBtn
            // 
            this.deleteEmployeeBtn.Location = new System.Drawing.Point(123, 160);
            this.deleteEmployeeBtn.Name = "deleteEmployeeBtn";
            this.deleteEmployeeBtn.Size = new System.Drawing.Size(124, 30);
            this.deleteEmployeeBtn.TabIndex = 2;
            this.deleteEmployeeBtn.Text = "Delete Employee";
            this.deleteEmployeeBtn.UseVisualStyleBackColor = true;
            this.deleteEmployeeBtn.Click += new System.EventHandler(this.deleteEmployeeBtn_Click);
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.Location = new System.Drawing.Point(137, 12);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(110, 30);
            this.addEmployeeBtn.TabIndex = 1;
            this.addEmployeeBtn.Text = "Add Employee";
            this.addEmployeeBtn.UseVisualStyleBackColor = true;
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // employeeListBox
            // 
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.ItemHeight = 16;
            this.employeeListBox.Location = new System.Drawing.Point(8, 54);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(239, 100);
            this.employeeListBox.TabIndex = 0;
            // 
            // jobStatusPanel
            // 
            this.jobStatusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jobStatusPanel.Controls.Add(this.delayedJobStatRadioButton);
            this.jobStatusPanel.Controls.Add(this.inProgressJobStatRadioButton);
            this.jobStatusPanel.Controls.Add(this.completJobStatRadioButton);
            this.jobStatusPanel.Controls.Add(this.jobStatusLabel);
            this.jobStatusPanel.Location = new System.Drawing.Point(282, 133);
            this.jobStatusPanel.Name = "jobStatusPanel";
            this.jobStatusPanel.Size = new System.Drawing.Size(229, 88);
            this.jobStatusPanel.TabIndex = 40;
            // 
            // delayedJobStatRadioButton
            // 
            this.delayedJobStatRadioButton.AutoSize = true;
            this.delayedJobStatRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delayedJobStatRadioButton.Location = new System.Drawing.Point(109, 49);
            this.delayedJobStatRadioButton.Name = "delayedJobStatRadioButton";
            this.delayedJobStatRadioButton.Size = new System.Drawing.Size(82, 22);
            this.delayedJobStatRadioButton.TabIndex = 8;
            this.delayedJobStatRadioButton.TabStop = true;
            this.delayedJobStatRadioButton.Text = "Delayed";
            this.delayedJobStatRadioButton.UseVisualStyleBackColor = true;
            // 
            // inProgressJobStatRadioButton
            // 
            this.inProgressJobStatRadioButton.AutoSize = true;
            this.inProgressJobStatRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inProgressJobStatRadioButton.Location = new System.Drawing.Point(108, 14);
            this.inProgressJobStatRadioButton.Name = "inProgressJobStatRadioButton";
            this.inProgressJobStatRadioButton.Size = new System.Drawing.Size(105, 22);
            this.inProgressJobStatRadioButton.TabIndex = 7;
            this.inProgressJobStatRadioButton.TabStop = true;
            this.inProgressJobStatRadioButton.Text = "In Progress";
            this.inProgressJobStatRadioButton.UseVisualStyleBackColor = true;
            // 
            // completJobStatRadioButton
            // 
            this.completJobStatRadioButton.AutoSize = true;
            this.completJobStatRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completJobStatRadioButton.Location = new System.Drawing.Point(5, 48);
            this.completJobStatRadioButton.Name = "completJobStatRadioButton";
            this.completJobStatRadioButton.Size = new System.Drawing.Size(93, 22);
            this.completJobStatRadioButton.TabIndex = 6;
            this.completJobStatRadioButton.TabStop = true;
            this.completJobStatRadioButton.Text = "Complete";
            this.completJobStatRadioButton.UseVisualStyleBackColor = true;
            // 
            // jobStatusLabel
            // 
            this.jobStatusLabel.AutoSize = true;
            this.jobStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobStatusLabel.Location = new System.Drawing.Point(1, 13);
            this.jobStatusLabel.Name = "jobStatusLabel";
            this.jobStatusLabel.Size = new System.Drawing.Size(94, 20);
            this.jobStatusLabel.TabIndex = 5;
            this.jobStatusLabel.Text = "Job Status:";
            // 
            // jobCodeLabel
            // 
            this.jobCodeLabel.AutoSize = true;
            this.jobCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobCodeLabel.Location = new System.Drawing.Point(301, 20);
            this.jobCodeLabel.Name = "jobCodeLabel";
            this.jobCodeLabel.Size = new System.Drawing.Size(77, 18);
            this.jobCodeLabel.TabIndex = 39;
            this.jobCodeLabel.Text = "Job Code:";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesLabel.Location = new System.Drawing.Point(522, 115);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(52, 18);
            this.notesLabel.TabIndex = 38;
            this.notesLabel.Text = "Notes:";
            // 
            // jobNotesTextBox
            // 
            this.jobNotesTextBox.Location = new System.Drawing.Point(525, 136);
            this.jobNotesTextBox.Multiline = true;
            this.jobNotesTextBox.Name = "jobNotesTextBox";
            this.jobNotesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jobNotesTextBox.Size = new System.Drawing.Size(210, 178);
            this.jobNotesTextBox.TabIndex = 37;
            // 
            // JobUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.jobNumberLabel);
            this.Controls.Add(this.jobNumberLabelText);
            this.Controls.Add(this.jobNameLabel);
            this.Controls.Add(this.jobNameLabelText);
            this.Controls.Add(this.jobControlPanel);
            this.Name = "JobUserControl";
            this.Size = new System.Drawing.Size(757, 444);
            this.jobControlPanel.ResumeLayout(false);
            this.jobControlPanel.PerformLayout();
            this.jobEmployeesPanel.ResumeLayout(false);
            this.jobEmployeesPanel.PerformLayout();
            this.jobStatusPanel.ResumeLayout(false);
            this.jobStatusPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label jobNumberLabel;
        private System.Windows.Forms.Label jobNumberLabelText;
        private System.Windows.Forms.Label jobNameLabel;
        private System.Windows.Forms.Label jobNameLabelText;
        private System.Windows.Forms.Panel jobControlPanel;
        private System.Windows.Forms.ComboBox jobCodesComboBox;
        private System.Windows.Forms.Label jobStatusErrorLabel;
        private System.Windows.Forms.Label jobCodeErrorLabel;
        private System.Windows.Forms.Label jobEndDateErrorLabel;
        private System.Windows.Forms.Label jobEstimateErrorLabel;
        private System.Windows.Forms.DateTimePicker jobEndDateTimePicker;
        private System.Windows.Forms.DateTimePicker jobStartDateTimePicker;
        private System.Windows.Forms.Label jobEndDateLabel;
        private System.Windows.Forms.Label jobStartDateLabel;
        private System.Windows.Forms.Label lastTimeUpdateLabel;
        private System.Windows.Forms.Button saveJobButton;
        private System.Windows.Forms.TextBox jobEstimateTextBox;
        private System.Windows.Forms.Label jobCostEstimateLabel;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Panel jobEmployeesPanel;
        private System.Windows.Forms.TextBox newEmployeeTextBox;
        private System.Windows.Forms.Button deleteEmployeeBtn;
        private System.Windows.Forms.Button addEmployeeBtn;
        private System.Windows.Forms.ListBox employeeListBox;
        private System.Windows.Forms.Panel jobStatusPanel;
        private System.Windows.Forms.RadioButton delayedJobStatRadioButton;
        private System.Windows.Forms.RadioButton inProgressJobStatRadioButton;
        private System.Windows.Forms.RadioButton completJobStatRadioButton;
        private System.Windows.Forms.Label jobStatusLabel;
        private System.Windows.Forms.Label jobCodeLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox jobNotesTextBox;
        private System.Windows.Forms.Button deleteJobBtn;
    }
}
