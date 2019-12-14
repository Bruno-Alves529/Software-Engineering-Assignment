using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Login
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
           
        }

        //Validate that the user exists within the database
        public void userValidation()
        {
            //Variable declaration
            string staffNu; //Represents the staff ID
            string staffName;//Represents the staff Name
            string staffRole;//Represents the staff role
            //Constructor
            try
            {
                //Connection string
                string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EAHTDataBase." +
            "mdf;Integrated Security=True;Connect Timeout=30";
                //Create a new connection
                SqlConnection myConnection = new SqlConnection(con);
                //Create an Sql command 
                SqlCommand myCommand = new SqlCommand("SELECT * From StaffTable Where StaffID = @StaffID And StaffPassword = @StaffPassword;");
                SqlParameter userName = new SqlParameter("@StaffID", SqlDbType.NVarChar);
                SqlParameter passWord = new SqlParameter("@StaffPassword", SqlDbType.NVarChar);
                userName.Value = nametxtbox.Text;
                passWord.Value = pwdtxtbox.Text;
                myCommand.Parameters.Add(userName);
                myCommand.Parameters.Add(passWord);
                myCommand.Connection = myConnection;
                //Open the connection
                myConnection.Open();
                SqlDataReader reader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                //Validate that the user exists and log in otherwise ask for credentials again
                if (reader.Read() == true)
                {
                    //staff name assignment to further use in other forms
                    staffName = reader["Name"].ToString();
                    //staff role assignment to further use in other forms
                    staffRole = reader["StaffRole"].ToString();
                    //staff ID assignment to further use in other forms
                    staffNu = nametxtbox.Text;
                    MessageBox.Show("You are now logged in ");
                    //Close the current form
                    this.Hide();
                    //Open a new form
                    new landingForm(staffNu, staffName, staffRole).Show();
                }
                else
                {
                    MessageBox.Show("Please try again!", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nametxtbox.Clear();
                    pwdtxtbox.Clear();
                    nametxtbox.Focus();
                }
                //Force the connection to close
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //Force the user to insert a user name
          if (nametxtbox.Text == "")
            {
                MessageBox.Show("Please Insert your Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          //Force the user to insert a password
          if (pwdtxtbox.Text == "")
            {
                MessageBox.Show("Please Insert your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            userValidation();
        }

        public void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Ask the user to contact a manager in case he lost its credentials
            MessageBox.Show("Please contact your manager");
        }

        public void button2_Click(object sender, EventArgs e)
        {
            //Close the application
            Application.Exit();
        }
    }
}
