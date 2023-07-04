using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace cafe_management_system
{
    internal class DB
    {
        private SqlConnection con;
        public SqlCommand cmd;
        private SqlDataAdapter sda;
        private DataTable dt;

        public DB() { 
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=cms_1;Integrated Security=True");
        
        }
        public bool Execute(string Query)
        {
            try
            {
            con.Open();
             cmd =new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally { 
            con.Close();
                
            }
            return true;
        }
        public DataTable QueryEx(string query)
        {
            sda = new SqlDataAdapter(query, con);
            dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

    }
}
