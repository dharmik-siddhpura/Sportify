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
    public partial class frmpaymentmethod : Form
    {
        connectionclass c = new connectionclass();
        SqlConnection con;
        SqlCommand cmd;
        string qry = string.Empty;
        public frmpaymentmethod()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void fillmycontrol(int index)
        {
            txtpaymentmethod.Text = dgrid.Rows[index].Cells[1].Value.ToString();
        }
      
              public void bindmygrid()
        {
            qry = "select * from tbl_paymentmethod";
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
                // Check if the payment method already exists
                qry = "select count(*) from tbl_paymentmethod where p_name = @pname";
                con = new SqlConnection(c.cnstr);
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@pname", txtpaymentmethod.Text.Trim());

                con.Open();
                int exists = (int)cmd.ExecuteScalar(); // Get the count of matching records
                con.Close();

                if (exists > 0)
                {
                    MessageBox.Show("This payment method already exists!");
                    return;
                }

                // If no duplicate exists, insert the new payment method
                qry = "insert into tbl_paymentmethod (p_id,p_name) values ((select max(p_id)+1 from tbl_paymentmethod),@pname)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@pname", txtpaymentmethod.Text.Trim());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Inserted successfully");
                txtpaymentmethod.Clear();
                txtpaymentmethod.Focus();
                bindmygrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //try
            //{
            //    qry = "insert into tbl_paymentmethod values ((select max(p_id)+1 from tbl_paymentmethod),'" + txtpaymentmethod.Text + "')";
            //    c.conn_table(qry);
            //    MessageBox.Show("Inserted");
            //    txtpaymentmethod.Clear();
            //    txtpaymentmethod.Focus();
            //    bindmygrid();
            //}
            //catch
            //{
            //    MessageBox.Show("error");
            //}
        }

        private void frmpaymentmethod_Load(object sender, EventArgs e)
        {
            bindmygrid();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this Payment Method?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                qry = "delete from tbl_paymentmethod where p_name='" + txtpaymentmethod.Text + "'";
                c.conn_table(qry);
                bindmygrid();
            }
        }

        private void dgrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillmycontrol(e.RowIndex);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtpaymentmethod.Clear();
        }

        private void txtpaymentmethod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
