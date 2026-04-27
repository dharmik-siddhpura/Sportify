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
    public partial class frmsupplier : Form
    {
        connectionclass c = new connectionclass();
        SqlConnection con;
        SqlCommand cmd;
        string qry = string.Empty;
        public frmsupplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        public void bindmygrid()
        {
            qry = "select * from tbl_Supplier";
            DataTable dt = new DataTable();
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvsupplier.DataSource = dt;
        }
        private void frmsupplier_Load(object sender, EventArgs e)
        {
            
            bindmygrid();
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
            
        }
        public void fillmycontrols(int index)
        {
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void dgvsupplier_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            fillmycontrols(e.RowIndex);
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            frmsupplieradd supplier = new frmsupplieradd();
            supplier.ShowDialog();
            bindmygrid();
        }

        private void dgvsupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(dgvsupplier.Rows[e.RowIndex].Cells["Column6"].Value);
                if (dgvsupplier.Columns[e.ColumnIndex].HeaderText == "Update")
                {
                    frmsupplieradd sup = new frmsupplieradd();
                    sup = new frmsupplieradd(i);
                    sup.btnupdate.Enabled = true;
                    sup.btnupdate.Visible = true;

                    sup.btnsave.Enabled = false;
                    sup.btnsave.Visible = false;

                    sup.ShowDialog();
                    bindmygrid();
                 

                }
                else if (dgvsupplier.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    i = Convert.ToInt32(dgvsupplier.Rows[e.RowIndex].Cells["Column6"].Value);
                    try
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this Supplier?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            qry = "delete from tbl_Supplier where S_id=" + i + "";
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
       

    }
}
