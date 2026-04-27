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
    public partial class frmproduct : Form
    {
       connectionclass c = new connectionclass();
        SqlConnection con;
        SqlCommand cmd;
        string qry = string.Empty;
        public frmproduct()
        {
            InitializeComponent();
        }
       
      
        private void btnsave_Click(object sender, EventArgs e)
        {
           
        }

        private void frmproduct_Load(object sender, EventArgs e)
        {
            
            bindmygrid();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }
        void bindmygrid()
        {
            //qry = "select * from tbl_Product";
            qry = "select ";
            qry += "c.SP_name,";
            qry += "p.PD_id,";
            qry += "p.PD_name,";
            qry += "p.PD_model,";
            qry += "b.b_name,";
            qry += "co.color_name,";

            qry += "p.PD_weight,";

            qry += "p.PD_warranty ";
            qry += "from tbl_product p,tbl_category c,tbl_color co,tbl_brand b ";
            qry += "where c.SP_id=p.PD_category and b.b_id=p.PD_brand and p.PD_color=co.color_id ";
            DataTable dt = new DataTable();
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvproduct.DataSource = dt;
        }
        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            frmproductadd product = new frmproductadd();
            product.ShowDialog();
            bindmygrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(dgvproduct.Rows[e.RowIndex].Cells["Column2"].Value);
                if (dgvproduct.Columns[e.ColumnIndex].HeaderText == "Update")
                {
                    frmproductadd pro = new frmproductadd();
                    pro = new frmproductadd(i);
                    pro.btnupdate.Enabled = true;
                    pro.btnupdate.Visible = true;

                    pro.btnsave.Enabled = false;
                    pro.btnsave.Visible = false;
   
                    pro.ShowDialog();
                    bindmygrid();
                }
                else if (dgvproduct.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    try
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this Product?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            qry = "delete from tbl_Product where PD_id=" + i + "";
                            c.conn_table(qry);
                            bindmygrid();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.ToString());
                    }

                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("error" + e1.ToString());
            }
        }
    }
}
