using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Model
{
    public partial class ProductAdd : AddModelSample
    {
        private int pid=0;
        public ProductAdd(int proId)
        {
            InitializeComponent();
            labelId.Text = proId.ToString();
           pid = proId;
            if (pid != 0)
            {
                string query = "SELECT  product.price,product.description,product.cat_id,product.product_name, catagories.cat_name FROM product JOIN catagories ON product.cat_id = catagories.cat_id where id='" + pid + "'";
                DataTable dt = db.get_data(query);
                if (dt.Rows.Count > 0)
                {
                    txtProduct.Text = dt.Rows[0]["product_name"].ToString();
                    txtprice.Text = dt.Rows[0]["price"].ToString();
                    txtDescription.Text = dt.Rows[0]["description"].ToString();
                    //ComboBoxCata.ValueMember = dt.Rows[0]["cat_id"].ToString();
                    //ComboBoxCata.SelectedValue = dt.Rows[0]["cat_name"].ToString();
                    //ComboBoxCata.Text= dt.Rows[0]["cat_name"].ToString();

                    // ComboBoxCata.ValueMember =ConvertToInt16(dt.Rows[0]["catid"].ToString());
                    //txtImage.Image =dt.Rows[0]["img"];
                }


            }
        }
        string filePath;
        private string todaydate = DateTime.Now.ToString("yyyy/MM/dd");


        public string catid;
        DB db = new DB();
        private void iconButtonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd= new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png )|* .png ; *.jpg";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                filePath = ofd.FileName;
                txtImage.Image = new Bitmap(filePath);

            }
         }

        private void ProductAdd_Load(object sender, EventArgs e)
        {

            iconButtonBrowse.BackColor = ThemeColor.PrimaryColor;
            DB db = new DB();
            string qry = "SELECT cat_id  , cat_name  from catagories ";
            db.CBFill(qry, ComboBoxCata, "cat_name", "cat_id");
            

        }

        // for Image
     
     
   
        private void ComboBoxCata_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxCata.SelectedValue!=null)
            {
             catid = ComboBoxCata.SelectedValue.ToString();
                //label2.Text = catid.ToString();

            }

        }
        

        private void iconButtonSave_Click1(object sender, EventArgs e)
        {
         
                Image img = txtImage.Image;
                ImageConverter converter = new ImageConverter();
           
                byte[] imageByteArray = (byte[])converter.ConvertTo(img, typeof(byte[]));
            if (pid != 0)
            {
              string query= "UPDATE product SET product_name = @productName, cat_id = @catID, price = @price, description = @description, img = @imageByteArray WHERE id = @productID";
                using (SqlCommand cmd = new SqlCommand(query, db.con))
                {
                    cmd.Parameters.AddWithValue("@productID", pid);
                    cmd.Parameters.AddWithValue("@productName", txtProduct.Text);
                    cmd.Parameters.AddWithValue("@catID", Convert.ToInt16(catid));
                    cmd.Parameters.AddWithValue("@price", txtprice.Text);
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@imageByteArray", imageByteArray);
                    //cmd.Parameters.AddWithValue("@creationDate", DateTime.Today.ToString("yyyy-MM-dd"));
                    db.con.Open();
                    cmd.ExecuteNonQuery();
                    db.con.Close();
                }
                this.Close();
                MessageBox.Show("Update successfully.");


            }
            else
            { 
               string query = "INSERT INTO product (product_name, cat_id, price, description, img, creation_date) VALUES (@productName, @catID, @price, @description, @imageByteArray, @creationDate)";
                using (SqlCommand cmd = new SqlCommand(query, db.con))
                {
                    cmd.Parameters.AddWithValue("@productName", txtProduct.Text);
                    cmd.Parameters.AddWithValue("@catID", Convert.ToInt16(catid));
                    cmd.Parameters.AddWithValue("@price", Convert.ToInt16(txtprice.Text));
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@imageByteArray", imageByteArray);
                    cmd.Parameters.AddWithValue("@creationDate", DateTime.Today.ToString("yyyy-MM-dd"));
                    db.con.Open();
                    cmd.ExecuteNonQuery();
                    db.con.Close();
                }
                this.Close();

                MessageBox.Show("Added successfully.");

            }

           

      

        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // If the entered key is not a number or a control character, discard the input
                e.Handled = true;
            }
        }
    }
}
