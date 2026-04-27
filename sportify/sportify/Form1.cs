using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sportify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chkpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpass.Checked)
            {
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '*';
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
             string user = txtuser.Text.Trim();
            string pass = txtpass.Text.Trim();

            if (user.Equals("admin") && pass.Equals("admin"))
            {
                dashboard d = new dashboard();
                d.Show();
            }
            else
            {
                MessageBox.Show("Kindly,Enter Correct Username and Password");
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtpass.PasswordChar = '*';
        }
    }
}
