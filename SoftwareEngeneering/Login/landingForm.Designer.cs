namespace Login
{
    partial class landingForm
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelStaffID = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.centralStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShiftStart = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStaffID
            // 
            this.labelStaffID.AutoSize = true;
            this.labelStaffID.Location = new System.Drawing.Point(24, 57);
            this.labelStaffID.Name = "labelStaffID";
            this.labelStaffID.Size = new System.Drawing.Size(43, 13);
            this.labelStaffID.TabIndex = 0;
            this.labelStaffID.Text = "StaffID:";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(24, 89);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(32, 13);
            this.labelRole.TabIndex = 1;
            this.labelRole.Text = "Role:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(24, 125);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centralStationToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // centralStationToolStripMenuItem
            // 
            this.centralStationToolStripMenuItem.Name = "centralStationToolStripMenuItem";
            this.centralStationToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.centralStationToolStripMenuItem.Text = "Central Station";
            this.centralStationToolStripMenuItem.Click += new System.EventHandler(this.centralStationToolStripMenuItem_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.managementToolStripMenuItem.Text = "Management";
            this.managementToolStripMenuItem.Click += new System.EventHandler(this.managementToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.logOutToolStripMenuItem.Text = "Log Off";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ShiftStart
            // 
            this.ShiftStart.AutoSize = true;
            this.ShiftStart.Location = new System.Drawing.Point(24, 161);
            this.ShiftStart.Name = "ShiftStart";
            this.ShiftStart.Size = new System.Drawing.Size(58, 13);
            this.ShiftStart.TabIndex = 7;
            this.ShiftStart.Text = "Start Time:";
            // 
            // landingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(505, 273);
            this.Controls.Add(this.ShiftStart);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelStaffID);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "landingForm";
            this.Text = "Main Menu";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStaffID;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem centralStationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label ShiftStart;
    }
}