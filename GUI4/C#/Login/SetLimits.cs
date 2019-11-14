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
    public partial class SetLimits : Form
    {
        public SetLimits()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // saves the limit values in the DB
            //
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }
    }
}
