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
    public partial class frmbrand : Form
    {
        connectionclass c = new connectionclass();
        SqlConnection con;
        SqlCommand cmd;
        string qry = string.Empty;

        public frmbrand()
        {
            InitializeComponent();
        }

        public void fillmycontrol(int index)
        {
            txtbrandname.Text = dgrid.Rows[index].Cells[1].Value.ToString();
        }

        public void bindmygrid()
        {
            qry = "select * from tbl_brand";
            DataTable dt = new DataTable();
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgrid.DataSource = dt;
        }

        private void frmbrand_Load(object sender, EventArgs e)
        {
            bindmygrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the brand already exists
                qry = "select count(*) from tbl_brand where b_name = @brandname";
                con = new SqlConnection(c.cnstr);
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@brandname", txtbrandname.Text);

                con.Open();
                int exists = (int)cmd.ExecuteScalar(); // ExecuteScalar returns the first column of the first row

                if (exists > 0)
                {
                    MessageBox.Show("This brand already exists!");
                    con.Close();
                    return;
                }
                con.Close();

                // Insert new brand
                qry = "insert into tbl_brand values ((select isnull(max(b_id), 0) + 1 from tbl_brand), @brandname)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@brandname", txtbrandname.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Brand inserted successfully!");
                txtbrandname.Clear();
                txtbrandname.Focus();
                bindmygrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //try
            //{
            //    qry = "insert into tbl_brand values ((select max(b_id)+1 from tbl_brand),'" + txtbrandname.Text + "')";
            //    c.conn_table(qry);
            //    MessageBox.Show("Inserted");
            //    txtbrandname.Clear();
            //    txtbrandname.Focus();
            //    bindmygrid();
            //}
            //catch
            //{
            //    MessageBox.Show("error");
            //}
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this brand?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Perform the deletion
                qry = "delete from tbl_brand where b_name='" + txtbrandname.Text + "'";
                con = new SqlConnection(c.cnstr);
                cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    bindmygrid();
                    txtbrandname.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            //qry = "delete from tbl_brand where b_name='" + txtbrandname.Text + "'";
            //c.conn_table(qry);
            //MessageBox.Show("deleted");
            //bindmygrid();
            //txtbrandname.Clear();
        }

        private void dgrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            fillmycontrol(e.RowIndex);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtbrandname.Clear();
        }

        private void txtbrandname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbrandname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
