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

namespace cafe_management_system
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection con= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=cms_1;Integrated Security=True");

        private void login_Load(object sender, EventArgs e)
        {
            txt_user.Focus();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txt_user.Text;
            password = txt_password.Text;
          
            try
            {
                string query = "SELECT * FROM users WHERE username = '" + username + "'AND password = '" + password + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    username = txt_user.Text;
                    password = txt_password.Text;
                    //main_form menu2 = new main_form(dtable.Rows[0][3].ToString());
                    Menu menu1 = new Menu(dtable.Rows[0][3].ToString());
                    menu1.Show();
                    //menu2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("invaild login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_user.Clear();
                    txt_password.Clear();
                    txt_user.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
           
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void clear_Click(object sender, EventArgs e)
        {
            txt_user.Clear();
            txt_password.Clear();
            txt_user.Focus();
        }
    }
}

