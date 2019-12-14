namespace Login
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.tabPagePatientDbase = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteFromTable = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxUpdatePFN = new System.Windows.Forms.TextBox();
            this.textBoxUpdatePID = new System.Windows.Forms.TextBox();
            this.buttonRefresh2 = new System.Windows.Forms.Button();
            this._textBoxPFullname = new System.Windows.Forms.TextBox();
            this._textBoxPatientID = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dateTimePickerpDOB = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonCreatePatient = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.dataGridViewPatientRecInDB = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.tabPageStaffDbase = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this._textBoxName = new System.Windows.Forms.TextBox();
            this._textBoxStaffID = new System.Windows.Forms.TextBox();
            this._textBoxSurname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this._textBoxStaffPassword = new System.Windows.Forms.TextBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this._ComboBoxGender = new System.Windows.Forms.ComboBox();
            this._comboBoxStaffRole = new System.Windows.Forms.ComboBox();
            this.ButtonClearAll = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCreateStaff = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabPagePatientDbase.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientRecInDB)).BeginInit();
            this.tabPageStaffDbase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1122, 642);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 63;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(509, 6);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(37, 16);
            this.labelDate.TabIndex = 54;
            this.labelDate.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1016, 642);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 87;
            this.button5.Text = "Logoff";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // tabPagePatientDbase
            // 
            this.tabPagePatientDbase.Controls.Add(this.comboBox1);
            this.tabPagePatientDbase.Controls.Add(this.groupBox1);
            this.tabPagePatientDbase.Controls.Add(this.buttonRefresh2);
            this.tabPagePatientDbase.Controls.Add(this._textBoxPFullname);
            this.tabPagePatientDbase.Controls.Add(this._textBoxPatientID);
            this.tabPagePatientDbase.Controls.Add(this.textBox13);
            this.tabPagePatientDbase.Controls.Add(this.label23);
            this.tabPagePatientDbase.Controls.Add(this.dateTimePickerpDOB);
            this.tabPagePatientDbase.Controls.Add(this.button4);
            this.tabPagePatientDbase.Controls.Add(this.buttonCreatePatient);
            this.tabPagePatientDbase.Controls.Add(this.label20);
            this.tabPagePatientDbase.Controls.Add(this.label21);
            this.tabPagePatientDbase.Controls.Add(this.label22);
            this.tabPagePatientDbase.Controls.Add(this.dataGridViewPatientRecInDB);
            this.tabPagePatientDbase.Controls.Add(this.button6);
            this.tabPagePatientDbase.Location = new System.Drawing.Point(4, 22);
            this.tabPagePatientDbase.Name = "tabPagePatientDbase";
            this.tabPagePatientDbase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePatientDbase.Size = new System.Drawing.Size(1195, 589);
            this.tabPagePatientDbase.TabIndex = 1;
            this.tabPagePatientDbase.Text = "Patient Database";
            this.tabPagePatientDbase.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.comboBox1.Location = new System.Drawing.Point(129, 328);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 23);
            this.comboBox1.TabIndex = 198;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDeleteFromTable);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBoxUpdatePFN);
            this.groupBox1.Controls.Add(this.textBoxUpdatePID);
            this.groupBox1.Location = new System.Drawing.Point(564, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 207);
            this.groupBox1.TabIndex = 197;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit && Delete";
            // 
            // buttonDeleteFromTable
            // 
            this.buttonDeleteFromTable.BackColor = System.Drawing.Color.Gray;
            this.buttonDeleteFromTable.Location = new System.Drawing.Point(19, 155);
            this.buttonDeleteFromTable.Name = "buttonDeleteFromTable";
            this.buttonDeleteFromTable.Size = new System.Drawing.Size(140, 28);
            this.buttonDeleteFromTable.TabIndex = 207;
            this.buttonDeleteFromTable.Text = "Delete Record";
            this.buttonDeleteFromTable.UseVisualStyleBackColor = false;
            this.buttonDeleteFromTable.Click += new System.EventHandler(this.buttonDeleteFromTable_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 201;
            this.label7.Text = "Patient ID*:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 15);
            this.label14.TabIndex = 199;
            this.label14.Text = "Patient Fullname:";
            // 
            // textBoxUpdatePFN
            // 
            this.textBoxUpdatePFN.Location = new System.Drawing.Point(130, 90);
            this.textBoxUpdatePFN.Name = "textBoxUpdatePFN";
            this.textBoxUpdatePFN.Size = new System.Drawing.Size(188, 20);
            this.textBoxUpdatePFN.TabIndex = 197;
            // 
            // textBoxUpdatePID
            // 
            this.textBoxUpdatePID.Location = new System.Drawing.Point(107, 30);
            this.textBoxUpdatePID.Name = "textBoxUpdatePID";
            this.textBoxUpdatePID.Size = new System.Drawing.Size(211, 20);
            this.textBoxUpdatePID.TabIndex = 196;
            // 
            // buttonRefresh2
            // 
            this.buttonRefresh2.Location = new System.Drawing.Point(795, 206);
            this.buttonRefresh2.Name = "buttonRefresh2";
            this.buttonRefresh2.Size = new System.Drawing.Size(122, 23);
            this.buttonRefresh2.TabIndex = 195;
            this.buttonRefresh2.Text = "Refresh/Show All";
            this.buttonRefresh2.UseVisualStyleBackColor = true;
            this.buttonRefresh2.Click += new System.EventHandler(this.ButtonRefresh2_Click);
            // 
            // _textBoxPFullname
            // 
            this._textBoxPFullname.Location = new System.Drawing.Point(129, 267);
            this._textBoxPFullname.Name = "_textBoxPFullname";
            this._textBoxPFullname.Size = new System.Drawing.Size(173, 20);
            this._textBoxPFullname.TabIndex = 116;
            // 
            // _textBoxPatientID
            // 
            this._textBoxPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxPatientID.Location = new System.Drawing.Point(129, 235);
            this._textBoxPatientID.Name = "_textBoxPatientID";
            this._textBoxPatientID.Size = new System.Drawing.Size(173, 21);
            this._textBoxPatientID.TabIndex = 119;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(1021, 206);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(163, 20);
            this.textBox13.TabIndex = 112;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(22, 238);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 15);
            this.label23.TabIndex = 145;
            this.label23.Text = "Patient ID:";
            // 
            // dateTimePickerpDOB
            // 
            this.dateTimePickerpDOB.CustomFormat = "dd-MMMM-yyyy";
            this.dateTimePickerpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerpDOB.Location = new System.Drawing.Point(129, 298);
            this.dateTimePickerpDOB.MaxDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerpDOB.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerpDOB.Name = "dateTimePickerpDOB";
            this.dateTimePickerpDOB.Size = new System.Drawing.Size(173, 21);
            this.dateTimePickerpDOB.TabIndex = 122;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 28);
            this.button4.TabIndex = 127;
            this.button4.Text = "Clear All";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonCreatePatient
            // 
            this.buttonCreatePatient.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreatePatient.Location = new System.Drawing.Point(162, 393);
            this.buttonCreatePatient.Name = "buttonCreatePatient";
            this.buttonCreatePatient.Size = new System.Drawing.Size(140, 28);
            this.buttonCreatePatient.TabIndex = 126;
            this.buttonCreatePatient.Text = "Create New Patient";
            this.buttonCreatePatient.UseVisualStyleBackColor = true;
            this.buttonCreatePatient.Click += new System.EventHandler(this.ButtonCreatePatient_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(22, 328);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 15);
            this.label20.TabIndex = 134;
            this.label20.Text = "Patient Gender:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(22, 298);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 15);
            this.label21.TabIndex = 133;
            this.label21.Text = "Patient DOB:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(22, 268);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(103, 15);
            this.label22.TabIndex = 131;
            this.label22.Text = "Patient Fullname:";
            // 
            // dataGridViewPatientRecInDB
            // 
            this.dataGridViewPatientRecInDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatientRecInDB.Location = new System.Drawing.Point(12, 9);
            this.dataGridViewPatientRecInDB.Name = "dataGridViewPatientRecInDB";
            this.dataGridViewPatientRecInDB.Size = new System.Drawing.Size(1168, 196);
            this.dataGridViewPatientRecInDB.TabIndex = 114;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(923, 206);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 113;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tabPageStaffDbase
            // 
            this.tabPageStaffDbase.Controls.Add(this.textBox2);
            this.tabPageStaffDbase.Controls.Add(this.textBox1);
            this.tabPageStaffDbase.Controls.Add(this.label8);
            this.tabPageStaffDbase.Controls.Add(this.label6);
            this.tabPageStaffDbase.Controls.Add(this.button2);
            this.tabPageStaffDbase.Controls.Add(this._textBoxName);
            this.tabPageStaffDbase.Controls.Add(this._textBoxStaffID);
            this.tabPageStaffDbase.Controls.Add(this._textBoxSurname);
            this.tabPageStaffDbase.Controls.Add(this.label11);
            this.tabPageStaffDbase.Controls.Add(this._textBoxStaffPassword);
            this.tabPageStaffDbase.Controls.Add(this.dateTimePickerDOB);
            this.tabPageStaffDbase.Controls.Add(this._ComboBoxGender);
            this.tabPageStaffDbase.Controls.Add(this._comboBoxStaffRole);
            this.tabPageStaffDbase.Controls.Add(this.ButtonClearAll);
            this.tabPageStaffDbase.Controls.Add(this.label9);
            this.tabPageStaffDbase.Controls.Add(this.label5);
            this.tabPageStaffDbase.Controls.Add(this.label4);
            this.tabPageStaffDbase.Controls.Add(this.buttonCreateStaff);
            this.tabPageStaffDbase.Controls.Add(this.label3);
            this.tabPageStaffDbase.Controls.Add(this.label2);
            this.tabPageStaffDbase.Controls.Add(this.label1);
            this.tabPageStaffDbase.Controls.Add(this.dataGridViewStaff);
            this.tabPageStaffDbase.Controls.Add(this.buttonShowAll);
            this.tabPageStaffDbase.Location = new System.Drawing.Point(4, 22);
            this.tabPageStaffDbase.Name = "tabPageStaffDbase";
            this.tabPageStaffDbase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStaffDbase.Size = new System.Drawing.Size(1195, 589);
            this.tabPageStaffDbase.TabIndex = 0;
            this.tabPageStaffDbase.Text = "Staff Database";
            this.tabPageStaffDbase.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(777, 416);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 21);
            this.textBox2.TabIndex = 116;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(777, 375);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 21);
            this.textBox1.TabIndex = 115;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(676, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 114;
            this.label8.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(676, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 113;
            this.label6.Text = "Staff ID:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(777, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 30);
            this.button2.TabIndex = 112;
            this.button2.Text = "SearchStaff";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // _textBoxName
            // 
            this._textBoxName.Location = new System.Drawing.Point(170, 205);
            this._textBoxName.Name = "_textBoxName";
            this._textBoxName.Size = new System.Drawing.Size(140, 20);
            this._textBoxName.TabIndex = 86;
            // 
            // _textBoxStaffID
            // 
            this._textBoxStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxStaffID.Location = new System.Drawing.Point(170, 317);
            this._textBoxStaffID.Name = "_textBoxStaffID";
            this._textBoxStaffID.Size = new System.Drawing.Size(140, 21);
            this._textBoxStaffID.TabIndex = 89;
            // 
            // _textBoxSurname
            // 
            this._textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxSurname.Location = new System.Drawing.Point(170, 245);
            this._textBoxSurname.Name = "_textBoxSurname";
            this._textBoxSurname.Size = new System.Drawing.Size(140, 21);
            this._textBoxSurname.TabIndex = 87;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 111;
            this.label11.Text = "Password:";
            // 
            // _textBoxStaffPassword
            // 
            this._textBoxStaffPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxStaffPassword.Location = new System.Drawing.Point(170, 346);
            this._textBoxStaffPassword.Name = "_textBoxStaffPassword";
            this._textBoxStaffPassword.Size = new System.Drawing.Size(140, 21);
            this._textBoxStaffPassword.TabIndex = 90;
            this._textBoxStaffPassword.UseSystemPasswordChar = true;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(170, 419);
            this.dateTimePickerDOB.MaxDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDOB.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(140, 21);
            this.dateTimePickerDOB.TabIndex = 92;
            // 
            // _ComboBoxGender
            // 
            this._ComboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ComboBoxGender.FormattingEnabled = true;
            this._ComboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this._ComboBoxGender.Location = new System.Drawing.Point(170, 280);
            this._ComboBoxGender.Name = "_ComboBoxGender";
            this._ComboBoxGender.Size = new System.Drawing.Size(140, 23);
            this._ComboBoxGender.TabIndex = 88;
            // 
            // _comboBoxStaffRole
            // 
            this._comboBoxStaffRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._comboBoxStaffRole.FormattingEnabled = true;
            this._comboBoxStaffRole.Items.AddRange(new object[] {
            "Medical Staff",
            "Consultant",
            "Management"});
            this._comboBoxStaffRole.Location = new System.Drawing.Point(170, 378);
            this._comboBoxStaffRole.Name = "_comboBoxStaffRole";
            this._comboBoxStaffRole.Size = new System.Drawing.Size(140, 23);
            this._comboBoxStaffRole.TabIndex = 91;
            // 
            // ButtonClearAll
            // 
            this.ButtonClearAll.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClearAll.Location = new System.Drawing.Point(82, 463);
            this.ButtonClearAll.Name = "ButtonClearAll";
            this.ButtonClearAll.Size = new System.Drawing.Size(117, 30);
            this.ButtonClearAll.TabIndex = 97;
            this.ButtonClearAll.Text = "Clear All";
            this.ButtonClearAll.UseVisualStyleBackColor = true;
            this.ButtonClearAll.Click += new System.EventHandler(this.ButtonClearAll_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 110;
            this.label9.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 106;
            this.label5.Text = "DOB:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 105;
            this.label4.Text = "Staff Role:";
            // 
            // buttonCreateStaff
            // 
            this.buttonCreateStaff.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateStaff.Location = new System.Drawing.Point(205, 463);
            this.buttonCreateStaff.Name = "buttonCreateStaff";
            this.buttonCreateStaff.Size = new System.Drawing.Size(117, 30);
            this.buttonCreateStaff.TabIndex = 96;
            this.buttonCreateStaff.Text = "Create Staff";
            this.buttonCreateStaff.UseVisualStyleBackColor = true;
            this.buttonCreateStaff.Click += new System.EventHandler(this.ButtonCreateStaff_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 104;
            this.label3.Text = "Staff ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 103;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 101;
            this.label1.Text = "Name:";
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Location = new System.Drawing.Point(16, 14);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.Size = new System.Drawing.Size(1147, 176);
            this.dataGridViewStaff.TabIndex = 57;
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(1003, 205);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(75, 23);
            this.buttonShowAll.TabIndex = 66;
            this.buttonShowAll.Text = "Refresh";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.ButtonShowAll_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageStaffDbase);
            this.tabControl1.Controls.Add(this.tabPagePatientDbase);
            this.tabControl1.Location = new System.Drawing.Point(9, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1203, 615);
            this.tabControl1.TabIndex = 86;
            // 
            // DBManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 669);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DBManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "East Anglia Hospital Trust  -  Staff Database";
            this.Load += new System.EventHandler(this.DBManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabPagePatientDbase.ResumeLayout(false);
            this.tabPagePatientDbase.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientRecInDB)).EndInit();
            this.tabPageStaffDbase.ResumeLayout(false);
            this.tabPageStaffDbase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageStaffDbase;
        private System.Windows.Forms.TextBox _textBoxName;
        private System.Windows.Forms.TextBox _textBoxStaffID;
        private System.Windows.Forms.TextBox _textBoxSurname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox _textBoxStaffPassword;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.ComboBox _ComboBoxGender;
        private System.Windows.Forms.ComboBox _comboBoxStaffRole;
        private System.Windows.Forms.Button ButtonClearAll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCreateStaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.TabPage tabPagePatientDbase;
        private System.Windows.Forms.TextBox _textBoxPFullname;
        private System.Windows.Forms.TextBox _textBoxPatientID;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dateTimePickerpDOB;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonCreatePatient;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView dataGridViewPatientRecInDB;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDeleteFromTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxUpdatePFN;
        private System.Windows.Forms.TextBox textBoxUpdatePID;
        private System.Windows.Forms.Button buttonRefresh2;
    }
}

