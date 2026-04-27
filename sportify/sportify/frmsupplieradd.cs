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

    public partial class frmsupplieradd : Form
    {
        connectionclass c = new connectionclass();
        SqlConnection con;
        SqlCommand cmd;
        string qry = string.Empty;
        int i;
        public frmsupplieradd()
        {
            InitializeComponent();
        }
        public frmsupplieradd(int i)
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
                if (!IsValidEmail(txtsemail.Text))
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }

                con = new SqlConnection(c.cnstr);

                // Check if supplier with the same email or name already exists
                qry = "SELECT COUNT(*) FROM tbl_Supplier WHERE S_mail = @Email OR S_name = @Name";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Email", txtsemail.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", txtsname.Text.Trim());

                con.Open();
                int count = (int)cmd.ExecuteScalar();
                con.Close();

                if (count > 0)
                {
                    MessageBox.Show("A supplier with this name or email already exists.");
                    return;
                }

                // Proceed with the insertion
                qry = "INSERT INTO tbl_Supplier (S_id, S_name, S_phone, S_mail, S_address, S_gender) VALUES ";
                qry += "((SELECT MAX(S_id) + 1 FROM tbl_Supplier), @Name, @Phone, @Email, @Address, @Gender)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Name", txtsname.Text.Trim());
                cmd.Parameters.AddWithValue("@Phone", txtsphone.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txtsemail.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", rtbsaddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Gender", rdbmale.Checked ? "male" : "female");

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Inserted successfully");
                clearcontrols();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            // try
            //{

            //    if (!IsValidEmail(txtsemail.Text))
            //    {
            //        MessageBox.Show("Please enter a valid email address.");
            //        return;
            //    }
               
            //    con = new SqlConnection(c.cnstr);
            //    qry = "insert into tbl_Supplier values ((select Max(S_id)+1 from tbl_supplier),";
            //    qry += "'" + txtsname.Text + "',";
            //    qry += " " + txtsphone.Text + ",";
            //    qry += "'" + txtsemail.Text + "',";
            //    qry += " '" + rtbsaddress.Text + "',";
            //    if (rdbmale.Checked)
            //        qry += "'male'";
            //    else
            //        qry += "'female'";
            //    qry += ")";
            //    c.conn_table(qry);
            //    MessageBox.Show("Inserted");
            //    clearcontrols();
            //    this.Close();
            //}
            // catch (Exception e1)
            // {
            //     MessageBox.Show("error" + e1.ToString());
            // }
        }
        public void clearcontrols()
        {
            txtsname.Clear();
            txtsphone.Clear();
            txtsemail.Clear();
            rtbsaddress.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearcontrols();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void fillmycontrols()
        {
            qry = "select * from tbl_Supplier where S_id=" + i + "";
            DataTable dt = new DataTable();
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            txtid.Text = i.ToString();
            txtsname.Text = dt.Rows[0][1].ToString();
            txtsphone.Text = dt.Rows[0][2].ToString();
            txtsemail.Text = dt.Rows[0][3].ToString();
            rtbsaddress.Text = dt.Rows[0][4].ToString();
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
                if (!IsValidEmail(txtsemail.Text))
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }

                // Check if supplier with the same email or name exists (but ignore the current record)
                qry = "SELECT COUNT(*) FROM tbl_Supplier WHERE (S_mail = @Email OR S_name = @Name) AND S_id != @Id";
                con = new SqlConnection(c.cnstr);
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Email", txtsemail.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", txtsname.Text.Trim());
                cmd.Parameters.AddWithValue("@Id", txtid.Text.Trim());

                con.Open();
                int count = (int)cmd.ExecuteScalar();
                con.Close();

                if (count > 0)
                {
                    MessageBox.Show("A supplier with this name or email already exists.");
                    return;
                }

                // Proceed with the update
                qry = "UPDATE tbl_Supplier SET S_name = @Name, S_phone = @Phone, S_mail = @Email, S_address = @Address, S_gender = @Gender WHERE S_id = @Id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Name", txtsname.Text.Trim());
                cmd.Parameters.AddWithValue("@Phone", txtsphone.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txtsemail.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", rtbsaddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Gender", rdbmale.Checked ? "male" : "female");
                cmd.Parameters.AddWithValue("@Id", txtid.Text.Trim());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Supplier updated successfully!");
                this.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error: " + e1.Message);
            }

            //try
            //{
            //    //MessageBox.Show(n);
            //    //MessageBox.Show(x.ToString()+""+y.ToString());
            //    qry = "update tbl_Supplier set S_name='" + txtsname.Text + "',";
            //    qry += "S_phone=" + txtsphone.Text + ",";
            //    qry += "S_mail='" + txtsemail.Text + "',";
            //    qry += "S_address='" + rtbsaddress.Text + "',";
            //    if (rdbmale.Checked)
            //        qry += "S_gender='male' ";
            //    else
            //        qry += "S_gender='female' ";
            //    qry += "where S_id=" + txtid.Text + "";
            //    //c.conn_table(qry);
            //    con = new SqlConnection(c.cnstr);
            //    cmd = new SqlCommand(qry, con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    MessageBox.Show("updated");
            //    this.Close();

            //}
            //catch (Exception e1)
            //{
            //    MessageBox.Show("error:" + e1.ToString());
            //}
        }

        private void frmsupplieradd_Load(object sender, EventArgs e)
        {

        }

        private void txtsphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtsname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsave_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
