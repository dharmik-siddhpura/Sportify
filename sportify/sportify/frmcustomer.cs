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
    public partial class frmcustomer : Form
    {
        connectionclass c = new connectionclass();
        SqlConnection con;
        SqlCommand cmd;
        string qry = string.Empty;
        public frmcustomer()
        {
            InitializeComponent();
        }
        public void bindmygrid()
        {
            qry = "select * from tbl_Customer";
            DataTable dt = new DataTable();
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvcustomer.DataSource = dt;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void frmcustomer_Load(object sender, EventArgs e)
        {
           
            bindmygrid();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            frmcustomeradd cus = new frmcustomeradd();
            cus.ShowDialog();
            bindmygrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvcustomer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(dgvcustomer.Rows[e.RowIndex].Cells["Column6"].Value);
          
                if (dgvcustomer.Columns[e.ColumnIndex].HeaderText == "Update")
                {
                    frmcustomeradd cust = new frmcustomeradd();
                    cust = new frmcustomeradd(i);
                    cust.btnupdate.Enabled = true;
                    cust.btnupdate.Visible = true;
                    
                    cust.btnsave.Enabled = false;
                    cust.btnsave.Visible = false;
                     
          
                  //  cust.updatedata(i);     
                    cust.ShowDialog();
                    bindmygrid();
                 

                }
                else if (dgvcustomer.Columns[e.ColumnIndex].HeaderText == "Delete")
                {

                    try
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this Customer?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            qry = "delete from tbl_Customer where C_id=" + i + "";
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
       
          
        }
    }

