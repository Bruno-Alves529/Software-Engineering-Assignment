using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAHTManagement
{
    public partial class DBManagementForm : Form
    {
        public DBManagementForm()
        {
            InitializeComponent();
        }

        private void ClearFormEntry()
        {
            _textBoxName.Text = null;
            _textBoxSurname.Text = null;
            _ComboBoxGender.Text = null;
            _textBoxStaffID.Text = null;
            _textBoxStaffPassword.Text = null;
            _comboBoxStaffRole.Text = null;
            _dateTimePickerDOB.Value = DateTime.Now;
            _dateTimePickerEmployDate.Value = DateTime.Now;
            _textBoxEmail.Text = null;
            _textBoxPhone.Text = null;
        }


        private void DBManagementForm_Load(object sender, EventArgs e)
        {
            populateGridView();
            
            // When the Form loads display current date and time and also 
            labelDate.Text = DateTime.Now.ToLongDateString();
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // start timer so as to refresh the time each seconds. 
            // in timers property 1000 interval = 1 seconds
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }


        public void populateGridView()
        {
            //get the data set
            DataSet dsStaff = DBConnector.Instance.getDataSet("SELECT * FROM StaffTable");

            DataTable table = dsStaff.Tables[0];

            dataGridView1.DataSource = table;
        }

        private void buttonCreateStaff_Click(object sender, EventArgs e)
        {
            //Validate the text box in the form before proceeding to store in Database
            var emptyornull = Controls.OfType<TextBox>().Where(box => box.Name.StartsWith("_")).OrderBy(box => box.TabIndex);
            var emptyornull2 = Controls.OfType<ComboBox>().Where(box => box.Name.StartsWith("_")).OrderBy(box => box.TabIndex);


            foreach (var testControl in emptyornull)
            {
                if (string.IsNullOrEmpty(testControl.Text))
                {
                    this.errorProvider1.SetError((Control)testControl, "error");
                    return;
                }
                this.errorProvider1.SetError((Control)testControl, (string)null);
            }

            // I am trying to combine these two loops into one loop
            foreach (var testControl in emptyornull2)
            {
                if (string.IsNullOrEmpty(testControl.Text))
                {
                    this.errorProvider1.SetError((Control)testControl, "error");
                    return;
                }
                this.errorProvider1.SetError((Control)testControl, (string)null);

            }

            EncryptText password = new EncryptText();

            DBConnector.Instance.recordInDB(_textBoxName.Text,
                _textBoxSurname.Text,
                _ComboBoxGender.Text,
                _textBoxStaffID.Text,
                password.createHash(_textBoxStaffPassword.Text),
                _comboBoxStaffRole.Text,
                _dateTimePickerDOB.Value.ToString("dd/MM/yyyy"),
                _dateTimePickerEmployDate.Value.ToString("dd/MM/yyyy"),
                _textBoxEmail.Text,
                _textBoxPhone.Text);

            // update the dataGridView
            populateGridView();
            ClearFormEntry();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            // update the dataGridView
            populateGridView();
        }

        private void ButtonClearAll_Click(object sender, EventArgs e)
        {
            ClearFormEntry();
        }

       

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
         DataSet dsStaff = DBConnector.Instance.getDataSet($"select * from StaffTable where Surname = '{surnameText.Text}'");

                    DataTable table1 = dsStaff.Tables[0];
                    int noOfDatasetFound = dsStaff.Tables[0].Rows.Count;

                    //Poplulate dataDridView with the search result
                    dataGridView1.DataSource = table1;

                    textBox1.Text = noOfDatasetFound.ToString();
                    if (noOfDatasetFound.ToString()== "1")
                    {
                        string StaffID = (from DataRow dr in table1.Rows
                                          where (string)dr["Surname"] == surnameText.Text
                                          select (string)dr["StaffID"]).FirstOrDefault();
                textBox3.Text = StaffID.ToString();
                        
                    }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _textBoxName.Text = "Jerimiah";
            _textBoxSurname.Text = "Abraham";
            _ComboBoxGender.Text = "Male";
            _textBoxStaffID.Text = "JA2211";
            _textBoxStaffPassword.Text = "ABCDEF";
            _comboBoxStaffRole.Text = "Consultant";
            _dateTimePickerDOB.Value = DateTime.Now ;
            _dateTimePickerEmployDate.Value = DateTime.Now;
            _textBoxEmail.Text = "abcdefgh@gmail.com";
            _textBoxPhone.Text = "07447522255";
        }
    }
}
