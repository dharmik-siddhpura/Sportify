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
    public partial class frmpurchase : Form
    {
        connectionclass c = new connectionclass();
        SqlConnection con;
        SqlCommand cmd;
        string qry = string.Empty;
        public frmpurchase()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            frmpurchaseadd add = new frmpurchaseadd();
            add.ShowDialog();
            bindmygrid();
        }
        public void bindmygrid()
        {
            qry = "select * from tbl_purchase order by PU_date DESC";
            DataTable dt = new DataTable();
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvpurchase.DataSource = dt;
        }
        private void dgvcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(dgvpurchase.Rows[e.RowIndex].Cells["Column1"].Value);

                if (dgvpurchase.Columns[e.ColumnIndex].HeaderText == "View")
                {
                    //MessageBox.Show(i.ToString());
                    frmpurchaseview p = new frmpurchaseview();
                    p = new frmpurchaseview(i);
                    p.Show();
                }
                else if (dgvpurchase.Columns[e.ColumnIndex].HeaderText == "Delete")
                //MessageBox.Show(i.ToString());
                {
                    qry = "delete from tbl_purchase where PU_Id=" + i + "";
                    c.conn_table(qry);
                    qry = "delete from tbl_purchase_details where PU_Id=" + i + "";
                    c.conn_table(qry);
                    MessageBox.Show("deleted");
                }

            }
            catch (Exception e1)
            {
                MessageBox.Show("error" + e1.ToString());
            }
            
        }
    
        private void frmpurchase_Load(object sender, EventArgs e)
        {
            bindmygrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvpurchase_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
