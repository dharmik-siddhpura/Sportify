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
    public partial class frmcustomeradd : Form
    {
        connectionclass c = new connectionclass();
        SqlConnection con;
        SqlCommand cmd;
        string qry = string.Empty;
        int i;

        public frmcustomeradd()
        {
            InitializeComponent();

        }

        public frmcustomeradd(int i)
        {
            InitializeComponent();
            this.i = i;
            fillmycontrols();
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
              
                    // Validate the email format
                    if (!IsValidEmail(txtcemail.Text))
                    {
                        MessageBox.Show("Please enter a valid email address.");
                        return;
                    }

                    // Check if the customer already exists (based on phone number or email)
                    qry = "select count(*) from tbl_Customer where C_phone = @C_phone OR C_mail = @C_mail";
                    con = new SqlConnection(c.cnstr);
                    cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@C_phone", txtcphone.Text.Trim());
                    cmd.Parameters.AddWithValue("@C_mail", txtcemail.Text.Trim());

                    con.Open();
                    int exists = (int)cmd.ExecuteScalar(); // Get the count of matching customers
                    con.Close();

                    if (exists > 0)
                    {
                        MessageBox.Show("Customer with this phone number or email already exists!");
                        return;
                    }

                    // If the customer doesn't exist, insert the new record
                    qry = "insert into tbl_Customer values ((select max(C_id)+1 from tbl_Customer),";
                    qry += "'" + txtcname.Text + "',";
                    qry += " " + txtcphone.Text + ",";
                    qry += "'" + txtcemail.Text + "',";
                    qry += " '" + rtbcaddress.Text + "',";
                    if (rdbmale.Checked)
                        qry += "'male')";
                    else
                        qry += "'female')";

                    c.conn_table(qry);
                    MessageBox.Show("Inserted successfully");
                    this.Close();
                }
               
            
            catch (Exception e1)
            {
                MessageBox.Show("Error: " + e1.ToString());
            }

            //try
            //{

            //    if (!IsValidEmail(txtcemail.Text))
            //    {
            //        MessageBox.Show("Please enter a valid email address.");
            //        return;
            //    }

            //    qry = "insert into tbl_Customer values ((select max(C_id)+1 from tbl_Customer),";
            //    qry += "'" + txtcname.Text + "',";
            //    qry += " " + txtcphone.Text + ",";
            //    qry += "'" + txtcemail.Text + "',";
            //    qry += " '" + rtbcaddress.Text + "',";
            //    if (rdbmale.Checked)
            //        qry += "'male'";
            //    else
            //        qry += "'female'";
            //    qry += ")";
            //    c.conn_table(qry);
            //    MessageBox.Show("Inserted");
            //    this.Close();
            //}
            //catch (Exception e1)
            //{
            //    MessageBox.Show("error" + e1.ToString());
            //}
        }
        public void clearcontrols()
        {
            txtcname.Clear();
            txtcphone.Clear();
            txtcemail.Clear();
            rtbcaddress.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearcontrols();
        }
        public void updatedata(int i)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void fillmycontrols()
        {
            qry = "select * from tbl_Customer where C_id=" + i + "";
            DataTable dt = new DataTable();
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            txtid.Text=i.ToString();           
            txtcname.Text = dt.Rows[0][1].ToString();
            txtcphone.Text = dt.Rows[0][2].ToString();
            txtcemail.Text = dt.Rows[0][3].ToString();
            rtbcaddress.Text = dt.Rows[0][4].ToString();
            if (dt.Rows[0][5].ToString() == "male")
                rdbmale.Checked = true;
            else
                rdbfemale.Checked = true;
         
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate the email format
                if (!IsValidEmail(txtcemail.Text))
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }

                // Check if the phone number or email already exists in another customer record
                qry = "select count(*) from tbl_Customer where (C_phone = @C_phone OR C_mail = @C_mail) AND C_id != @C_id";
                con = new SqlConnection(c.cnstr);
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@C_phone", txtcphone.Text.Trim());
                cmd.Parameters.AddWithValue("@C_mail", txtcemail.Text.Trim());
                cmd.Parameters.AddWithValue("@C_id", txtid.Text);  // Current customer ID

                con.Open();
                int exists = (int)cmd.ExecuteScalar();  // Get the count of matching customers
                con.Close();

                if (exists > 0)
                {
                    MessageBox.Show("Another customer with this phone number or email already exists!");
                    return;
                }

                // Proceed with the update if no duplicates found
                qry = "update tbl_Customer set C_name = @C_name, C_phone = @C_phone, C_mail = @C_mail, C_address = @C_address, C_gender = @C_gender where C_id = @C_id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@C_name", txtcname.Text.Trim());
                cmd.Parameters.AddWithValue("@C_phone", txtcphone.Text.Trim());
                cmd.Parameters.AddWithValue("@C_mail", txtcemail.Text.Trim());
                cmd.Parameters.AddWithValue("@C_address", rtbcaddress.Text.Trim());
                cmd.Parameters.AddWithValue("@C_gender", rdbmale.Checked ? "male" : "female");
                cmd.Parameters.AddWithValue("@C_id", txtid.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Customer updated successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //try
            //{
            //    if (!IsValidEmail(txtcemail.Text))
            //    {
            //        MessageBox.Show("Enter Valid Email");
            //        return;
            //    }

            //    qry = "update tbl_Customer set C_name='" + txtcname.Text + "',";
            //    qry += "C_phone=" + txtcphone.Text + ",";
            //    qry += "C_mail='" + txtcemail.Text + "',";
            //    qry += "C_address='" + rtbcaddress.Text + "',";
            //    if (rdbmale.Checked)
            //        qry += "C_gender='male' ";
            //    else
            //        qry += "C_gender='female' ";
            //    qry += "where C_id=" + txtid.Text + "";
            //    con = new SqlConnection(c.cnstr);
            //    cmd = new SqlCommand(qry,con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    MessageBox.Show("updated");
            //    this.Close();
            
            //}
            //catch(Exception e1)
            //{
            //    MessageBox.Show("error:"+e1.ToString());
            //}
        }

        private void frmcustomeradd_Load(object sender, EventArgs e)
        {

        }

        private void txtcemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtcname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        }
    }

