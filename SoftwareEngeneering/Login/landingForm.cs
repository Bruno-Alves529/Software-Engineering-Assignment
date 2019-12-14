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

namespace Login
{
    public partial class landingForm : Form
    {
        //This allows for calling upon this form without having to declare the variables it asks for
        public static landingForm Current;

        public landingForm(string sID, string sN, string sR)
        {
            //Code starts reading here
            Current = this;
            InitializeComponent();

            //Assigning user ID 
            string _sID = sID;

            //Assigning user name
            string _sN = sN;

            //Assigning user Role
            string _sR = sR;
            
            //Print the time that the shift started
            ShiftStart.Text = "Shift Start: " + DateTime.Now.ToString();

            //Print the user's staff id
            labelStaffID.Text = "Staff ID: " + _sID;

            //Print the user's Name
            labelName.Text = "Name: " + _sN;

            //Print the user's Role
            labelRole.Text = "Role: " + _sR;
        }

        private void centralStationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //form2 represents the central station and this function links the landing form to it
            new Form2().Show();
            //hide the current page
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Takes the user back to the log in form
            new MainForm().Show();
            //Hides the current form
            this.Hide();
        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Validates if the user is a manager if so it has permission to access the management tab
            //Otherwise a message will appear telling them they do not have permission to do so
            if (labelRole.Text == "Role: Management")
            {
                //Hides the current Form
                this.Hide();
                //Displayes the management form
                new DBManagementForm().Show();
            }
            else
            {
                MessageBox.Show("You do not have permission to access the management tab!");
            }
        }
    }
}
