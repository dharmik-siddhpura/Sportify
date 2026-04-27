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
using Microsoft.Reporting.WinForms;

namespace sportify
{
    
    public partial class frmreport : Form
    {
        string S_Id;
        public frmreport(string id)
        {
            S_Id = id;
            InitializeComponent();
        }

        
        private void frmreport_Load(object sender, EventArgs e)
        {
            DataTable salestable = Getsalesdata(S_Id);
            DataTable salesdetailstable = Getsalesdetaildata(S_Id); // Make sure this is uncommented

            ReportDataSource salesmaster = new ReportDataSource("rptsalesdataset_sales", salestable);
            ReportDataSource salesdetails = new ReportDataSource("rptsalesdataset_sales_details", salesdetailstable); // Uncomment this

            rpt.Reset();
            rpt.LocalReport.DataSources.Clear();

            rpt.LocalReport.DataSources.Add(salesmaster);
            rpt.LocalReport.DataSources.Add(salesdetails); // Add this data source

            rpt.LocalReport.ReportEmbeddedResource = "sportify.rptsales.rdlc";
            rpt.RefreshReport();
        }


        private DataTable Getsalesdata(string S_Id)
        {
            try
            {
                string connectionString = "Data Source=" + Environment.MachineName + ";Initial Catalog=DB_sportify;Integrated Security=true";
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_sales WHERE S_Id = @S_Id", cnn);
                    cmd.Parameters.AddWithValue("@S_Id", S_Id);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        private DataTable Getsalesdetaildata(string S_Id)
        {
            string connectionString = "Data Source=" + Environment.MachineName + ";Initial Catalog=DB_sportify;Integrated Security=true";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_sales_details WHERE SI_id = @SI_id", con);
                cmd.Parameters.AddWithValue("@SI_id", S_Id); // Pass the BillM_Id dynamically
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        private void rpt_Load(object sender, EventArgs e)
        {

        }
    }
}
