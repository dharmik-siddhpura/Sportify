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
    public partial class frmdiscount : Form
    {
        connectionclass c = new connectionclass();
        SqlConnection con;
        SqlCommand cmd;
        string qry = string.Empty;
        public frmdiscount()
        {
            InitializeComponent();
        }
        public void bindmygrid()
        {
            qry = "select * from tbl_discount";
            DataTable dt = new DataTable();
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgrid.DataSource = dt;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the discount already exists
                qry = "select count(*) from tbl_discount where discount = @discount";
                con = new SqlConnection(c.cnstr);
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@discount", txtdiscountname.Text.Trim());

                con.Open();
                int exists = (int)cmd.ExecuteScalar(); // Get the count of matching records
                con.Close();

                if (exists > 0)
                {
                    MessageBox.Show("This discount already exists!");
                    return;
                }

                // If no duplicate exists, insert the new discount
                qry = "insert into tbl_discount (discount) values (@discount)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@discount", txtdiscountname.Text.Trim());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Inserted successfully");
                txtdiscountname.Clear();
                txtdiscountname.Focus();
                bindmygrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //try
            //{
            //    qry = "insert into tbl_discount values ('" + txtdiscountname.Text + "')";
            //    c.conn_table(qry);
            //    MessageBox.Show("Inserted");
            //    txtdiscountname.Clear();
            //    txtdiscountname.Focus();
            //    bindmygrid();
            //}
            //catch
            //{
            //    MessageBox.Show("error");
            //}
        }

        private void txttaxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmdiscount_Load(object sender, EventArgs e)
        {
            bindmygrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtdiscountname.Clear();
        }

        private void dgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void fillmycontrol(int index)
        {
            MessageBox.Show(index.ToString());
            txtdiscountname.Text = dgrid.Rows[index].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this Discount?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                    qry = "delete from tbl_discount where discount='" + txtdiscountname.Text + "'";
                    c.conn_table(qry);
                    bindmygrid();
            }
        }

        private void dgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillmycontrol(e.RowIndex);
        }

        private void txtdiscountname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
