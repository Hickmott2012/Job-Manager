namespace JobManager
{
    partial class userScreenFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userScreenFrm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userNameTextLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userControlPanel = new System.Windows.Forms.Panel();
            this.editSelectedfUserJobBtn = new System.Windows.Forms.Button();
            this.newJobCodePanel = new System.Windows.Forms.Panel();
            this.newJobCodeErrorLabel = new System.Windows.Forms.Label();
            this.newJobCodeTextBox = new System.Windows.Forms.TextBox();
            this.newJobCodeLabel = new System.Windows.Forms.Label();
            this.createJobCodeBtn = new System.Windows.Forms.Button();
            this.deleteJobCodeBtn = new System.Windows.Forms.Button();
            this.jobCodesListBox = new System.Windows.Forms.ListBox();
            this.jobCodesLabel = new System.Windows.Forms.Label();
            this.newUserPanel = new System.Windows.Forms.Panel();
            this.newUserErrorLabel = new System.Windows.Forms.Label();
            this.newUserPassowrdTextBox = new System.Windows.Forms.TextBox();
            this.newUserNameTextBox = new System.Windows.Forms.TextBox();
            this.newUserPassword = new System.Windows.Forms.Label();
            this.newUserNameLable = new System.Windows.Forms.Label();
            this.newUserBtn2 = new System.Windows.Forms.Button();
            this.newJobPanel = new System.Windows.Forms.Panel();
            this.errorNumExistLabel = new System.Windows.Forms.Label();
            this.newJobErrorLabel = new System.Windows.Forms.Label();
            this.newJobNumberTextBox = new System.Windows.Forms.TextBox();
            this.newJobNameTextBox = new System.Windows.Forms.TextBox();
            this.newJobNumberLable = new System.Windows.Forms.Label();
            this.selectedUserNewJobLable = new System.Windows.Forms.Label();
            this.newJobBtn2 = new System.Windows.Forms.Button();
            this.deleteSelectedUserJobBtn = new System.Windows.Forms.Button();
            this.selectedUsersJobListBox = new System.Windows.Forms.ListBox();
            this.selectedUsersJobsTextLabel = new System.Windows.Forms.Label();
            this.deleteUserBtn2 = new System.Windows.Forms.Button();
            this.userNameTextLabel2 = new System.Windows.Forms.Label();
            this.userNamesListBox = new System.Windows.Forms.ListBox();
            this.menuStrip.SuspendLayout();
            this.userControlPanel.SuspendLayout();
            this.newJobCodePanel.SuspendLayout();
            this.newUserPanel.SuspendLayout();
            this.newJobPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(772, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // userNameTextLabel
            // 
            this.userNameTextLabel.AutoSize = true;
            this.userNameTextLabel.BackColor = System.Drawing.Color.White;
            this.userNameTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextLabel.Location = new System.Drawing.Point(533, 5);
            this.userNameTextLabel.Name = "userNameTextLabel";
            this.userNameTextLabel.Size = new System.Drawing.Size(99, 20);
            this.userNameTextLabel.TabIndex = 9;
            this.userNameTextLabel.Text = "User Name:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.White;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(638, 5);
            this.userNameLabel.MaximumSize = new System.Drawing.Size(126, 20);
            this.userNameLabel.MinimumSize = new System.Drawing.Size(126, 20);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(126, 20);
            this.userNameLabel.TabIndex = 8;
            this.userNameLabel.Text = "User Name Here";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userControlPanel
            // 
            this.userControlPanel.Controls.Add(this.editSelectedfUserJobBtn);
            this.userControlPanel.Controls.Add(this.newJobCodePanel);
            this.userControlPanel.Controls.Add(this.deleteJobCodeBtn);
            this.userControlPanel.Controls.Add(this.jobCodesListBox);
            this.userControlPanel.Controls.Add(this.jobCodesLabel);
            this.userControlPanel.Controls.Add(this.newUserPanel);
            this.userControlPanel.Controls.Add(this.newJobPanel);
            this.userControlPanel.Controls.Add(this.deleteSelectedUserJobBtn);
            this.userControlPanel.Controls.Add(this.selectedUsersJobListBox);
            this.userControlPanel.Controls.Add(this.selectedUsersJobsTextLabel);
            this.userControlPanel.Controls.Add(this.deleteUserBtn2);
            this.userControlPanel.Controls.Add(this.userNameTextLabel2);
            this.userControlPanel.Controls.Add(this.userNamesListBox);
            this.userControlPanel.Location = new System.Drawing.Point(8, 40);
            this.userControlPanel.Name = "userControlPanel";
            this.userControlPanel.Size = new System.Drawing.Size(756, 442);
            this.userControlPanel.TabIndex = 45;
            // 
            // editSelectedfUserJobBtn
            // 
            this.editSelectedfUserJobBtn.Location = new System.Drawing.Point(270, 399);
            this.editSelectedfUserJobBtn.Name = "editSelectedfUserJobBtn";
            this.editSelectedfUserJobBtn.Size = new System.Drawing.Size(105, 26);
            this.editSelectedfUserJobBtn.TabIndex = 82;
            this.editSelectedfUserJobBtn.Text = "Edit Job";
            this.editSelectedfUserJobBtn.UseVisualStyleBackColor = true;
            this.editSelectedfUserJobBtn.Visible = false;
            this.editSelectedfUserJobBtn.Click += new System.EventHandler(this.editSelectedfUserJobBtn_Click);
            // 
            // newJobCodePanel
            // 
            this.newJobCodePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newJobCodePanel.Controls.Add(this.newJobCodeErrorLabel);
            this.newJobCodePanel.Controls.Add(this.newJobCodeTextBox);
            this.newJobCodePanel.Controls.Add(this.newJobCodeLabel);
            this.newJobCodePanel.Controls.Add(this.createJobCodeBtn);
            this.newJobCodePanel.Location = new System.Drawing.Point(519, 17);
            this.newJobCodePanel.Name = "newJobCodePanel";
            this.newJobCodePanel.Size = new System.Drawing.Size(217, 109);
            this.newJobCodePanel.TabIndex = 81;
            // 
            // newJobCodeErrorLabel
            // 
            this.newJobCodeErrorLabel.AutoSize = true;
            this.newJobCodeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.newJobCodeErrorLabel.Location = new System.Drawing.Point(48, 55);
            this.newJobCodeErrorLabel.Name = "newJobCodeErrorLabel";
            this.newJobCodeErrorLabel.Size = new System.Drawing.Size(118, 17);
            this.newJobCodeErrorLabel.TabIndex = 57;
            this.newJobCodeErrorLabel.Text = "Enter a Job Code";
            this.newJobCodeErrorLabel.Visible = false;
            // 
            // newJobCodeTextBox
            // 
            this.newJobCodeTextBox.Location = new System.Drawing.Point(13, 28);
            this.newJobCodeTextBox.Name = "newJobCodeTextBox";
            this.newJobCodeTextBox.Size = new System.Drawing.Size(190, 22);
            this.newJobCodeTextBox.TabIndex = 54;
            // 
            // newJobCodeLabel
            // 
            this.newJobCodeLabel.AutoSize = true;
            this.newJobCodeLabel.Location = new System.Drawing.Point(10, 5);
            this.newJobCodeLabel.Name = "newJobCodeLabel";
            this.newJobCodeLabel.Size = new System.Drawing.Size(103, 17);
            this.newJobCodeLabel.TabIndex = 52;
            this.newJobCodeLabel.Text = "New Job Code:";
            // 
            // createJobCodeBtn
            // 
            this.createJobCodeBtn.Location = new System.Drawing.Point(42, 76);
            this.createJobCodeBtn.Name = "createJobCodeBtn";
            this.createJobCodeBtn.Size = new System.Drawing.Size(131, 26);
            this.createJobCodeBtn.TabIndex = 51;
            this.createJobCodeBtn.Text = "Create Job Code";
            this.createJobCodeBtn.UseVisualStyleBackColor = true;
            this.createJobCodeBtn.Click += new System.EventHandler(this.createJobCodeBtn_Click);
            // 
            // deleteJobCodeBtn
            // 
            this.deleteJobCodeBtn.Location = new System.Drawing.Point(566, 399);
            this.deleteJobCodeBtn.Name = "deleteJobCodeBtn";
            this.deleteJobCodeBtn.Size = new System.Drawing.Size(122, 26);
            this.deleteJobCodeBtn.TabIndex = 79;
            this.deleteJobCodeBtn.Text = "Delete Job Code";
            this.deleteJobCodeBtn.UseVisualStyleBackColor = true;
            this.deleteJobCodeBtn.Visible = false;
            this.deleteJobCodeBtn.Click += new System.EventHandler(this.deleteJobCodeBtn_Click);
            // 
            // jobCodesListBox
            // 
            this.jobCodesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobCodesListBox.FormattingEnabled = true;
            this.jobCodesListBox.ItemHeight = 20;
            this.jobCodesListBox.Location = new System.Drawing.Point(519, 226);
            this.jobCodesListBox.Name = "jobCodesListBox";
            this.jobCodesListBox.ScrollAlwaysVisible = true;
            this.jobCodesListBox.Size = new System.Drawing.Size(217, 164);
            this.jobCodesListBox.TabIndex = 80;
            this.jobCodesListBox.SelectedIndexChanged += new System.EventHandler(this.jobCodesListBox_SelectedIndexChanged);
            // 
            // jobCodesLabel
            // 
            this.jobCodesLabel.AutoSize = true;
            this.jobCodesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobCodesLabel.Location = new System.Drawing.Point(516, 194);
            this.jobCodesLabel.Name = "jobCodesLabel";
            this.jobCodesLabel.Size = new System.Drawing.Size(85, 18);
            this.jobCodesLabel.TabIndex = 78;
            this.jobCodesLabel.Text = "Job Codes:";
            // 
            // newUserPanel
            // 
            this.newUserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newUserPanel.Controls.Add(this.newUserErrorLabel);
            this.newUserPanel.Controls.Add(this.newUserPassowrdTextBox);
            this.newUserPanel.Controls.Add(this.newUserNameTextBox);
            this.newUserPanel.Controls.Add(this.newUserPassword);
            this.newUserPanel.Controls.Add(this.newUserNameLable);
            this.newUserPanel.Controls.Add(this.newUserBtn2);
            this.newUserPanel.Location = new System.Drawing.Point(23, 17);
            this.newUserPanel.Name = "newUserPanel";
            this.newUserPanel.Size = new System.Drawing.Size(217, 163);
            this.newUserPanel.TabIndex = 77;
            // 
            // newUserErrorLabel
            // 
            this.newUserErrorLabel.AutoSize = true;
            this.newUserErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.newUserErrorLabel.Location = new System.Drawing.Point(3, 108);
            this.newUserErrorLabel.Name = "newUserErrorLabel";
            this.newUserErrorLabel.Size = new System.Drawing.Size(189, 15);
            this.newUserErrorLabel.TabIndex = 47;
            this.newUserErrorLabel.Text = "Chose User Name and Password";
            this.newUserErrorLabel.Visible = false;
            // 
            // newUserPassowrdTextBox
            // 
            this.newUserPassowrdTextBox.Location = new System.Drawing.Point(13, 80);
            this.newUserPassowrdTextBox.Name = "newUserPassowrdTextBox";
            this.newUserPassowrdTextBox.Size = new System.Drawing.Size(190, 22);
            this.newUserPassowrdTextBox.TabIndex = 46;
            // 
            // newUserNameTextBox
            // 
            this.newUserNameTextBox.Location = new System.Drawing.Point(13, 29);
            this.newUserNameTextBox.Name = "newUserNameTextBox";
            this.newUserNameTextBox.Size = new System.Drawing.Size(190, 22);
            this.newUserNameTextBox.TabIndex = 45;
            // 
            // newUserPassword
            // 
            this.newUserPassword.AutoSize = true;
            this.newUserPassword.Location = new System.Drawing.Point(10, 57);
            this.newUserPassword.Name = "newUserPassword";
            this.newUserPassword.Size = new System.Drawing.Size(138, 17);
            this.newUserPassword.TabIndex = 44;
            this.newUserPassword.Text = "New User Password:";
            // 
            // newUserNameLable
            // 
            this.newUserNameLable.AutoSize = true;
            this.newUserNameLable.Location = new System.Drawing.Point(10, 6);
            this.newUserNameLable.Name = "newUserNameLable";
            this.newUserNameLable.Size = new System.Drawing.Size(142, 17);
            this.newUserNameLable.TabIndex = 43;
            this.newUserNameLable.Text = "New User Username:";
            // 
            // newUserBtn2
            // 
            this.newUserBtn2.Location = new System.Drawing.Point(42, 130);
            this.newUserBtn2.Name = "newUserBtn2";
            this.newUserBtn2.Size = new System.Drawing.Size(131, 26);
            this.newUserBtn2.TabIndex = 42;
            this.newUserBtn2.Text = "Create New User";
            this.newUserBtn2.UseVisualStyleBackColor = true;
            this.newUserBtn2.Click += new System.EventHandler(this.newUserBtn2_Click);
            // 
            // newJobPanel
            // 
            this.newJobPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newJobPanel.Controls.Add(this.errorNumExistLabel);
            this.newJobPanel.Controls.Add(this.newJobErrorLabel);
            this.newJobPanel.Controls.Add(this.newJobNumberTextBox);
            this.newJobPanel.Controls.Add(this.newJobNameTextBox);
            this.newJobPanel.Controls.Add(this.newJobNumberLable);
            this.newJobPanel.Controls.Add(this.selectedUserNewJobLable);
            this.newJobPanel.Controls.Add(this.newJobBtn2);
            this.newJobPanel.Location = new System.Drawing.Point(270, 17);
            this.newJobPanel.Name = "newJobPanel";
            this.newJobPanel.Size = new System.Drawing.Size(217, 163);
            this.newJobPanel.TabIndex = 76;
            this.newJobPanel.Visible = false;
            // 
            // errorNumExistLabel
            // 
            this.errorNumExistLabel.AutoSize = true;
            this.errorNumExistLabel.ForeColor = System.Drawing.Color.Red;
            this.errorNumExistLabel.Location = new System.Drawing.Point(126, 55);
            this.errorNumExistLabel.Name = "errorNumExistLabel";
            this.errorNumExistLabel.Size = new System.Drawing.Size(91, 17);
            this.errorNumExistLabel.TabIndex = 60;
            this.errorNumExistLabel.Text = "Number Exist";
            this.errorNumExistLabel.Visible = false;
            // 
            // newJobErrorLabel
            // 
            this.newJobErrorLabel.AutoSize = true;
            this.newJobErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.newJobErrorLabel.Location = new System.Drawing.Point(5, 107);
            this.newJobErrorLabel.Name = "newJobErrorLabel";
            this.newJobErrorLabel.Size = new System.Drawing.Size(204, 17);
            this.newJobErrorLabel.TabIndex = 56;
            this.newJobErrorLabel.Text = "Enter a Job Name and Number";
            this.newJobErrorLabel.Visible = false;
            // 
            // newJobNumberTextBox
            // 
            this.newJobNumberTextBox.Location = new System.Drawing.Point(13, 78);
            this.newJobNumberTextBox.Name = "newJobNumberTextBox";
            this.newJobNumberTextBox.Size = new System.Drawing.Size(190, 22);
            this.newJobNumberTextBox.TabIndex = 55;
            // 
            // newJobNameTextBox
            // 
            this.newJobNameTextBox.Location = new System.Drawing.Point(13, 27);
            this.newJobNameTextBox.Name = "newJobNameTextBox";
            this.newJobNameTextBox.Size = new System.Drawing.Size(190, 22);
            this.newJobNameTextBox.TabIndex = 54;
            // 
            // newJobNumberLable
            // 
            this.newJobNumberLable.AutoSize = true;
            this.newJobNumberLable.Location = new System.Drawing.Point(7, 55);
            this.newJobNumberLable.Name = "newJobNumberLable";
            this.newJobNumberLable.Size = new System.Drawing.Size(120, 17);
            this.newJobNumberLable.TabIndex = 53;
            this.newJobNumberLable.Text = "New Job Number:";
            // 
            // selectedUserNewJobLable
            // 
            this.selectedUserNewJobLable.AutoSize = true;
            this.selectedUserNewJobLable.Location = new System.Drawing.Point(10, 4);
            this.selectedUserNewJobLable.Name = "selectedUserNewJobLable";
            this.selectedUserNewJobLable.Size = new System.Drawing.Size(107, 17);
            this.selectedUserNewJobLable.TabIndex = 52;
            this.selectedUserNewJobLable.Text = "New Job Name:";
            // 
            // newJobBtn2
            // 
            this.newJobBtn2.Location = new System.Drawing.Point(42, 130);
            this.newJobBtn2.Name = "newJobBtn2";
            this.newJobBtn2.Size = new System.Drawing.Size(131, 26);
            this.newJobBtn2.TabIndex = 51;
            this.newJobBtn2.Text = "Create New Job";
            this.newJobBtn2.UseVisualStyleBackColor = true;
            this.newJobBtn2.Click += new System.EventHandler(this.newJobBtn2_Click);
            // 
            // deleteSelectedUserJobBtn
            // 
            this.deleteSelectedUserJobBtn.Location = new System.Drawing.Point(382, 399);
            this.deleteSelectedUserJobBtn.Name = "deleteSelectedUserJobBtn";
            this.deleteSelectedUserJobBtn.Size = new System.Drawing.Size(105, 26);
            this.deleteSelectedUserJobBtn.TabIndex = 74;
            this.deleteSelectedUserJobBtn.Text = "Delete Job";
            this.deleteSelectedUserJobBtn.UseVisualStyleBackColor = true;
            this.deleteSelectedUserJobBtn.Visible = false;
            this.deleteSelectedUserJobBtn.Click += new System.EventHandler(this.deleteSelectedUserJobBtn_Click);
            // 
            // selectedUsersJobListBox
            // 
            this.selectedUsersJobListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedUsersJobListBox.FormattingEnabled = true;
            this.selectedUsersJobListBox.ItemHeight = 20;
            this.selectedUsersJobListBox.Location = new System.Drawing.Point(270, 226);
            this.selectedUsersJobListBox.Name = "selectedUsersJobListBox";
            this.selectedUsersJobListBox.ScrollAlwaysVisible = true;
            this.selectedUsersJobListBox.Size = new System.Drawing.Size(217, 164);
            this.selectedUsersJobListBox.TabIndex = 75;
            this.selectedUsersJobListBox.Visible = false;
            this.selectedUsersJobListBox.SelectedIndexChanged += new System.EventHandler(this.selectedUsersJobListBox_SelectedIndexChanged);
            // 
            // selectedUsersJobsTextLabel
            // 
            this.selectedUsersJobsTextLabel.AutoSize = true;
            this.selectedUsersJobsTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedUsersJobsTextLabel.Location = new System.Drawing.Point(267, 194);
            this.selectedUsersJobsTextLabel.Name = "selectedUsersJobsTextLabel";
            this.selectedUsersJobsTextLabel.Size = new System.Drawing.Size(153, 18);
            this.selectedUsersJobsTextLabel.TabIndex = 73;
            this.selectedUsersJobsTextLabel.Text = "Selected Users Job\'s:";
            this.selectedUsersJobsTextLabel.Visible = false;
            // 
            // deleteUserBtn2
            // 
            this.deleteUserBtn2.Location = new System.Drawing.Point(70, 399);
            this.deleteUserBtn2.Name = "deleteUserBtn2";
            this.deleteUserBtn2.Size = new System.Drawing.Size(122, 26);
            this.deleteUserBtn2.TabIndex = 71;
            this.deleteUserBtn2.Text = "Delete User";
            this.deleteUserBtn2.UseVisualStyleBackColor = true;
            this.deleteUserBtn2.Visible = false;
            this.deleteUserBtn2.Click += new System.EventHandler(this.deleteUserBtn2_Click);
            // 
            // userNameTextLabel2
            // 
            this.userNameTextLabel2.AutoSize = true;
            this.userNameTextLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextLabel2.Location = new System.Drawing.Point(20, 194);
            this.userNameTextLabel2.Name = "userNameTextLabel2";
            this.userNameTextLabel2.Size = new System.Drawing.Size(99, 18);
            this.userNameTextLabel2.TabIndex = 70;
            this.userNameTextLabel2.Text = "User Name\'s:";
            // 
            // userNamesListBox
            // 
            this.userNamesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNamesListBox.FormattingEnabled = true;
            this.userNamesListBox.ItemHeight = 20;
            this.userNamesListBox.Location = new System.Drawing.Point(23, 226);
            this.userNamesListBox.Name = "userNamesListBox";
            this.userNamesListBox.ScrollAlwaysVisible = true;
            this.userNamesListBox.Size = new System.Drawing.Size(217, 164);
            this.userNamesListBox.TabIndex = 72;
            this.userNamesListBox.SelectedIndexChanged += new System.EventHandler(this.userNamesListBox_SelectedIndexChanged);
            // 
            // userScreenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 487);
            this.Controls.Add(this.userControlPanel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userNameTextLabel);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "userScreenFrm";
            this.Text = "User Account Screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.userScreen_FormClosed);
            this.Load += new System.EventHandler(this.userScreen_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.userControlPanel.ResumeLayout(false);
            this.userControlPanel.PerformLayout();
            this.newJobCodePanel.ResumeLayout(false);
            this.newJobCodePanel.PerformLayout();
            this.newUserPanel.ResumeLayout(false);
            this.newUserPanel.PerformLayout();
            this.newJobPanel.ResumeLayout(false);
            this.newJobPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label userNameTextLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Panel userControlPanel;
        private System.Windows.Forms.Button editSelectedfUserJobBtn;
        private System.Windows.Forms.Panel newJobCodePanel;
        private System.Windows.Forms.Label newJobCodeErrorLabel;
        private System.Windows.Forms.TextBox newJobCodeTextBox;
        private System.Windows.Forms.Label newJobCodeLabel;
        private System.Windows.Forms.Button createJobCodeBtn;
        private System.Windows.Forms.Button deleteJobCodeBtn;
        private System.Windows.Forms.ListBox jobCodesListBox;
        private System.Windows.Forms.Label jobCodesLabel;
        private System.Windows.Forms.Panel newUserPanel;
        private System.Windows.Forms.Label newUserErrorLabel;
        private System.Windows.Forms.TextBox newUserPassowrdTextBox;
        private System.Windows.Forms.TextBox newUserNameTextBox;
        private System.Windows.Forms.Label newUserPassword;
        private System.Windows.Forms.Label newUserNameLable;
        private System.Windows.Forms.Button newUserBtn2;
        private System.Windows.Forms.Panel newJobPanel;
        private System.Windows.Forms.Label newJobErrorLabel;
        private System.Windows.Forms.TextBox newJobNumberTextBox;
        private System.Windows.Forms.TextBox newJobNameTextBox;
        private System.Windows.Forms.Label newJobNumberLable;
        private System.Windows.Forms.Label selectedUserNewJobLable;
        private System.Windows.Forms.Button newJobBtn2;
        private System.Windows.Forms.Button deleteSelectedUserJobBtn;
        private System.Windows.Forms.ListBox selectedUsersJobListBox;
        private System.Windows.Forms.Label selectedUsersJobsTextLabel;
        private System.Windows.Forms.Button deleteUserBtn2;
        private System.Windows.Forms.Label userNameTextLabel2;
        private System.Windows.Forms.ListBox userNamesListBox;
        private System.Windows.Forms.Label errorNumExistLabel;
    }
}