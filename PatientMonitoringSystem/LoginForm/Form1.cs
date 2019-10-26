using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }
    }
}
