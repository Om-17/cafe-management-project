using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace CMS.Forms
{
    public partial class AddCatagories : Form
    {
        public AddCatagories()
        {
            InitializeComponent();
        }
        DB db = new DB();
        private void AddCatagories_Load(object sender, EventArgs e)
        {
            Themeload();
            display();

          
            


        }
        private string cat_id;
        private string todaydate = DateTime.Now.ToString("yyyy/MM/dd");
        private void Themeload() {
            btnUpdatecata.ForeColor = ThemeColor.PrimaryColor;
            btnUpdatecata.IconColor = ThemeColor.PrimaryColor;
            btnUpdatecata.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_cata_delete.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCata.ForeColor = ThemeColor.PrimaryColor;
            btnAddCata.ForeColor = ThemeColor.PrimaryColor;
            btnAddCata.IconColor = ThemeColor.PrimaryColor;
            btnAddCata.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           
            metroGrid_cata.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            metroGrid_cata.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.1);
          
            metroGrid_cata.RowHeadersDefaultCellStyle.BackColor= ThemeColor.PrimaryColor;
            metroGrid_cata.RowHeadersDefaultCellStyle.SelectionBackColor= ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.1); ;
            //Gridcell backcolor
            metroGrid_cata.DefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            metroGrid_cata.DefaultCellStyle.SelectionBackColor= ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.1);


        }
        //create cat
        private void btnAddCata_Click(object sender, EventArgs e)
        {
            string query ="INSERT INTO catagories(cat_name,creation_date) VALUES('"+txtcatagory.Text+"','"+todaydate + "')";
            db.Execute(query);
            display();
            MessageBox.Show("add sucuessfully");
        }

       private void display()
        {
            string query = "SELECT cat_id ,cat_name 'Name' ,creation_date 'Create_Date' ,update_date 'Update_Date'  FROM catagories";
          DataTable dt = db.get_data(query);
            if(dt.Rows.Count > 0)
            {


                metroGrid_cata.DataSource = db.AutoNumberedTable(dt);
                metroGrid_cata.Columns[1].Visible = false;

            }

        }
        //seleted cell
        private void metroGrid_cata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid_cata.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                metroGrid_cata.CurrentRow.Selected = true;
                cat_id = metroGrid_cata.Rows[e.RowIndex].Cells["cat_id"].Value.ToString();
                txtcatagory.Text = metroGrid_cata.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            }

        }
        //update cat
        private void btnUpdatecata_Click(object sender, EventArgs e)
        {

            string query = "UPDATE catagories  set cat_name='" + txtcatagory.Text + "', update_date='"+todaydate+"'  WHERE cat_id='"+cat_id+"' " ;
            db.Execute(query);
            MessageBox.Show("Update Sucessfully.","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            display();

            
        }

        //delete c2at
        private void btn_cata_delete_Click(object sender, EventArgs e)
        {
            string message = "are you sure to delete this catagory ?";
            string title = "Delete Catagories";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE catagories WHERE cat_id='" + cat_id + "'";
                db.Execute(query);
                MessageBox.Show("Delete Sucessfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                display();
            }
            
           
            

        }


    }
}
