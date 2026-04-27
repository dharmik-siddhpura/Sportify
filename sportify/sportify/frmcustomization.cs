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
    public partial class frmcustomization : Form
    {
        connectionclass c = new connectionclass();
        SqlConnection con;
        SqlCommand cmd;
        string qry = string.Empty;
        public frmcustomization()
        {
            InitializeComponent();

        }
        public void bindmygrid()
        {
          //  qry = "select * from tbl_customization";
            qry = "select ";
            qry += "cu.id,";
            qry += " c.SP_name,";
            qry += "cu.name,";
            qry += "cu.details,";
            qry += "cu.qty,";
            qry += "cu.price,";
            qry += "cu.tax,";
            qry += "cu.discount,";
            qry += "cu.total ";
            qry += "from tbl_customization cu,tbl_category c";
            qry += " where SP_id=cu.Category";
            DataTable dt = new DataTable();
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            frmcustomizationadd fca = new frmcustomizationadd();
            fca.ShowDialog();
            bindmygrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["Column1"].Value);

                if (dgv.Columns[e.ColumnIndex].HeaderText == "Update")
                {
                    frmcustomizationadd cust = new frmcustomizationadd();
                    cust = new frmcustomizationadd(i);
                    cust.btnupdate.Enabled = true;
                    cust.btnupdate.Visible = true;

                    cust.btnsave.Enabled = false;
                    cust.btnsave.Visible = false;

                    cust.ShowDialog();
                    bindmygrid();


                }
                else if (dgv.Columns[e.ColumnIndex].HeaderText == "Delete")
                {

                    try
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this Customization order?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            qry = "delete from tbl_Customization where id=" + i + "";
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
                MessageBox.Show(e1.ToString());
            }
        }

        private void frmcustomization_Load(object sender, EventArgs e)
        {
            bindmygrid();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
