namespace JobManager
{
    partial class JobControlScreenFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobControlScreenFrm));
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTextLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobTabControl = new System.Windows.Forms.TabControl();
            this.jobListTabPage1 = new System.Windows.Forms.TabPage();
            this.changeJobNameBtn = new System.Windows.Forms.Button();
            this.jobNumbersListBox = new System.Windows.Forms.ListBox();
            this.jobNamesListBox = new System.Windows.Forms.ListBox();
            this.openJobButton = new System.Windows.Forms.Button();
            this.deleteJobBtn = new System.Windows.Forms.Button();
            this.jobNameTextLabel = new System.Windows.Forms.Label();
            this.jobNumberLabel = new System.Windows.Forms.Label();
            this.newJobBtn = new System.Windows.Forms.Button();
            this.jobControlsPanel = new System.Windows.Forms.Panel();
            this.jobControlsLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.jobTabControl.SuspendLayout();
            this.jobListTabPage1.SuspendLayout();
            this.jobControlsPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.userNameLabel.TabIndex = 11;
            this.userNameLabel.Text = "User Name Here";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userNameTextLabel
            // 
            this.userNameTextLabel.AutoSize = true;
            this.userNameTextLabel.BackColor = System.Drawing.Color.White;
            this.userNameTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextLabel.Location = new System.Drawing.Point(533, 5);
            this.userNameTextLabel.Name = "userNameTextLabel";
            this.userNameTextLabel.Size = new System.Drawing.Size(99, 20);
            this.userNameTextLabel.TabIndex = 12;
            this.userNameTextLabel.Text = "User Name:";
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
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newJobToolStripMenuItem,
            this.deleteJobToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newJobToolStripMenuItem
            // 
            this.newJobToolStripMenuItem.Name = "newJobToolStripMenuItem";
            this.newJobToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.newJobToolStripMenuItem.Text = "New Job";
            this.newJobToolStripMenuItem.Click += new System.EventHandler(this.newJobToolStripMenuItem_Click);
            // 
            // deleteJobToolStripMenuItem
            // 
            this.deleteJobToolStripMenuItem.Name = "deleteJobToolStripMenuItem";
            this.deleteJobToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.deleteJobToolStripMenuItem.Text = "Delete Job";
            this.deleteJobToolStripMenuItem.Visible = false;
            this.deleteJobToolStripMenuItem.Click += new System.EventHandler(this.deleteJobButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
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
            // jobTabControl
            // 
            this.jobTabControl.Controls.Add(this.jobListTabPage1);
            this.jobTabControl.Location = new System.Drawing.Point(4, 36);
            this.jobTabControl.Name = "jobTabControl";
            this.jobTabControl.SelectedIndex = 0;
            this.jobTabControl.Size = new System.Drawing.Size(765, 473);
            this.jobTabControl.TabIndex = 46;
            this.jobTabControl.SelectedIndexChanged += new System.EventHandler(this.jobTabControl_SelectedIndexChanged);
            // 
            // jobListTabPage1
            // 
            this.jobListTabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.jobListTabPage1.Controls.Add(this.jobControlsLabel);
            this.jobListTabPage1.Controls.Add(this.jobControlsPanel);
            this.jobListTabPage1.Controls.Add(this.jobNumbersListBox);
            this.jobListTabPage1.Controls.Add(this.jobNamesListBox);
            this.jobListTabPage1.Controls.Add(this.jobNameTextLabel);
            this.jobListTabPage1.Controls.Add(this.jobNumberLabel);
            this.jobListTabPage1.Location = new System.Drawing.Point(4, 25);
            this.jobListTabPage1.Name = "jobListTabPage1";
            this.jobListTabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.jobListTabPage1.Size = new System.Drawing.Size(757, 444);
            this.jobListTabPage1.TabIndex = 0;
            this.jobListTabPage1.Text = "Job List";
            // 
            // changeJobNameBtn
            // 
            this.changeJobNameBtn.Location = new System.Drawing.Point(21, 159);
            this.changeJobNameBtn.Name = "changeJobNameBtn";
            this.changeJobNameBtn.Size = new System.Drawing.Size(149, 31);
            this.changeJobNameBtn.TabIndex = 66;
            this.changeJobNameBtn.Text = "Change Job Name";
            this.changeJobNameBtn.UseVisualStyleBackColor = true;
            this.changeJobNameBtn.Visible = false;
            this.changeJobNameBtn.Click += new System.EventHandler(this.changeJobNameBtn_Click);
            // 
            // jobNumbersListBox
            // 
            this.jobNumbersListBox.FormattingEnabled = true;
            this.jobNumbersListBox.ItemHeight = 16;
            this.jobNumbersListBox.Location = new System.Drawing.Point(506, 52);
            this.jobNumbersListBox.Name = "jobNumbersListBox";
            this.jobNumbersListBox.Size = new System.Drawing.Size(226, 372);
            this.jobNumbersListBox.TabIndex = 61;
            this.jobNumbersListBox.SelectedIndexChanged += new System.EventHandler(this.jobNumbersListBox_SelectedIndexChanged);
            // 
            // jobNamesListBox
            // 
            this.jobNamesListBox.FormattingEnabled = true;
            this.jobNamesListBox.ItemHeight = 16;
            this.jobNamesListBox.Location = new System.Drawing.Point(238, 52);
            this.jobNamesListBox.Name = "jobNamesListBox";
            this.jobNamesListBox.Size = new System.Drawing.Size(226, 372);
            this.jobNamesListBox.TabIndex = 60;
            this.jobNamesListBox.SelectedIndexChanged += new System.EventHandler(this.jobNamesListBox_SelectedIndexChanged);
            // 
            // openJobButton
            // 
            this.openJobButton.Location = new System.Drawing.Point(21, 63);
            this.openJobButton.Name = "openJobButton";
            this.openJobButton.Size = new System.Drawing.Size(149, 31);
            this.openJobButton.TabIndex = 59;
            this.openJobButton.Text = "Open Job";
            this.openJobButton.UseVisualStyleBackColor = true;
            this.openJobButton.Visible = false;
            this.openJobButton.Click += new System.EventHandler(this.openJobButton_Click);
            // 
            // deleteJobBtn
            // 
            this.deleteJobBtn.Location = new System.Drawing.Point(21, 111);
            this.deleteJobBtn.Name = "deleteJobBtn";
            this.deleteJobBtn.Size = new System.Drawing.Size(149, 31);
            this.deleteJobBtn.TabIndex = 57;
            this.deleteJobBtn.Text = "Delete Job";
            this.deleteJobBtn.UseVisualStyleBackColor = true;
            this.deleteJobBtn.Visible = false;
            this.deleteJobBtn.Click += new System.EventHandler(this.deleteJobButton_Click);
            // 
            // jobNameTextLabel
            // 
            this.jobNameTextLabel.AutoSize = true;
            this.jobNameTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobNameTextLabel.Location = new System.Drawing.Point(234, 20);
            this.jobNameTextLabel.Name = "jobNameTextLabel";
            this.jobNameTextLabel.Size = new System.Drawing.Size(99, 20);
            this.jobNameTextLabel.TabIndex = 53;
            this.jobNameTextLabel.Text = "Job Names:";
            // 
            // jobNumberLabel
            // 
            this.jobNumberLabel.AutoSize = true;
            this.jobNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobNumberLabel.Location = new System.Drawing.Point(502, 20);
            this.jobNumberLabel.Name = "jobNumberLabel";
            this.jobNumberLabel.Size = new System.Drawing.Size(55, 20);
            this.jobNumberLabel.TabIndex = 54;
            this.jobNumberLabel.Text = "Job #:";
            // 
            // newJobBtn
            // 
            this.newJobBtn.Location = new System.Drawing.Point(21, 15);
            this.newJobBtn.Name = "newJobBtn";
            this.newJobBtn.Size = new System.Drawing.Size(149, 31);
            this.newJobBtn.TabIndex = 52;
            this.newJobBtn.Text = "New Job";
            this.newJobBtn.UseVisualStyleBackColor = true;
            this.newJobBtn.Click += new System.EventHandler(this.newJobToolStripMenuItem_Click);
            // 
            // jobControlsPanel
            // 
            this.jobControlsPanel.Controls.Add(this.newJobBtn);
            this.jobControlsPanel.Controls.Add(this.changeJobNameBtn);
            this.jobControlsPanel.Controls.Add(this.deleteJobBtn);
            this.jobControlsPanel.Controls.Add(this.openJobButton);
            this.jobControlsPanel.Location = new System.Drawing.Point(6, 52);
            this.jobControlsPanel.Name = "jobControlsPanel";
            this.jobControlsPanel.Size = new System.Drawing.Size(190, 372);
            this.jobControlsPanel.TabIndex = 67;
            // 
            // jobControlsLabel
            // 
            this.jobControlsLabel.AutoSize = true;
            this.jobControlsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobControlsLabel.Location = new System.Drawing.Point(23, 20);
            this.jobControlsLabel.Name = "jobControlsLabel";
            this.jobControlsLabel.Size = new System.Drawing.Size(109, 20);
            this.jobControlsLabel.TabIndex = 68;
            this.jobControlsLabel.Text = "Job Controls:";
            // 
            // JobControlScreenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 511);
            this.Controls.Add(this.jobTabControl);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userNameTextLabel);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "JobControlScreenFrm";
            this.Text = "JobControlScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JobControlScreenFrm_FormClosed);
            this.Load += new System.EventHandler(this.JobControlScreenFrm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.jobTabControl.ResumeLayout(false);
            this.jobListTabPage1.ResumeLayout(false);
            this.jobListTabPage1.PerformLayout();
            this.jobControlsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userNameTextLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.TabControl jobTabControl;
        private System.Windows.Forms.TabPage jobListTabPage1;
        private System.Windows.Forms.Button openJobButton;
        private System.Windows.Forms.Button deleteJobBtn;
        private System.Windows.Forms.Label jobNameTextLabel;
        private System.Windows.Forms.Label jobNumberLabel;
        private System.Windows.Forms.Button newJobBtn;
        private System.Windows.Forms.ListBox jobNumbersListBox;
        private System.Windows.Forms.ListBox jobNamesListBox;
        private System.Windows.Forms.ToolStripMenuItem deleteJobToolStripMenuItem;
        private System.Windows.Forms.Button changeJobNameBtn;
        private System.Windows.Forms.Label jobControlsLabel;
        private System.Windows.Forms.Panel jobControlsPanel;
    }
}