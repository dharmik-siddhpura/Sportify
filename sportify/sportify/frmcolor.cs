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
    public partial class frmcolor : Form
    {
        connectionclass c = new connectionclass();
        SqlConnection con;
        SqlCommand cmd;
        string qry = string.Empty;
        public frmcolor()
        {
            InitializeComponent();
        }
        public void bindmygrid()
        {
            qry = "select * from tbl_color";
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
                qry = "insert into tbl_color values ((select max(color_id)+1 from tbl_color),'" + txtcolname.Text + "')";
                c.conn_table(qry);
                MessageBox.Show("Inserted");
                txtcolname.Clear();
                txtcolname.Focus();
                bindmygrid();
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void frmcolor_Load(object sender, EventArgs e)
        {
            bindmygrid();
        }
        public void fillmycontrol(int index)
        {
            txtcolname.Text = dgrid.Rows[index].Cells[1].Value.ToString();
        }

        private void dgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this Color?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                qry = "delete from tbl_color where color='" + txtcolname.Text + "'";
                c.conn_table(qry);
                bindmygrid();
                txtcolname.Clear();
            }
        }

        private void dgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillmycontrol(e.RowIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcolname.Clear();
        }

        private void txtcolname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtcolname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
