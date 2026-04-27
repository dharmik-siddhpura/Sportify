using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace sportify
{
    public partial class frmstaffadd : Form
    {
        connectionclass c = new connectionclass();
        SqlConnection con;
        SqlCommand cmd;
        string qry = string.Empty;
        int i;
        public frmstaffadd()
        {
            InitializeComponent();
        }
        public frmstaffadd(int i)
        {
            InitializeComponent();
            this.i = i;
            fillmycontrols();
        }
        public void fillmycontrols()
        {
            qry = "select * from tbl_staff where SF_id=" + i + "";
            DataTable dt = new DataTable();
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            txtid.Text = i.ToString();
            txtstaffname.Text = dt.Rows[0][1].ToString();
            txtphone.Text = dt.Rows[0][2].ToString();
            txtemail.Text = dt.Rows[0][3].ToString();
            txtaddress.Text = dt.Rows[0][4].ToString();
            txtdate.Text = dt.Rows[0][5].ToString();
            txtsalary.Text = dt.Rows[0][6].ToString();
            if (dt.Rows[0][7].ToString() == "male")
                rdbmale.Checked = true;
            else
                rdbfemale.Checked = true;
         
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        void clear()
        {
            txtstaffname.Clear();
            txtphone.Clear();
            txtemail.Clear();
            txtaddress.Clear();
            txtdate.Checked = false;
            if (rdbmale.Checked)
                rdbmale.Checked = false;
            else
                rdbfemale.Checked = false;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                qry = "select count(*) from tbl_staff where SF_name = @SF_name OR SF_phone = @SF_phone";
                con = new SqlConnection(c.cnstr);
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@SF_name", txtstaffname.Text.Trim());
                cmd.Parameters.AddWithValue("@SF_phone", txtphone.Text.Trim());

                con.Open();
                int exists = (int)cmd.ExecuteScalar(); // Get the count of matching customers
                con.Close();

                if (exists > 0)
                {
                    MessageBox.Show("Customer with this Name and Phone already exists!");
                    return;
                }

                if (!IsValidEmail(txtemail.Text))
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }

                qry = "insert into tbl_staff values ((select max(SF_id)+1 from tbl_staff),";
                qry += "'" + txtstaffname.Text + "',";
                qry += " " + txtphone.Text + ",";
                qry += "'" + txtemail.Text + "',";
                qry += " '" + txtaddress.Text + "',";
                qry += "'" + txtdate.Value.ToShortDateString() + "',";
                qry += " " + txtsalary.Text + ",";
                if (rdbmale.Checked)
                    qry += "'male')";
                else
                    qry += "'female')";
                c.conn_table(qry);
                MessageBox.Show("Inserted successfully");
                clear();
                this.Close();
            }
            catch (Exception e1)
            { MessageBox.Show("error" + e1.ToString()); }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
            this.Close();
        }

        private void txtstaffname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            qry = "update tbl_staff set ";
            qry += "SF_name='" + txtstaffname.Text + "',";
            qry += "SF_phone=" + txtphone.Text + ",";
            qry += "SF_email='" + txtemail.Text + "',";
            qry += "SF_Address='" + txtaddress.Text + "',";
            qry += "SF_jdate='" + txtdate.Value.ToShortDateString() + "',";

            qry += "SF_salary=" + txtsalary.Text + ",";
            if (rdbmale.Checked)
                    qry += "SF_gender='male' ";
                else
                    qry += "SF_gender='female' ";
            qry += "where SF_id=" + txtid.Text + "";
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("updated");
            this.Close();
        }
    }
}
