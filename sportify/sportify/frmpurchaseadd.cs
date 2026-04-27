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
    public partial class frmpurchaseadd : Form
    {
        connectionclass CLS = new connectionclass();
        SqlConnection con;
        SqlCommand cmd;
        string qry = string.Empty;
       
        public frmpurchaseadd()
        {
            InitializeComponent();
        }
        
        public void loadtax()
        {
            DataTable dt = new DataTable();
            qry = "select Tax from tbl_Tax";
            con = new SqlConnection(CLS.cnstr);
            cmd = new SqlCommand(qry, con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                cmbTax.DataSource = null;
                cmbTax.ValueMember = "Tax";
                cmbTax.DisplayMember = "Tax";
                cmbTax.DataSource = dt;
            }
        }
        public void loadbrand()
        {
            DataTable dt = new DataTable();
            qry = "select * from tbl_brand";
            con = new SqlConnection(CLS.cnstr);
            cmd = new SqlCommand(qry, con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                cmbbrand.DataSource = null;
                cmbbrand.ValueMember = "b_id";
                cmbbrand.DisplayMember = "b_name";
                cmbbrand.DataSource = dt;
            }
        }
        
        public void loadproduct()
        {
            DataTable dt = new DataTable();
            qry = "select * from tbl_Product";
            con = new SqlConnection(CLS.cnstr);
            cmd = new SqlCommand(qry, con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                cmbproduct.DataSource = null;
                cmbproduct.ValueMember = "PD_id";
                cmbproduct.DisplayMember = "PD_name";
                cmbproduct.DataSource = dt;
            }
        }
        public void loadsupplier()
        {
            DataTable dt = new DataTable();
            qry = "select S_id,S_name from tbl_Supplier";
            con = new SqlConnection(CLS.cnstr);
            cmd = new SqlCommand(qry, con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                cmbSupplier.DataSource = null;
                cmbSupplier.ValueMember = "S_id";
                cmbSupplier.DisplayMember = "S_name";
                cmbSupplier.DataSource = dt;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void frmpurchase_Load(object sender, EventArgs e)
        {
           // bindmygrid();
            loadsupplier();
            loadbrand();
            loadproduct();
            loadtax();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnsaveadd_Click(object sender, EventArgs e)
        {
            try
            {
                int MyPurID = 0;
                int TotalAmt = 0;
                double NetAmt = 0;
                string tax = string.Empty;

                if(cmbTax.Text.Length == 1)
                    tax = "0.0" + cmbTax.Text.ToString();
                else if (cmbTax.Text.Length == 2)
                    tax = "0." + cmbTax.Text.ToString();
                else
                    tax = cmbTax.Text.ToString();


                //MessageBox.Show(dgvpdetails.Rows.Count.ToString());
                foreach (DataGridViewRow DGR in dgvpdetails.Rows)
                {
                   // MessageBox.Show(DGR.Cells[2].Value.ToString());
                    TotalAmt += int.Parse(DGR.Cells[3].Value.ToString()) * int.Parse(DGR.Cells[2].Value.ToString());
                }
                
                double taxAmt = TotalAmt * double.Parse(tax);

                NetAmt = TotalAmt + taxAmt;


                qry = "select max(PU_Id) from tbl_purchase";
                CLS.conn = new SqlConnection(CLS.cnstr);
                CLS.cmd = new SqlCommand(qry, CLS.conn);
                CLS.conn.Open();
                SqlDataReader DR = CLS.cmd.ExecuteReader();
                if (DR.Read()) MyPurID = int.Parse(DR.GetValue(0).ToString());
                DR.Close();
                CLS.cmd.Dispose();
                MyPurID++;

                qry = "INSERT INTO tbl_purchase VALUES(";
                qry += ""+ MyPurID +",";
                qry += "(select max(PU_BillNo)+1 from tbl_purchase),";
                qry += "'" + dtpPurchaseDate.Value.ToShortDateString() + "',";
                qry += "" + cmbSupplier.SelectedValue.ToString() + ",";
                qry += "" + dgvpdetails.Rows.Count.ToString() + ",";
                qry += "" + TotalAmt.ToString() + ",";
                qry += "" + taxAmt + ",";
                qry += "" + NetAmt.ToString() + " ";
                qry += ")";
                MessageBox.Show(qry);
                CLS.cmd = new SqlCommand(qry, CLS.conn);
                CLS.cmd.ExecuteNonQuery();
                CLS.cmd.Dispose();


                foreach (DataGridViewRow DGR in dgvpdetails.Rows)
                {
                    qry = "INSERT INTO tbl_purchase_details ";
                    qry += "SELECT ";
                    qry += "MAX(PI_id) + 1, ";
                    qry += "" + MyPurID.ToString() + ", ";
                    qry += "" + DGR.Cells[0].Value.ToString() + ", ";
                    qry += "" + DGR.Cells[2].Value.ToString() + ", ";
                    qry += "" + DGR.Cells[3].Value.ToString() + " ";
                    qry += "FROM tbl_purchase_details ";
                    CLS.cmd = new SqlCommand(qry, CLS.conn);
                    CLS.cmd.ExecuteNonQuery();
                    CLS.cmd.Dispose();
                }

                dgvpdetails.Rows.Clear();

                MessageBox.Show("Items Saved", "Save",MessageBoxButtons.OK,MessageBoxIcon.Information);


            }
            catch (Exception e1)
            {
                MessageBox.Show("error" + e1.ToString());
            }
            finally
            {
                CLS.cmd.Dispose();
                CLS.conn.Close();
            }
        }

        private void btnpadd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            dgvpdetails.Rows.Add(cmbproduct.SelectedValue.ToString(), cmbproduct.Text, txtpquantity.Text.Trim(), txtpup.Text.Trim());

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }       

        private void cmbsupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtpquantity_TextChanged(object sender, EventArgs e)
        {

        }

            private void dgvpdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                 try
                {
                    dgvpdetails.Rows.RemoveAt(e.RowIndex);
                }
                catch(Exception e1)
                {
                    MessageBox.Show("error" + e1.ToString());
                }
            
            }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }
    }
}

