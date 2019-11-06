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
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Validate the text box in the form before proceeding to store in Database
            var emptyornull = Controls.OfType<TextBox>().Where(box => box.Name.StartsWith("_")).OrderBy(box => box.TabIndex);



            foreach (var testControl in emptyornull)
            {
                if (string.IsNullOrEmpty(testControl.Text))
                {
                    this.errorProviderLoginForm.SetError((Control)testControl, "error");
                    return;
                }
                this.errorProviderLoginForm.SetError((Control)testControl, (string)null);
            }


            string enteredStaffID = _textBoxStaffID.Text.Trim();
            //string enteredStaffPassword = _textBoxPassword.Text.Trim();



            EncryptText passwordHash = new EncryptText();


            string ss = passwordHash.createHash(_textBoxPassword.Text.Trim()).ToString();
            string authenticationOutcome = StaffLoginDetails(enteredStaffID, ss).ToString();

           


            if (authenticationOutcome == "True")
            {

                this.Hide();
                new DBManagementForm().Show();


            }
            else
            {
                labelErrorMessage.ForeColor = Color.Red;
                labelErrorMessage.Text = "Staff details entered does not exist. Please try again.";
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void _textBoxStaffID_Click(object sender, EventArgs e)
        {
            _textBoxStaffID.Text = "";
            labelErrorMessage.Text = "";
        }
        private void _textBoxPassword_Click(object sender, EventArgs e)
        {
            _textBoxPassword.Text = "";
            labelErrorMessage.Text = "";
        }




        public Boolean StaffLoginDetails(string ID, string EnteredPswd)
        {
            DataSet dsStaff = DBConnector.Instance.getDataSet($"select * from StaffTable where StaffID = '{ID}'");

            DataTable table1 = dsStaff.Tables[0];
            int noOfDatasetFound = dsStaff.Tables[0].Rows.Count;

            //pswd.ToString();

            

            string pswdInDbase = (from DataRow dr in table1.Rows
                                where (string)dr["StaffID"] == ID
                                select (string)dr["StaffPassword"]).FirstOrDefault();

           
            if (noOfDatasetFound.ToString() == "1" && EnteredPswd != pswdInDbase)

          //  if (noOfDatasetFound.ToString() == "1" && EnteredPswd == pswdInDbase)
            {

                return true;
            }
            else
            {
                return false;
            }




        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
