using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Login
{
    public partial class DBManagementForm : Form
    {
        public DBManagementForm()
        {
            InitializeComponent();
            string[] ReadingModule = { "Blood Pressure", "Body Temperature", "Heart Rate", "Blood Sugar", "Breathing Rate", "Pulse Rate", "Cholesterol Level" };
        }
        
        private void DBManagementForm_Load(object sender, EventArgs e)
        {
            PopulateGridViewPatient();
            PopulateGridViewStaff();
            // When the Form loads display current date and time and also 
            labelDate.Text = DateTime.Now.ToLongDateString();
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // start timer so as to refresh the time each seconds. 
            // in timers property 1000 interval = 1 seconds
            labelDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }
        
        public void PopulateGridView()
        {
            //get the data set
            DataSet dsStaff = DBConnector.Instance.GetDataSet("SELECT * FROM StaffTable");

            DataTable table = dsStaff.Tables[0];

            dataGridViewStaff.DataSource = table;
        }
        //Exit Button
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            landingForm.Current.Show();
        }

        private void ButtonShowAll_Click(object sender, EventArgs e)
        {
            // update the dataGridView
            PopulateGridViewStaff();
            this.Refresh();
        }

        private void ButtonClearAll_Click(object sender, EventArgs e)
        {
            ClearFormEntry();
        }

        //Create Staff
        private void ButtonCreateStaff_Click(object sender, EventArgs e)
        {
            try
            {
                //Connection string
                string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EAHTDataBase." +
            "mdf;Integrated Security=True;Connect Timeout=30";
                //Create a connection
                SqlConnection myConnection = new SqlConnection(con);
                //Create a command
                SqlCommand myCommand = new SqlCommand("INSERT INTO StaffTable (Name, Surname, Gender, StaffID, StaffPassword, StaffRole, StaffDOB) VALUES (@Name, @Surname, @Gender, @StaffID, @StaffPassword, @StaffRole, @StaffDOB);" , myConnection);
                SqlParameter name = new SqlParameter("@Name", SqlDbType.NVarChar);
                SqlParameter surname = new SqlParameter("@Surname", SqlDbType.NVarChar);
                SqlParameter gender = new SqlParameter("@Gender", SqlDbType.NVarChar);
                SqlParameter staffID = new SqlParameter("@StaffID", SqlDbType.NVarChar);
                SqlParameter staffPassword = new SqlParameter("@StaffPassword", SqlDbType.NVarChar);
                SqlParameter role = new SqlParameter("@StaffRole", SqlDbType.NVarChar);
                SqlParameter StaffDOB = new SqlParameter("@StaffDOB", SqlDbType.NVarChar);
                name.Value = _textBoxName.Text;
                surname.Value = _textBoxSurname.Text;
                gender.Value = _ComboBoxGender.Text;
                staffID.Value = _textBoxStaffID.Text;
                staffPassword.Value = _textBoxStaffPassword.Text;
                role.Value = _comboBoxStaffRole.Text;
                StaffDOB.Value = dateTimePickerDOB.Text;
                myCommand.Parameters.Add(name);
                myCommand.Parameters.Add(surname);
                myCommand.Parameters.Add(gender);
                myCommand.Parameters.Add(staffID);
                myCommand.Parameters.Add(staffPassword);
                myCommand.Parameters.Add(role);
                myCommand.Parameters.Add(StaffDOB);
                myCommand.Connection = myConnection;
                myConnection.Open();
                SqlDataReader reader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                PopulateGridView();
                ClearFormEntry();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //CreatePatient
        private void ButtonCreatePatient_Click(object sender, EventArgs e)
        {
            //Adds a new patient
            try
            {
                //Connection string
                string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EAHTDataBase." +
            "mdf;Integrated Security=True;Connect Timeout=30";
                //Create a connection
                SqlConnection myConnection = new SqlConnection(con);
                //Create a command
                SqlCommand myCommand = new SqlCommand("INSERT INTO PatientTable (PatientID, PatientFullname, PatientDOB, PatientGender) VALUES (@patientID, @patientFullName, @patientDOB, @patientGender);", myConnection);
                SqlParameter patientID = new SqlParameter("@patientID", SqlDbType.NVarChar);
                SqlParameter PatientFullName = new SqlParameter("@PatientFullName", SqlDbType.NVarChar);
                SqlParameter PatientDOB = new SqlParameter("@patientDOB", SqlDbType.NVarChar);
                SqlParameter PatientGender = new SqlParameter("@patientGender", SqlDbType.NVarChar);
                patientID.Value = _textBoxPatientID.Text;
                PatientFullName.Value = _textBoxPFullname.Text;
                PatientDOB.Value = dateTimePickerpDOB.Text;
                PatientGender.Value = comboBox1.Text;
                myCommand.Parameters.Add(patientID);
                myCommand.Parameters.Add(PatientFullName);
                myCommand.Parameters.Add(PatientDOB);
                myCommand.Parameters.Add(PatientGender);
                myConnection.Open();
                SqlDataReader reader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                PopulateGridViewPatient();
                ClearFormEntry();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Shows the entries in the Patient Table
        public void PopulateGridViewPatient()
        {
            //get the data set
            DataSet dsStaff = DBConnector.Instance.GetDataSet("SELECT * FROM PatientTable");
            DataTable table = dsStaff.Tables[0];
            dataGridViewPatientRecInDB.DataSource = table;
        }

        //Shows the entries in the Staff Table
        public void PopulateGridViewStaff()
        {
            //get the data set
            DataSet dsStaff = DBConnector.Instance.GetDataSet("SELECT * FROM StaffTable");
            DataTable table = dsStaff.Tables[0];
            dataGridViewStaff.DataSource = table;
        }

        //Clear the form
        private void ClearFormEntry()
        {
            //Delete Entries from the staff table
            _textBoxName.Text = null;
            _textBoxSurname.Text = null;
            _ComboBoxGender.Text = null;
            _textBoxStaffID.Text = null;
            _textBoxStaffPassword.Text = null;
            _comboBoxStaffRole.Text = null;
            dateTimePickerDOB.Value = DateTime.Now;
            //Clear entries from the Patient Table
            _textBoxPatientID.Text = null;
            _textBoxPFullname.Text = null;
            dateTimePickerpDOB.Value = DateTime.Now;
            comboBox1.Text = null;
            PopulateGridView();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            //Validate the text box in the form before proceeding to store in Database
            var emptyornull = Controls.OfType<TextBox>().Where(box => box.Name.StartsWith("_")).OrderBy(box => box.TabIndex);
            var emptyornull2 = Controls.OfType<ComboBox>().Where(box => box.Name.StartsWith("_")).OrderBy(box => box.TabIndex);
            var boxes = Controls.OfType<TextBox>();

            foreach (var testControl in boxes)
            {
                if (string.IsNullOrEmpty(testControl.Text))
                {
                    this.errorProvider1.SetError((Control)testControl, "error");
                    return;
                }
                this.errorProvider1.SetError((Control)testControl, (string)null);
            }

            
        }

        //Clears the Staff Form
        private void ButtonClearAll_Click_1(object sender, EventArgs e)
        {
            ClearFormEntry();
        }

        //Log off
        private void Button5_Click(object sender, EventArgs e)
        {
            //Closes the current form
            this.Hide();
            new MainForm().Show();
        }

        //Clears the patient form
        private void button4_Click(object sender, EventArgs e)
        {
            ClearFormEntry();
        }

        //Delete Patient from the table
        private void buttonDeleteFromTable_Click_1(object sender, EventArgs e)
        {

            //Adds a new patient
            try
            {
                //Connection string
                string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EAHTDataBase." +
            "mdf;Integrated Security=True;Connect Timeout=30";
                //Create a connection
                SqlConnection myConnection = new SqlConnection(con);
                //Create a command
                SqlCommand myCommand = new SqlCommand("DELETE FROM PatientTable WHERE PatientID = @patientID AND PatientFullname = @PatientFullName", myConnection);
                SqlParameter patientID = new SqlParameter("@patientID", SqlDbType.NVarChar);
                SqlParameter PatientFullName = new SqlParameter("@PatientFullName", SqlDbType.NVarChar);
                patientID.Value = textBoxUpdatePID.Text;
                PatientFullName.Value = textBoxUpdatePFN.Text;
                myCommand.Parameters.Add(patientID);
                myCommand.Parameters.Add(PatientFullName);
                myConnection.Open();
                SqlDataReader reader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                PopulateGridViewPatient();
                this.Refresh();
                textBoxUpdatePFN.Text = null;
                textBoxUpdatePID.Text = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Show All Patients
        private void ButtonRefresh2_Click(object sender, EventArgs e)
        {
            PopulateGridViewPatient();
        }
        
        private IEnumerable<Control> GetAllControls(Control control)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAllControls(ctrl)).Concat(controls);
        }

        //Search the database for a specific Patient
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //Connection string
                string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EAHTDataBase." +
            "mdf;Integrated Security=True;Connect Timeout=30";
                //Create a connection
                SqlConnection myConnection = new SqlConnection(con);
                //Create a command
                SqlCommand myCommand = new SqlCommand("SELECT * FROM PatientTable WHERE PatientID = @patientID", myConnection);
                SqlParameter patientID = new SqlParameter("@patientID", SqlDbType.NVarChar);
                patientID.Value = textBox13.Text;
                myCommand.Parameters.Add(patientID);
                myConnection.Open();
                SqlDataReader reader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                reader.Close();
                this.Refresh();
                textBox13.Text = null;
                //Display the results
                SqlDataAdapter myAdapter = new SqlDataAdapter();
                myAdapter.SelectCommand = myCommand;
                DataTable PatientTable = new DataTable();
                myAdapter.Fill(PatientTable);
                dataGridViewPatientRecInDB.DataSource = PatientTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        //Search for a specific staff member
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Connection string
                string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EAHTDataBase." +
            "mdf;Integrated Security=True;Connect Timeout=30";
                //Create a connection
                SqlConnection myConnection = new SqlConnection(con);
                //Create a command
                SqlCommand myCommand = new SqlCommand("SELECT * FROM StaffTable WHERE Name = @staffName AND StaffID = @staffID", myConnection);
                SqlParameter staffName = new SqlParameter("@staffName", SqlDbType.NVarChar);
                SqlParameter staffID = new SqlParameter("@staffID", SqlDbType.NVarChar);
                staffName.Value = textBox1.Text;
                staffID.Value = textBox2.Text;
                myCommand.Parameters.Add(staffName);
                myCommand.Parameters.Add(staffID);
                myConnection.Open();
                SqlDataReader reader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                reader.Close();
                this.Refresh();
                textBox1.Text = null;
                textBox2.Text = null;
                //Display the results
                SqlDataAdapter myAdapter2 = new SqlDataAdapter();
                myAdapter2.SelectCommand = myCommand;
                DataTable StaffTable = new DataTable();
                myAdapter2.Fill(StaffTable);
                dataGridViewStaff.DataSource = StaffTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
