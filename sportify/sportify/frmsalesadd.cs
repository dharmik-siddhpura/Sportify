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
    public partial class frmsalesadd : Form
    {
        connectionclass CLS = new connectionclass();
        SqlConnection con;
        SqlCommand cmd;
        string qry = string.Empty;
        public frmsalesadd()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Ta_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            dgvpdetails.Rows.Add(cmbproduct.SelectedValue.ToString(), cmbproduct.Text, txtpquantity.Text.Trim(), txtpup.Text.Trim());
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
        public void loadpayment()
        {
            DataTable dt = new DataTable();
            qry = "select * from tbl_paymentmethod";
            con = new SqlConnection(CLS.cnstr);
            cmd = new SqlCommand(qry, con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                cmbpayment.DataSource = null;
                cmbpayment.ValueMember = "p_id";
                cmbpayment.DisplayMember = "p_name";
                cmbpayment.DataSource = dt;
            }
        }
        public void loadcustomer()
        {
            DataTable dt = new DataTable();
            qry = "select * from tbl_customer";
            con = new SqlConnection(CLS.cnstr);
            cmd = new SqlCommand(qry, con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                cmbcustomer.DataSource = null;
                cmbcustomer.ValueMember = "C_id";
                cmbcustomer.DisplayMember = "C_name";
                cmbcustomer.DataSource = dt;
            }
        }
        public void loadproduct()
        {
            DataTable dt = new DataTable();
            qry = "select * from tbl_product";
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
        private void cmbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmsalesadd_Load(object sender, EventArgs e)
        {
            //loadcategory();
            loadpayment();
            loadtax();
            loadproduct();
            loadcustomer();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbdiscount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbtax_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbproduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnnewcustomer_Click(object sender, EventArgs e)
        {
        
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            dgvpdetails.Rows.Add(cmbproduct.SelectedValue.ToString(), cmbproduct.Text, txtpquantity.Text.Trim(), txtpup.Text.Trim());
        }

        private void dgvpdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvpdetails.Rows.RemoveAt(e.RowIndex);
            }
            catch (Exception e1)
            {
                MessageBox.Show("error" + e1.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int MySalID = 0;
                int TotalAmt = 0;
                double NetAmt = 0;
                string tax = string.Empty;

                if (cmbTax.Text.Length == 1)
                    tax = "0.0" + cmbTax.Text.ToString();
                else if (cmbTax.Text.Length == 2)
                    tax = "0." + cmbTax.Text.ToString();
                else
                    tax = cmbTax.Text.ToString();



                foreach (DataGridViewRow DGR in dgvpdetails.Rows)
                {
                    TotalAmt += int.Parse(DGR.Cells[3].Value.ToString()) * int.Parse(DGR.Cells[2].Value.ToString());
                }

                double taxAmt = TotalAmt * double.Parse(tax);

                NetAmt = TotalAmt + taxAmt;
                qry = "select max(S_Id) from tbl_sales";
                CLS.conn = new SqlConnection(CLS.cnstr);
                CLS.cmd = new SqlCommand(qry, CLS.conn);
                CLS.conn.Open();
                SqlDataReader DR = CLS.cmd.ExecuteReader();
                if (DR.Read()) MySalID = int.Parse(DR.GetValue(0).ToString());
                DR.Close();
                CLS.cmd.Dispose();
                MySalID++;

                string date = dtpPurchaseDate.Value.Year.ToString() + "-" + dtpPurchaseDate.Value.Month.ToString() + "-" + dtpPurchaseDate.Value.Day.ToString(); 

                qry = "INSERT INTO tbl_sales VALUES(";
                qry += "" + MySalID + ",";
                qry += "(select max(S_BillNo)+1 from tbl_sales),";
                qry += "'" + date + "',";
                qry += "" + cmbcustomer.SelectedValue + ",";
                qry += "'" + cmbcustomer.Text + "',";
                qry += "" + dgvpdetails.Rows.Count.ToString() + ",";
                qry += "" + TotalAmt.ToString() + ",";
                qry += "" + cmbpayment.SelectedValue + ",";
                qry += "'" + cmbpayment.Text + "',";
                qry += "" + taxAmt + ",";
                qry += "" + NetAmt.ToString() + " ";
                qry += ")";

                CLS.cmd = new SqlCommand(qry, CLS.conn);
                CLS.cmd.ExecuteNonQuery();
                CLS.cmd.Dispose();

                foreach (DataGridViewRow DGR in dgvpdetails.Rows)
                {

                    
                    qry = "insert into tbl_sales_details values (";
                    qry += "(select max(SA_id)+1 from tbl_sales_details),";
                    qry += "" + MySalID + ",";
                    qry += "" + DGR.Cells[0].Value.ToString() + ",";
                    qry += "'" + DGR.Cells[1].Value.ToString() + "',";
                    qry += "" + DGR.Cells[2].Value.ToString() + ",";
                    qry += "" + DGR.Cells[3].Value.ToString() + " )";

                 //   MessageBox.Show(qry);
                    CLS.cmd = new SqlCommand(qry, CLS.conn);
                    CLS.cmd.ExecuteNonQuery();
                    CLS.cmd.Dispose();
                }

                dgvpdetails.Rows.Clear();

                MessageBox.Show("Items Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //this.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show("error" + e1.ToString());
            }

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            qry = "select max(S_Id) as S_Id from tbl_sales";

            DataTable dt = new DataTable();
            con = new SqlConnection(CLS.cnstr);
            cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            new frmreport(dt.Rows[0]["S_Id"].ToString()).Show();
            //MessageBox.Show(dt.Rows[0]["S_Id"].ToString());
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
