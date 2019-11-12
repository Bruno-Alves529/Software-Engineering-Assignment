namespace EAHTManagement
{
    partial class DBManagementForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBManagementForm));
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButtonClearAll = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonCreateStaff = new System.Windows.Forms.Button();
            this._textBoxName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this._textBoxStaffPassword = new System.Windows.Forms.TextBox();
            this._dateTimePickerEmployDate = new System.Windows.Forms.DateTimePicker();
            this._dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this._ComboBoxGender = new System.Windows.Forms.ComboBox();
            this._comboBoxStaffRole = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._textBoxEmail = new System.Windows.Forms.TextBox();
            this._textBoxSurname = new System.Windows.Forms.TextBox();
            this._textBoxStaffID = new System.Windows.Forms.TextBox();
            this._textBoxPhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(1126, 251);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(75, 23);
            this.buttonShowAll.TabIndex = 66;
            this.buttonShowAll.Text = "Refresh";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1126, 728);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 63;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 16);
            this.label10.TabIndex = 62;
            this.label10.Text = "Logged In as: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1189, 212);
            this.dataGridView1.TabIndex = 57;
            // 
            // ButtonClearAll
            // 
            this.ButtonClearAll.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClearAll.Location = new System.Drawing.Point(71, 654);
            this.ButtonClearAll.Name = "ButtonClearAll";
            this.ButtonClearAll.Size = new System.Drawing.Size(117, 30);
            this.ButtonClearAll.TabIndex = 42;
            this.ButtonClearAll.Text = "Clear All";
            this.ButtonClearAll.UseVisualStyleBackColor = true;
            this.ButtonClearAll.Click += new System.EventHandler(this.ButtonClearAll_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(1087, 13);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(39, 16);
            this.labelTime.TabIndex = 55;
            this.labelTime.Text = "Time";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(812, 13);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(37, 16);
            this.labelDate.TabIndex = 54;
            this.labelDate.Text = "Date";
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(463, 267);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(163, 20);
            this.surnameText.TabIndex = 43;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(365, 267);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 44;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonCreateStaff
            // 
            this.buttonCreateStaff.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateStaff.Location = new System.Drawing.Point(194, 654);
            this.buttonCreateStaff.Name = "buttonCreateStaff";
            this.buttonCreateStaff.Size = new System.Drawing.Size(117, 30);
            this.buttonCreateStaff.TabIndex = 10;
            this.buttonCreateStaff.Text = "Create Staff";
            this.buttonCreateStaff.UseVisualStyleBackColor = true;
            this.buttonCreateStaff.Click += new System.EventHandler(this.buttonCreateStaff_Click);
            // 
            // _textBoxName
            // 
            this._textBoxName.Location = new System.Drawing.Point(171, 296);
            this._textBoxName.Name = "_textBoxName";
            this._textBoxName.Size = new System.Drawing.Size(140, 20);
            this._textBoxName.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 441);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 85;
            this.label11.Text = "Password:";
            // 
            // _textBoxStaffPassword
            // 
            this._textBoxStaffPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxStaffPassword.Location = new System.Drawing.Point(171, 437);
            this._textBoxStaffPassword.Name = "_textBoxStaffPassword";
            this._textBoxStaffPassword.Size = new System.Drawing.Size(140, 21);
            this._textBoxStaffPassword.TabIndex = 4;
            // 
            // _dateTimePickerEmployDate
            // 
            this._dateTimePickerEmployDate.CustomFormat = "dd/MM/yyyy";
            this._dateTimePickerEmployDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dateTimePickerEmployDate.Location = new System.Drawing.Point(171, 546);
            this._dateTimePickerEmployDate.MaxDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this._dateTimePickerEmployDate.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this._dateTimePickerEmployDate.Name = "_dateTimePickerEmployDate";
            this._dateTimePickerEmployDate.Size = new System.Drawing.Size(140, 21);
            this._dateTimePickerEmployDate.TabIndex = 7;
            // 
            // _dateTimePickerDOB
            // 
            this._dateTimePickerDOB.CustomFormat = "dd/MM/yyyy";
            this._dateTimePickerDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._dateTimePickerDOB.Location = new System.Drawing.Point(171, 510);
            this._dateTimePickerDOB.MaxDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this._dateTimePickerDOB.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this._dateTimePickerDOB.Name = "_dateTimePickerDOB";
            this._dateTimePickerDOB.Size = new System.Drawing.Size(140, 21);
            this._dateTimePickerDOB.TabIndex = 6;
            // 
            // _ComboBoxGender
            // 
            this._ComboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComboBoxGender.FormattingEnabled = true;
            this._ComboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this._ComboBoxGender.Location = new System.Drawing.Point(171, 371);
            this._ComboBoxGender.Name = "_ComboBoxGender";
            this._ComboBoxGender.Size = new System.Drawing.Size(140, 23);
            this._ComboBoxGender.TabIndex = 2;
            // 
            // _comboBoxStaffRole
            // 
            this._comboBoxStaffRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._comboBoxStaffRole.FormattingEnabled = true;
            this._comboBoxStaffRole.Items.AddRange(new object[] {
            "Medical Staff",
            "Consultant",
            "Management"});
            this._comboBoxStaffRole.Location = new System.Drawing.Point(171, 469);
            this._comboBoxStaffRole.Name = "_comboBoxStaffRole";
            this._comboBoxStaffRole.Size = new System.Drawing.Size(140, 23);
            this._comboBoxStaffRole.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 80;
            this.label9.Text = "Gender:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 618);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 79;
            this.label8.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 582);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 78;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 77;
            this.label6.Text = "Employment Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 76;
            this.label5.Text = "DOB:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 75;
            this.label4.Text = "Staff Role:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 74;
            this.label3.Text = "Staff ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 73;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 72;
            this.label1.Text = "Name:";
            // 
            // _textBoxEmail
            // 
            this._textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxEmail.Location = new System.Drawing.Point(171, 578);
            this._textBoxEmail.Name = "_textBoxEmail";
            this._textBoxEmail.Size = new System.Drawing.Size(140, 21);
            this._textBoxEmail.TabIndex = 8;
            // 
            // _textBoxSurname
            // 
            this._textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxSurname.Location = new System.Drawing.Point(171, 336);
            this._textBoxSurname.Name = "_textBoxSurname";
            this._textBoxSurname.Size = new System.Drawing.Size(140, 21);
            this._textBoxSurname.TabIndex = 1;
            // 
            // _textBoxStaffID
            // 
            this._textBoxStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxStaffID.Location = new System.Drawing.Point(171, 408);
            this._textBoxStaffID.Name = "_textBoxStaffID";
            this._textBoxStaffID.Size = new System.Drawing.Size(140, 21);
            this._textBoxStaffID.TabIndex = 3;
            // 
            // _textBoxPhone
            // 
            this._textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxPhone.Location = new System.Drawing.Point(171, 614);
            this._textBoxPhone.Name = "_textBoxPhone";
            this._textBoxPhone.Size = new System.Drawing.Size(140, 21);
            this._textBoxPhone.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(398, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 68;
            this.label12.Text = "Role: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(609, 409);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 69;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 618);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 70;
            this.button2.Text = "Generate Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(454, 373);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(236, 20);
            this.textBox2.TabIndex = 71;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(454, 412);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 72;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // DBManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 763);
            this.Controls.Add(this._textBoxName);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this._textBoxStaffPassword);
            this.Controls.Add(this.button2);
            this.Controls.Add(this._dateTimePickerEmployDate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._dateTimePickerDOB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this._ComboBoxGender);
            this.Controls.Add(this._comboBoxStaffRole);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.ButtonClearAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.buttonCreateStaff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._textBoxPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._textBoxStaffID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._textBoxSurname);
            this.Controls.Add(this._textBoxEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DBManagementForm";
            this.Text = "East Anglia Hospital Trust  -  Staff Database";
            this.Load += new System.EventHandler(this.DBManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ButtonClearAll;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button buttonCreateStaff;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox _textBoxStaffPassword;
        private System.Windows.Forms.DateTimePicker _dateTimePickerEmployDate;
        private System.Windows.Forms.DateTimePicker _dateTimePickerDOB;
        private System.Windows.Forms.ComboBox _ComboBoxGender;
        private System.Windows.Forms.ComboBox _comboBoxStaffRole;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _textBoxEmail;
        private System.Windows.Forms.TextBox _textBoxSurname;
        private System.Windows.Forms.TextBox _textBoxStaffID;
        private System.Windows.Forms.TextBox _textBoxPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox _textBoxName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

