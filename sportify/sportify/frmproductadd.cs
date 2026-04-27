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
    public partial class frmproductadd : Form
    {
        connectionclass c = new connectionclass();
        SqlConnection con;
        SqlCommand cmd;
        string qry = string.Empty;
        int i;
        public frmproductadd()
        {
            InitializeComponent();
        }
        public frmproductadd(int i)
        {
            InitializeComponent();
            this.i = i;
            fillmycontrols();
        }

        private void frmproductadd_Load(object sender, EventArgs e)
        {
            loadcategory();
            loadcolor();
            loadbrand();
        }
        public void fillmycontrols()
        {
            qry = "select * from tbl_Product where PD_id=" + i + "";
            DataTable dt = new DataTable();
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            txtid.Text = i.ToString();
            cmbcategory.SelectedValue = dt.Rows[0][1].ToString();
            txtpname.Text = dt.Rows[0][2].ToString();
            txtpmodel.Text = dt.Rows[0][3].ToString();
            cmbbrand.SelectedValue = dt.Rows[0][4].ToString();
            cmbcolor.SelectedValue = dt.Rows[0][5].ToString();
            txtpweight.Text = dt.Rows[0][6].ToString();
            txtpwarranty.Text= dt.Rows[0][7].ToString();
        }
        public void loadcategory()
        {
            DataTable dt = new DataTable();
            qry = "select * from tbl_category";
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
        public void loadcolor()
        {
            DataTable dt = new DataTable();
            qry = "select * from tbl_Color";
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                cmbcolor.DataSource = null;
                cmbcolor.ValueMember = "color_id";
                cmbcolor.DisplayMember = "color_name";
                cmbcolor.DataSource = dt;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the product already exists
                qry = "select count(*) from tbl_product where PD_name = @name AND PD_model = @model";
                con = new SqlConnection(c.cnstr);
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", txtpname.Text);
                cmd.Parameters.AddWithValue("@model", txtpmodel.Text);

                con.Open();
                int exists = (int)cmd.ExecuteScalar();  // ExecuteScalar returns the first column of the first row

                if (exists > 0)
                {
                    MessageBox.Show("This product already exists!");
                    con.Close();
                    return;
                }
                con.Close();
                // Insert the new product
                qry = "insert into tbl_product values (";
                qry += "'" + cmbcategory.SelectedValue + "',";
                qry += "(select Max(PD_id) + 1 from tbl_product),";  // Handle case when table is empty
                qry += "'" + txtpname.Text + "',";
                qry += "'" + txtpmodel.Text + "',";
                qry += "'" + cmbbrand.SelectedValue + "',";
                qry += "'" + cmbcolor.SelectedValue + "',";
                qry += "'" + txtpweight.Text + "',";
                qry += "'" + txtpwarranty.Text + "')";

                con.Open();
                cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Product inserted successfully!");
                this.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error: " + e1.ToString());
            }

        }
        public void clearcontrols()
        {
            txtpname.Clear();
            txtpmodel.Clear();
            cmbbrand.SelectedValue = false;
            txtpweight.Clear();
            txtpwarranty.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadbrand()
        {
            DataTable dt = new DataTable();
            qry = "select * from tbl_brand";
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                cmbbrand.DataSource = null;
                cmbbrand.ValueMember = "b_id";
                cmbbrand.DisplayMember = "b_name";
                cmbbrand.DataSource = dt;
            }
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            qry = "select count(*) from tbl_customization where category = @category and name = @name and id != @id";
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@category", cmbcategory.SelectedValue.ToString().Trim());
            cmd.Parameters.AddWithValue("@name", txtpname.Text.Trim());
            cmd.Parameters.AddWithValue("@id", txtid.Text.Trim());

            con.Open();
            int exists = (int)cmd.ExecuteScalar(); // Check if there are duplicates
            con.Close();

            if (exists > 0)
            {
                MessageBox.Show("A customization with the same category and name already exists!");
                return;
            }

            qry = "update tbl_product set ";
            qry += "PD_category='" + cmbcategory.SelectedValue + "',";
            qry += "PD_name='" + txtpname.Text + "',";
            qry += "PD_model='" + txtpmodel.Text + "',";
            qry += "PD_brand='" + cmbbrand.SelectedValue + "',";
            qry += "PD_color='" + cmbcolor.SelectedValue + "',";
            qry += "PD_weight=" + txtpweight.Text + ",";
            qry += "PD_warranty=" + txtpwarranty.Text + " ";
            qry += "where PD_id=" + txtid.Text + " ";
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("updated");
            this.Close();
        }

        private void txtpname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtpqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtpcp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtpsp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtpweight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtpwarranty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
