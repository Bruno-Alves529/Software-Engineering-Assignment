namespace MenuBar
{
    partial class Form1
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
            this.patientMonitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.johnSmithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smithJohnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.andySmtihToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientMonitoringToolStripMenuItem
            // 
            this.patientMonitoringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectPatientToolStripMenuItem});
            this.patientMonitoringToolStripMenuItem.Name = "patientMonitoringToolStripMenuItem";
            this.patientMonitoringToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.patientMonitoringToolStripMenuItem.Text = "Patient Monitoring";
            // 
            // centralStationToolStripMenuItem
            // 
            this.centralStationToolStripMenuItem.Name = "centralStationToolStripMenuItem";
            this.centralStationToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.centralStationToolStripMenuItem.Text = "Central Station";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientMonitoringToolStripMenuItem,
            this.centralStationToolStripMenuItem,
            this.managementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectPatientToolStripMenuItem
            // 
            this.selectPatientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.johnSmithToolStripMenuItem,
            this.smithJohnToolStripMenuItem,
            this.andySmtihToolStripMenuItem});
            this.selectPatientToolStripMenuItem.Name = "selectPatientToolStripMenuItem";
            this.selectPatientToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.selectPatientToolStripMenuItem.Text = "Select Patient";
            // 
            // johnSmithToolStripMenuItem
            // 
            this.johnSmithToolStripMenuItem.Name = "johnSmithToolStripMenuItem";
            this.johnSmithToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.johnSmithToolStripMenuItem.Text = "John Smith";
            // 
            // smithJohnToolStripMenuItem
            // 
            this.smithJohnToolStripMenuItem.Name = "smithJohnToolStripMenuItem";
            this.smithJohnToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.smithJohnToolStripMenuItem.Text = "Smith John";
            // 
            // andySmtihToolStripMenuItem
            // 
            this.andySmtihToolStripMenuItem.Name = "andySmtihToolStripMenuItem";
            this.andySmtihToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.andySmtihToolStripMenuItem.Text = "Andy Smtih";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.Text = "Patient Monitoring System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem patientMonitoringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centralStationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem johnSmithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smithJohnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem andySmtihToolStripMenuItem;
    }
}

