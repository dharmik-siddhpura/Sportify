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
    public partial class frmtax : Form
    {
        connectionclass c = new connectionclass();
        SqlConnection con;
        SqlCommand cmd;
        string qry = string.Empty;
        public frmtax()
        {
            InitializeComponent();
        }
        public void bindmygrid()
        {
            qry = "select * from tbl_tax";
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
                // Check for existing tax name
                con = new SqlConnection(c.cnstr);
                qry = "SELECT COUNT(*) FROM tbl_Tax WHERE Tax = @TaxName";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@TaxName", txttaxname.Text.Trim());

                con.Open();
                int count = (int)cmd.ExecuteScalar();
                con.Close();

                if (count > 0)
                {
                    MessageBox.Show("A tax entry with this name already exists.");
                    return; // Exit the method to prevent insertion
                }

                // Proceed with the insertion if no duplicates are found
                qry = "INSERT INTO tbl_Tax (Tax) VALUES (@TaxName)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@TaxName", txttaxname.Text.Trim());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Inserted successfully.");
                txttaxname.Clear();
                txttaxname.Focus();
                bindmygrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //try
            //{
            //    qry = "insert into tbl_Tax values ('" + txttaxname.Text + "')";
            //    c.conn_table(qry);
            //    MessageBox.Show("Inserted");
            //    txttaxname.Clear();
            //    txttaxname.Focus();
            //    bindmygrid();
            //}
            //catch
            //{
            //    MessageBox.Show("error");
            //}
        }

        private void frmtax_Load(object sender, EventArgs e)
        {
            bindmygrid();
        }

        public void fillmycontrol(int index)
        {
                txttaxname.Text = dgrid.Rows[index].Cells[0].Value.ToString();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txttaxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this Tax?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                qry = "delete from tbl_Tax where Tax='" + txttaxname.Text + "'";
                c.conn_table(qry);
                bindmygrid();
                txttaxname.Clear();
            }
        }

        private void dgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString());
            fillmycontrol(e.RowIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txttaxname.Clear();
        }

        private void txttaxname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
