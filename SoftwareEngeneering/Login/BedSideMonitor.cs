using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class BedSideMonitor : Form
    {
       //declare variables
        int bpm =  5;
        int temp = 35;
        int syst = 122;
        int dias = 85;
        int puls = 80;
        Random rand = new Random();
        //Constructor
        public BedSideMonitor()
        {
            InitializeComponent();
        }
        private void centralSattionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //moving back to central station form
            new Form2().Show();
            //Closes current form
            this.Hide();
        }
        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //log off and move to main form
            new MainForm().Show();
            //Closes current form
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //exit the program
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //generate random numbers for the bpm's and changes the color regarding the situation
            //Red is for alert and green stable
            bpm = rand.Next(0, 40);
            if (bpm > 25 || bpm < 12)
            {
                label7.BackColor = Color.Red;
                Console.Beep();
                pictureBox3.ImageLocation = "images/Shape3.jpg";
            }
            else
            {
                label7.BackColor = Color.PaleGreen;
                pictureBox3.ImageLocation = "images/Shape2.jpg";
            }
            label7.Text = bpm.ToString() + " BPM";

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            //Closes the application
            Application.Exit();
        }
        private void Temperature_Tick(object sender, EventArgs e)
        {
            //generate random numbers for the temperature and changes the color regarding the situation
            //Red is for alert and green stable
            temp = rand.Next(25, 42);
                if (temp > 38 || temp < 35)
                {
                    label9.BackColor = Color.Red;
                Console.Beep();
                //change picture from location
                pictureBox4.ImageLocation = "images/Shape3.jpg";
                Patient.BackColor = Color.Red;
            }
                else
                {
                    label9.BackColor = Color.PaleGreen;
                Patient.BackColor = Color.Green;
                //change picture from location
                pictureBox4.ImageLocation = "images/Shape2.jpg";
            }

                label9.Text = temp.ToString() + "° C";
        }

        private void Systolic_Tick(object sender, EventArgs e)
        {
            //generating random numbers, backColor using if else statment
            syst = rand.Next(70, 190);
            if (syst > 120 || syst < 90)
            {
                //Creates a beep signal to alert the user something is wrong.
                Console.Beep();
                label4.BackColor = Color.Red;
                //change picture from location
                pictureBox2.ImageLocation = "images/Shape3.jpg";
            }
            else
            {
                label4.BackColor = Color.PaleGreen;
                //change picture from location
                pictureBox2.ImageLocation = "images/Shape2.jpg";
            }

            label4.Text = syst.ToString();
        }

        private void Diastolic_Tick(object sender, EventArgs e)
        {
            //generating random numbers, backColor using if else statment
            //change picture from location
            dias = rand.Next(40, 100);
            if (dias > 80 || dias < 60)
            {
                label5.BackColor = Color.Red;
                Console.Beep();
                pictureBox2.ImageLocation = "images/Shape3.jpg";
            }
            else
            {
                label5.BackColor = Color.PaleGreen;
             
                pictureBox2.ImageLocation = "images/Shape2.jpg";
            }

            label5.Text = dias.ToString();
        }

        private void Pulse_Tick(object sender, EventArgs e)
        {
            //generating random numbers, backColor using if else statment
            //change picture from location
            puls = rand.Next(20, 200);
            if (puls > 100 || puls < 40)
            {
                label6.BackColor = Color.Red;
                Console.Beep();
                pictureBox2.ImageLocation = "images/Shape3.jpg";
            }
            else
            {
                label6.BackColor = Color.PaleGreen;
               
                pictureBox2.ImageLocation = "images/Shape2.jpg";
            }

            label6.Text = puls.ToString() + " BPM";
        }
    }
}


