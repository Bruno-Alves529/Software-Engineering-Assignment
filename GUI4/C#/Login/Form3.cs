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
    public partial class Form3 : Form
    {
       //declare variables
        int bpm =  5;
        int temp = 35;
        int syst = 122;
        int dias = 85;
        int puls = 80;
        Random rand = new Random();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
      
        private void centralSattionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //moving back to central station form
            new Form2().Show();
            this.Hide();
        }

        private void smithJohnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit the program
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //log off and move to main form
            new MainForm().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //exit the program
            this.Close();
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //generating random numbers, backColor using if else statment
            bpm = rand.Next(0, 40);
            if (bpm > 25 || bpm < 12)
            {
                label7.BackColor = Color.Red;
                pictureBox3.ImageLocation = "images/Shape3.jpg";
            }
            else
            {
                label7.BackColor = Color.PaleGreen;
                pictureBox3.ImageLocation = "images/Shape2.jpg";
            }
            label7.Text = bpm.ToString() + " BPM";

        }
            private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Temperature_Tick(object sender, EventArgs e)
        {
            //generating random numbers, backColor using if else statment
            temp = rand.Next(25, 42);
                if (temp > 38 || temp < 35)
                {
                    label9.BackColor = Color.Red;
                //change picture from location
                pictureBox4.ImageLocation = "images/Shape3.jpg";
                label13.BackColor = Color.Red;
            }
                else
                {
                    label9.BackColor = Color.PaleGreen;
                label13.BackColor = Color.Green;
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
              
                pictureBox2.ImageLocation = "images/Shape3.jpg";
            }
            else
            {
                label5.BackColor = Color.PaleGreen;
             
                pictureBox2.ImageLocation = "images/Shape2.jpg";
            }

            label5.Text = dias.ToString();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void Pulse_Tick(object sender, EventArgs e)
        {
            //generating random numbers, backColor using if else statment
            //change picture from location
            puls = rand.Next(20, 200);
            if (puls > 100 || puls < 40)
            {
                label6.BackColor = Color.Red;
             
                pictureBox2.ImageLocation = "images/Shape3.jpg";
            }
            else
            {
                label6.BackColor = Color.PaleGreen;
               
                pictureBox2.ImageLocation = "images/Shape2.jpg";
            }

            label6.Text = puls.ToString() + " BPM";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
    }


