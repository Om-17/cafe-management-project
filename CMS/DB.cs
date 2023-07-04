using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;
namespace CMS
{
    internal class DB
    {
        public SqlConnection con;
        public SqlCommand cmd;
        private SqlDataAdapter sda;
        private DataTable dt;

        public DB()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=cms_1;Integrated Security=True");

        }
        public int SQL(string qry, Hashtable ht)
        {

            int res = 0;
            try
            {
                con.Open();
                cmd = new SqlCommand(qry,con);
                cmd.CommandType = CommandType.Text;
                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);

                }
               
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
            finally { con.Close(); }
            return res;

        }

        public  void loaddate(string qry,DataGridView  gv , ListBox lb)
        {
            try
            {
                cmd= new SqlCommand(qry,con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da= new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.Fill(dt);
                for(int i=0;i<lb.Items.Count; i++) {
                    string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNam1].DataPropertyName= dt.Columns[i].ToString();
                    
                }
                gv.DataSource= dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        public  void CBFill(string qry, ComboBox cb,string displaymember, string id)
        {
            
            con.Open();
            cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtdata= new DataTable();   
            da.Fill(dtdata);
            cb.DataSource = dtdata;
            cb.DisplayMember = displaymember;
            cb.ValueMember = id;
            cb.SelectedIndex = -1;
            con.Close();

        }
        public bool Execute(string Query)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();

            }
            return true;
        }
        public DataTable get_data(string query)
        {
            sda = new SqlDataAdapter(query, con);
            dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

         
       
        public DataTable AutoNumberedTable(DataTable SourceTable)

        {

            DataTable ResultTable = new DataTable();

            DataColumn AutoNumberColumn = new DataColumn();

            AutoNumberColumn.ColumnName = "Sr.No.";
           

            AutoNumberColumn.DataType = typeof(int);

            AutoNumberColumn.AutoIncrement = true;

            AutoNumberColumn.AutoIncrementSeed = 1;

            AutoNumberColumn.AutoIncrementStep = 1;
            
            ResultTable.Columns.Add(AutoNumberColumn);

            ResultTable.Merge(SourceTable);

            return ResultTable;

        }

      
    }
}
