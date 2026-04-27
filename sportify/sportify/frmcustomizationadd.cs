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
namespace sportify
{
    public partial class frmcustomizationadd : Form
    {
        connectionclass c = new connectionclass();
        SqlConnection con;
        SqlCommand cmd;
        string qry = string.Empty;
        int i;
        public frmcustomizationadd()
        {
            InitializeComponent();
        }
        public frmcustomizationadd(int i)
        {
            InitializeComponent();
            this.i = i;
            fillmycontrols();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void fillmycontrols()
        {
            try
            {
                qry = "select * from tbl_Customization where id=" + i + "";
                DataTable dt = new DataTable();
                con = new SqlConnection(c.cnstr);
                cmd = new SqlCommand(qry, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                txtid.Text = i.ToString();
                cmbcategory.SelectedValue = dt.Rows[0][1].ToString();
                txtname.Text = dt.Rows[0][2].ToString();
                rtb.Text = dt.Rows[0][3].ToString();
                txtqty.Text = dt.Rows[0][4].ToString();
                txtprice.Text = dt.Rows[0][5].ToString();
                cmbtax.SelectedValue = dt.Rows[0][6].ToString();
                cmbdiscount.SelectedValue = dt.Rows[0][7].ToString();
                txttp.Text = dt.Rows[0][8].ToString();
            }

            catch (Exception e1)
            {
                MessageBox.Show("error" + e1.ToString());
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the customization with the same category and name already exists
                qry = "select count(*) from tbl_customization where category = @category and name = @name";
                con = new SqlConnection(c.cnstr);
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@category", cmbcategory.SelectedValue.ToString().Trim());
                cmd.Parameters.AddWithValue("@name", txtname.Text.Trim());

                con.Open();
                int exists = (int)cmd.ExecuteScalar(); // Get the count of matching records
                con.Close();

                if (exists > 0)
                {
                    MessageBox.Show("Customization with the same category and name already exists!");
                    return;
                }
                 if (txtname.Text.Trim() != null && rtb.Text.Trim() != null && txtqty.Text.Trim() != null && txtprice.Text.Trim() != null)
                // Calculate total price (tp)
                 {
                    int quantity = int.Parse(txtqty.Text);
                    decimal price = decimal.Parse(txtprice.Text);
                    decimal tax = decimal.Parse(cmbtax.SelectedValue.ToString()) / 100;
                    decimal discount = decimal.Parse(cmbdiscount.SelectedValue.ToString()) / 100;
                    decimal discountAmount = price * discount;
                    decimal totalPrice = quantity * price * (1 + tax) - discountAmount;
                    txttp.Text = totalPrice.ToString();
               
                // Insert the new record
                
                    qry = "insert into tbl_customization values((select max(id)+1 from tbl_customization),";
                    qry += "'" + cmbcategory.SelectedValue + "',";
                    qry += "'" + txtname.Text.Trim() + "',";
                    qry += "'" + rtb.Text.Trim() + "',";
                    qry += "'" + txtqty.Text.Trim() + "',";
                    qry += "'" + txtprice.Text.Trim() + "',";
                    qry += "'" + cmbtax.SelectedValue + "',";
                    qry += "'" + cmbdiscount.SelectedValue + "',";
                    qry += "'" + txttp.Text.Trim() + "')";
                    c.conn_table(qry);

                    MessageBox.Show("Inserted successfully");
                    this.Close();
                }
                else
                    MessageBox.Show("enter all valid data");
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error: " + e1.ToString());
            }

            //try
            //{
            //    int quantity = int.Parse(txtqty.Text);
            //    decimal p = decimal.Parse(txtprice.Text);
            //    decimal tax = decimal.Parse(cmbtax.SelectedValue.ToString()) / 100;
            //    decimal dis = decimal.Parse(cmbdiscount.SelectedValue.ToString())/100;
            //    decimal d = p * dis;
            //    decimal tp = quantity * p * (1 + tax)-d;
            //    txttp.Text = tp.ToString();

            //    qry = "insert into tbl_customization values((select max(id)+1 from tbl_customization),";
            //    qry += "'" + cmbcategory.SelectedValue + "',";
            //    qry += "'" + txtname.Text.Trim() + "',";
            //    qry += "'" + rtb.Text.Trim() + "',";
            //    qry += "'" + txtqty.Text.Trim() + "',";
            //    qry += "'" + txtprice.Text.Trim() + "',";
            //    qry += "'" + cmbtax.SelectedValue + "',";
            //    qry += "'" + cmbdiscount.SelectedValue + "',";
            //    qry += "'" + txttp.Text.Trim() + "')";
            //    c.conn_table(qry);
            //    MessageBox.Show("inserted");
            //    this.Close();
            //}
            //catch (Exception e1)
            //{
            //    MessageBox.Show("error" + e1.ToString());
            //}
        }
        public void loadtax()
        {
            DataTable dt = new DataTable();
            qry = "select Tax from tbl_Tax";
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                cmbtax.DataSource = null;
                cmbtax.ValueMember = "Tax";
                cmbtax.DisplayMember = "Tax";
                cmbtax.DataSource = dt;
            }
        }
        public void loadcategory()
        {
            DataTable dt = new DataTable();
            qry = "select SP_id,SP_name from tbl_category";
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                cmbcategory.DataSource = null;
                cmbcategory.ValueMember = "SP_id";
                cmbcategory.DisplayMember = "SP_name";
                cmbcategory.DataSource = dt;
            }
        }
        public void loaddiscount()
        {
            DataTable dt = new DataTable();
            qry = "select discount from tbl_discount";
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                cmbdiscount.DataSource = null;
                cmbdiscount.ValueMember = "discount";
                cmbdiscount.DisplayMember = "discount";
                cmbdiscount.DataSource = dt;
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmcustomizationadd_Load(object sender, EventArgs e)
        {
            loadcategory();
            loadtax();
            loaddiscount();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate if a customization with the same category and name exists, excluding the current record
                qry = "select count(*) from tbl_customization where category = @category and name = @name and id != @id";
                con = new SqlConnection(c.cnstr);
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@category", cmbcategory.SelectedValue.ToString().Trim());
                cmd.Parameters.AddWithValue("@name", txtname.Text.Trim());
                cmd.Parameters.AddWithValue("@id", txtid.Text); // Exclude current record

                con.Open();
                int exists = (int)cmd.ExecuteScalar(); // Check for duplicates
                con.Close();

                if (exists > 0)
                {
                    MessageBox.Show("A customization with this category and name already exists!");
                    return;
                }

                // If no duplicates, calculate the total price
                int quantity = int.Parse(txtqty.Text);
                decimal price = decimal.Parse(txtprice.Text);
                decimal tax = decimal.Parse(cmbtax.SelectedValue.ToString()) / 100;
                decimal discount = decimal.Parse(cmbdiscount.SelectedValue.ToString()) / 100;
                decimal discountAmount = price * discount;
                decimal totalPrice = quantity * price * (1 + tax) - discountAmount;
                txttp.Text = totalPrice.ToString();

                // Proceed with the update query
                qry = "update tbl_customization set category = @category, name = @name, details = @details, qty = @qty, price = @price, tax = @tax, discount = @discount, total = @total where id = @id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@category", cmbcategory.SelectedValue.ToString().Trim());
                cmd.Parameters.AddWithValue("@name", txtname.Text.Trim());
                cmd.Parameters.AddWithValue("@details", rtb.Text.Trim());
                cmd.Parameters.AddWithValue("@qty", txtqty.Text.Trim());
                cmd.Parameters.AddWithValue("@price", txtprice.Text.Trim());
                cmd.Parameters.AddWithValue("@tax", cmbtax.SelectedValue.ToString().Trim());
                cmd.Parameters.AddWithValue("@discount", cmbdiscount.SelectedValue.ToString().Trim());
                cmd.Parameters.AddWithValue("@total", txttp.Text.Trim());
                cmd.Parameters.AddWithValue("@id", txtid.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Customization updated successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //try
            //{
            //    int quantity = int.Parse(txtqty.Text);
            //    decimal p = decimal.Parse(txtprice.Text);
            //    decimal tax = decimal.Parse(cmbtax.SelectedValue.ToString()) / 100;
            //    decimal dis = decimal.Parse(cmbdiscount.SelectedValue.ToString())/100;
            //    decimal d = p * dis;
            //    decimal tp = quantity * p * (1 + tax)-d;
            //    txttp.Text = tp.ToString();
            //    qry = "update tbl_Customization set category='"+cmbcategory.SelectedValue+"',";
            //    qry+="name='" + txtname.Text + "',";
            //    qry += "details='" + rtb.Text + "',";
            //    qry += "qty='" + txtqty.Text + "',";
            //    qry += "price='" + txtprice.Text + "',";
            //    qry+="tax='"+cmbtax.SelectedValue+"',";
            //    qry+="discount='"+cmbdiscount.SelectedValue+"',";
            //    qry+="total="+txttp.Text+" ";
            //    qry += "where id=" + txtid.Text + "";
            //    //c.conn_table(qry);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        }
    }

