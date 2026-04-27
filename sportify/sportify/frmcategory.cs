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
    public partial class frmcategory : Form
    {
        connectionclass c = new connectionclass();
        SqlConnection con;
        SqlCommand cmd;
        string qry = string.Empty;
        public frmcategory()
        {
            InitializeComponent();
        }
        public void bindmygrid()
        {
            qry = "select * from tbl_Category";
            DataTable dt = new DataTable();
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgrid.DataSource = dt;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void frmcategory_Load(object sender, EventArgs e)
        {
            bindmygrid();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            
        }
        public void fillmycontrol(int index)
        {
            txtcatname.Text = dgrid.Rows[index].Cells[1].Value.ToString();
        }
        private void btndelete_Click_1(object sender, EventArgs e)
        {
          
        }

        private void dgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
         
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {

        }

        private void btndelete_Click_2(object sender, EventArgs e)
        {

            

        }

        private void txtcatname_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Check if the category already exists
                qry = "select count(*) from tbl_Category where SP_name = @category_name";
                con = new SqlConnection(c.cnstr);
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@category_name", txtcatname.Text.Trim());

                con.Open();
                int exists = (int)cmd.ExecuteScalar(); // Returns the number of rows that match the category name

                if (exists > 0)
                {
                    MessageBox.Show("This category already exists!");
                    con.Close();
                    return;
                }
                con.Close();

                // Insert the new category
                qry = "insert into tbl_Category values ((select isnull(max(SP_id), 0) + 1 from tbl_Category), @category_name)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@category_name", txtcatname.Text.Trim());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Category inserted successfully!");
                txtcatname.Clear();
                txtcatname.Focus();
                bindmygrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //try
            //{
            //    qry = "insert into tbl_Category values ((select Max(SP_id)+1 from tbl_Category),'" + txtcatname.Text + "')";
            //    c.conn_table(qry);
            //    MessageBox.Show("Inserted");
            //    txtcatname.Clear();
            //    txtcatname.Focus();
            //    bindmygrid();
            //}
            //catch
            //{
            //    MessageBox.Show("error");
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                qry = "delete from tbl_Category where SP_name='" + txtcatname.Text + "'";
                c.conn_table(qry);
                bindmygrid();
                txtcatname.Clear();
            }
        }

        private void dgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillmycontrol(e.RowIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcatname.Clear();
        }

        private void txtcatname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
