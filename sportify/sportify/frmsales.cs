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
    public partial class frmsales : Form
    {
        connectionclass c = new connectionclass();
        SqlConnection con;
        SqlCommand cmd;
        string qry = string.Empty;
        public frmsales()
        {
            InitializeComponent();
        }

        private void frmsales_Load(object sender, EventArgs e)
        {
            bindmygrid();
        }
        public void bindmygrid()
        {
            //qry = "select * from tbl_sales";
            qry = "select s.S_Id,s.S_BillNo,s.S_date,s.S_Cid,c.C_name,s.S_qty,s.S_amt,p.p_name,s.S_TaxAmt,s.S_NetAmt from tbl_sales s,tbl_paymentmethod p,tbl_Customer c where S_payment=p.p_id and S_Cid=c.C_id order by s.S_date DESC";
            DataTable dt = new DataTable();
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv.DataSource = dt;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            frmsalesadd sales = new frmsalesadd();
            sales.ShowDialog();
            bindmygrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string bid = dgv.CurrentRow.Cells[1].Value.ToString();
            MessageBox.Show("Bill No: " + bid, "Sale Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
