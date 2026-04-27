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
    public partial class frmpurchaseview : Form
    {
        int i;
        connectionclass c = new connectionclass();
        SqlConnection con;
        SqlCommand cmd;
        string qry = string.Empty;
        public frmpurchaseview()
        {
            InitializeComponent();
        }
        public frmpurchaseview(int i)
        {
            InitializeComponent();
            this.i = i;
            MessageBox.Show(i.ToString());

        }
        public void bindmygrid()
        {
            qry = "select p.PI_id,p.PU_id,pr.PD_name, p.PD_qty,p.PD_price from tbl_purchase_details p,tbl_product pr where p.PD_id=pr.PD_id and p.PU_id="+i+"";
            DataTable dt = new DataTable();
            con = new SqlConnection(c.cnstr);
            cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvpuchaseview.DataSource = dt;
        }
        private void dgvpuchaseview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmpurchaseview_Load(object sender, EventArgs e)
        {
            bindmygrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvpuchaseview_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
