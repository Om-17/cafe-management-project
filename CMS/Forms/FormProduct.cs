using CMS.Model;
using FontAwesome.Sharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Control = System.Windows.Forms.Control;

namespace CMS.Forms
{
    public partial class FormProduct : Form
    {
        DB db = new DB();
        private Form activeForm;
        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
         
            btncClosesubform.Visible = false;
           LoadTheme();
            displaydata();

        }
        private void LoadTheme()
        {
           foreach (Control btns in panelsubheader.Controls)
            {
                if (btns.GetType() == typeof(IconButton))
                {

                    IconButton btn = (IconButton)btns;
                    btn.ForeColor = ThemeColor.PrimaryColor;
                    btn.IconColor= ThemeColor.PrimaryColor;

                   
                }
            }
            GridProduct.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.SecondaryColor;
            GridProduct.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.1);

            GridProduct.RowHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            GridProduct.RowHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.1); ;
            //Gridcell backcolor
            GridProduct.DefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
           
            GridProduct.DefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.1);

        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelSubDesktop.Controls.Add(childForm);
            this.panelSubDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }
        
      

        private void btncClosesubform_Click(object sender, EventArgs e)
        {
           if (activeForm != null)
            {
                activeForm.Close();
                btncClosesubform.Visible= false;
            }
            txtid.Visible = true;
            btnupdate.Visible = true;
            deletebtn.Visible = true;


        }

        private void btnAddCatagories_Click(object sender, EventArgs e)
        {
            btncClosesubform.Visible = true;
            OpenChildForm(new Forms.AddCatagories(), sender);
            txtid.Visible= false;
            btnupdate.Visible= false;
            deletebtn.Visible= false;

        }
     
        private void panelSubDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void displaydata()
        {
            string query = "SELECT  product.id , product.price,product.description,product.product_name, catagories.cat_name FROM product JOIN catagories ON product.cat_id = catagories.cat_id";
            DataTable dt = db.get_data(query);
            if (dt.Rows.Count > 0)
            {
                GridProduct.DataSource = db.AutoNumberedTable(dt);
                GridProduct.Columns[1].Visible = false;
            }
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int id = 0;
            Form formBackground = new Form();
            ProductAdd product = new ProductAdd(id);
            //product.Show();

            try
            {
                using (product)
                {
                    
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .70d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show(this);
                    product.Owner = formBackground;
                    product.ShowDialog(formBackground);
                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                  formBackground.Dispose();
                MessageBox.Show(ex.Message);
               }
            finally
            {
                formBackground.Dispose();

            }


        }

        private void GridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void GridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                GridProduct.CurrentRow.Selected = true;
                //cat_id = metroGrid_cata.Rows[e.RowIndex].Cells["cat_id"].Value.ToString();
                txtid.Text = GridProduct.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text == "") {
                
                    MessageBox.Show(" please select row.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    string message = "are you sure to delete this Product ?";
                    string title = "Delete Product";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string query = "DELETE product WHERE id='" + Convert.ToInt16(txtid.Text) + "'";
                        db.Execute(query);
                        MessageBox.Show("Delete Sucessfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        displaydata();
                        txtid.Text = "";
                    }
                    else
                    {
                        txtid.Text = "";

                    }

                }


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);


            }


        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {

                MessageBox.Show(" please select row.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Form formBackground = new Form();
                int id= Convert.ToInt16(txtid.Text);
                ProductAdd product = new ProductAdd(id);
                //product.Show();

                try
                {
                    using (product)
                    {

                        formBackground.StartPosition = FormStartPosition.Manual;
                        formBackground.FormBorderStyle = FormBorderStyle.None;
                        formBackground.Opacity = .70d;
                        formBackground.BackColor = Color.Black;
                        formBackground.WindowState = FormWindowState.Maximized;
                        formBackground.TopMost = true;
                        formBackground.Location = this.Location;
                        formBackground.ShowInTaskbar = false;
                        formBackground.Show(this);
                        product.Owner = formBackground;
                        product.ShowDialog(formBackground);
                        formBackground.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    formBackground.Dispose();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    formBackground.Dispose();
                    displaydata();
                }
            }
          

        }
    }
}
