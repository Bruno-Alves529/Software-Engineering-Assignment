using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form2 : Form
    {
        //declare variables
        //Variable for the temperature readings
        int temp = 35;
        //Random Variable for future assignment of values
        Random rand = new Random();

        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Opens the bedside monitor
            new BedSideMonitor().Show();
            //Closes the current form
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Closes the application
            Application.Exit();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opens a new log in form 
            new MainForm().Show();
            //Closes the current form
            this.Hide();
        }

        private void Beds_Tick(object sender, EventArgs e)
        {
            //Assigns a new random value that allows the system to alert the staff if something is wrong
            temp = rand.Next(25, 42);
            if (temp > 38 || temp < 35)
            {
                pictureBox2.ImageLocation = "images/bed3.jpg";
                Bed1.BackColor = Color.Salmon;
            }
            else
            {
                Bed1.BackColor = Color.PaleGreen;
                pictureBox2.ImageLocation = "images/bed2.jpg"; 
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Takes the user to the Main Page
            landingForm.Current.Show();
            //Closes Current form
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new BedSideMonitor().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new BedSideMonitor().Show();
            this.Hide();
        }
    }
}
        
    
