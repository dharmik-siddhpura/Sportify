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
using System.Net.Mail;


namespace sportify
{
    public partial class frmstaff : Form
    {
        connectionclass c = new connectionclass();
        SqlConnection con;
        SqlCommand cmd;
        string qry = string.Empty;

        public frmstaff()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public void bindmygrid()
        {
            qry = "select * from tbl_staff";
            DataTable dt = new DataTable();
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgrid.DataSource = dt;
        }

        private void frmstaff_Load(object sender, EventArgs e)
        {
            bindmygrid();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                try
                {
                    int i = Convert.ToInt32(dgrid.Rows[e.RowIndex].Cells["Column1"].Value);
                    if (dgrid.Columns[e.ColumnIndex].HeaderText == "Update")
                    {
                        frmstaffadd staff = new frmstaffadd();
                        staff = new frmstaffadd(i);
                        staff.btnupdate.Enabled = true;
                        staff.btnupdate.Visible = true;

                        staff.btnsave.Enabled = false;
                        staff.btnsave.Visible = false;

                        staff.ShowDialog();
                        bindmygrid();


                    }
                    else
                    if (dgrid.Columns[e.ColumnIndex].HeaderText == "Delete")
                    {
                      
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this Staff ?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            qry = "delete from tbl_staff where SF_id=" + i + "";
                            c.conn_table(qry);
                            bindmygrid();
                        }
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString());
                }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            frmstaffadd sfa = new frmstaffadd();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            frmstaffadd fsa = new frmstaffadd();
            fsa.ShowDialog();
            bindmygrid();
        }
    }
}
