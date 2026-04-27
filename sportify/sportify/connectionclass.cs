using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace sportify
{
    class connectionclass
    {
        //public string cnstr = "Data Source=DHARMIK;Initial Catalog=DB_sportify;Integrated Security=True";
        public string cnstr = "Data Source=STAFF-2;Initial Catalog=DB_sportify;Integrated Security=True";
        public  SqlConnection conn;    //connection variable
        public SqlCommand cmd;        //commmand to be return
        String qery = String.Empty;  //variable for query to be executed

        public void conn_table(string paramQRY)
        {
            conn = new SqlConnection(cnstr);
            cmd = new SqlCommand(paramQRY, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }   
}
