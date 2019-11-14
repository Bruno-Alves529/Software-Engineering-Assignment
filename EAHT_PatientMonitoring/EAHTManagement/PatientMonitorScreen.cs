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
    public partial class PatientMonitorScreen : Form
    {

        double patientTemp = 36.00;
        string[] Myval = { "minus", "plus", "nothing" };
        bool alarmActive;
        static Random rnd = new Random();


        public PatientMonitorScreen()
        {
            InitializeComponent();
        }

        private void PatientMonitorScreen_Load(object sender, EventArgs e)
        {
            buttonRespond.Visible = false;
            labelDate.Text = DateTime.Now.ToLongDateString();
            label2.Text = patientTemp.ToString(".00") + "  °C";

        }

        

        private void buttonRespond_Click(object sender, EventArgs e)
        {
            textBox4.Text = DateTime.Now.ToString();
            patientTemp = 36.00;
            alarmActive = false;

            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRespond_Click_1(object sender, EventArgs e)
        {
            textBox4.Text = DateTime.Now.ToString();
            patientTemp = 36.00;
            alarmActive = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();

            int temp = rnd.Next(0, 11);

            label1.Text = (temp).ToString(); // for debug purpose

            string gg = temp.ToString();
            double dd = double.Parse(gg);// / 10;
            foreach (var val in Myval)

                switch (val)
                {

                    case "minus" when temp <= 3 && alarmActive == false:
                        patientTemp = patientTemp - 0.1;
                        //textBox3.Text = textBox3.Text.ToString() + ", " + "-";
                        label2.Text = patientTemp.ToString(".00") + "  °C";
                        break;

                    case "plus" when temp >= 8 && alarmActive == false:
                        patientTemp = patientTemp + 0.1;
                        //textBox3.Text = textBox3.Text.ToString() + ", " + "+";
                        break;

                    case "nothing" when alarmActive == true:

                        break;
                    default:
                        // do nothing
                        break;
                }


            if (patientTemp <= 35.50 || patientTemp >= 37.50 && alarmActive == false)
            {
                buttonRespond.Visible = true;
                alarmActive = true;
                label5.ForeColor = Color.Red;
                groupBox1.BackColor = Color.Orange;
                label5.Text = patientTemp.ToString(".00") + "  °C";
               // label2.Text = " mhjffffffk";
                Console.Beep();
                textBox5.Text = DateTime.Now.ToString();
            }
            else
            {
                buttonRespond.Visible = false;
                label5.ForeColor = Color.Black;
                groupBox1.BackColor = Color.Transparent;
                label5.Text = patientTemp.ToString(".00") + " °C";
                label6.Text = " mhaaaaaaajk";
            }

            textBox2.Text = textBox2.Text.ToString() + ", " + temp;


            //string count = label5.Text;
           // float first;
          //  first = float.Parse(textBox1.Text);


            //label2.Text = (rnd.Next(35, 38)).ToString();

            // Blood pressure reading display 
            label3.Text = (rnd.Next(95, 105)).ToString();
            label12.Text = (rnd.Next(65, 78)).ToString();

        }
    }
}
