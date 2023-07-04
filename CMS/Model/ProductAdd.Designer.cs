namespace CMS.Model
{
    partial class ProductAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductAdd));
            this.labelproduct = new System.Windows.Forms.Label();
            this.txtProduct = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprice = new MetroFramework.Controls.MetroTextBox();
            this.ComboBoxCata = new MetroFramework.Controls.MetroComboBox();
            this.txtImage = new System.Windows.Forms.PictureBox();
            this.iconButtonBrowse = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).BeginInit();
            this.panelfooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelheader
            // 
            this.panelheader.Size = new System.Drawing.Size(827, 97);
            // 
            // labeltitle
            // 
            this.labeltitle.Size = new System.Drawing.Size(143, 31);
            this.labeltitle.Text = "Add Product";
            // 
            // panelfooter
            // 
            this.panelfooter.Location = new System.Drawing.Point(0, 383);
            this.panelfooter.Size = new System.Drawing.Size(827, 67);
            // 
            // iconButtonSave
            // 
            this.iconButtonSave.Click += new System.EventHandler(this.iconButtonSave_Click1);
            // 
            // labelproduct
            // 
            this.labelproduct.AutoSize = true;
            this.labelproduct.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.labelproduct.Location = new System.Drawing.Point(44, 123);
            this.labelproduct.Name = "labelproduct";
            this.labelproduct.Size = new System.Drawing.Size(92, 17);
            this.labelproduct.TabIndex = 2;
            this.labelproduct.Text = "Product Name";
            // 
            // txtProduct
            // 
            this.txtProduct.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txtProduct.CustomButton.Image = null;
            this.txtProduct.CustomButton.Location = new System.Drawing.Point(224, 2);
            this.txtProduct.CustomButton.Name = "";
            this.txtProduct.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProduct.CustomButton.TabIndex = 1;
            this.txtProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProduct.CustomButton.UseSelectable = true;
            this.txtProduct.CustomButton.Visible = false;
            this.txtProduct.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtProduct.Lines = new string[0];
            this.txtProduct.Location = new System.Drawing.Point(47, 143);
            this.txtProduct.MaxLength = 32767;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.PasswordChar = '\0';
            this.txtProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProduct.SelectedText = "";
            this.txtProduct.SelectionLength = 0;
            this.txtProduct.SelectionStart = 0;
            this.txtProduct.ShortcutsEnabled = true;
            this.txtProduct.Size = new System.Drawing.Size(252, 30);
            this.txtProduct.TabIndex = 3;
            this.txtProduct.UseSelectable = true;
            this.txtProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label2.Location = new System.Drawing.Point(44, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Catagories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label3.Location = new System.Drawing.Point(44, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txtprice.CustomButton.Image = null;
            this.txtprice.CustomButton.Location = new System.Drawing.Point(224, 2);
            this.txtprice.CustomButton.Name = "";
            this.txtprice.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtprice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtprice.CustomButton.TabIndex = 1;
            this.txtprice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtprice.CustomButton.UseSelectable = true;
            this.txtprice.CustomButton.Visible = false;
            this.txtprice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtprice.Lines = new string[0];
            this.txtprice.Location = new System.Drawing.Point(47, 286);
            this.txtprice.MaxLength = 32767;
            this.txtprice.Name = "txtprice";
            this.txtprice.PasswordChar = '\0';
            this.txtprice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtprice.SelectedText = "";
            this.txtprice.SelectionLength = 0;
            this.txtprice.SelectionStart = 0;
            this.txtprice.ShortcutsEnabled = true;
            this.txtprice.Size = new System.Drawing.Size(252, 30);
            this.txtprice.TabIndex = 3;
            this.txtprice.UseSelectable = true;
            this.txtprice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtprice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            // 
            // ComboBoxCata
            // 
            this.ComboBoxCata.FormattingEnabled = true;
            this.ComboBoxCata.ItemHeight = 23;
            this.ComboBoxCata.Location = new System.Drawing.Point(47, 211);
            this.ComboBoxCata.Name = "ComboBoxCata";
            this.ComboBoxCata.Size = new System.Drawing.Size(252, 29);
            this.ComboBoxCata.TabIndex = 4;
            this.ComboBoxCata.UseSelectable = true;
            this.ComboBoxCata.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCata_SelectedIndexChanged);
            // 
            // txtImage
            // 
            this.txtImage.Image = ((System.Drawing.Image)(resources.GetObject("txtImage.Image")));
            this.txtImage.Location = new System.Drawing.Point(583, 123);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(184, 160);
            this.txtImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtImage.TabIndex = 5;
            this.txtImage.TabStop = false;
            // 
            // iconButtonBrowse
            // 
            this.iconButtonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBrowse.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonBrowse.ForeColor = System.Drawing.Color.White;
            this.iconButtonBrowse.IconChar = FontAwesome.Sharp.IconChar.FileImage;
            this.iconButtonBrowse.IconColor = System.Drawing.Color.White;
            this.iconButtonBrowse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBrowse.IconSize = 30;
            this.iconButtonBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBrowse.Location = new System.Drawing.Point(621, 308);
            this.iconButtonBrowse.Name = "iconButtonBrowse";
            this.iconButtonBrowse.Size = new System.Drawing.Size(108, 40);
            this.iconButtonBrowse.TabIndex = 6;
            this.iconButtonBrowse.Text = "Browse";
            this.iconButtonBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonBrowse.UseVisualStyleBackColor = true;
            this.iconButtonBrowse.Click += new System.EventHandler(this.iconButtonBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label1.Location = new System.Drawing.Point(312, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(192, 2);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(315, 143);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(230, 40);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(330, 214);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(15, 13);
            this.labelId.TabIndex = 8;
            this.labelId.Text = "id";
            // 
            // ProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.iconButtonBrowse);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.ComboBoxCata);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.labelproduct);
            this.Name = "ProductAdd";
            this.Text = "ProductAdd";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.Controls.SetChildIndex(this.panelheader, 0);
            this.Controls.SetChildIndex(this.panelfooter, 0);
            this.Controls.SetChildIndex(this.labelproduct, 0);
            this.Controls.SetChildIndex(this.txtProduct, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtprice, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            this.Controls.SetChildIndex(this.ComboBoxCata, 0);
            this.Controls.SetChildIndex(this.txtImage, 0);
            this.Controls.SetChildIndex(this.iconButtonBrowse, 0);
            this.Controls.SetChildIndex(this.labelId, 0);
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).EndInit();
            this.panelfooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelproduct;
        private MetroFramework.Controls.MetroTextBox txtProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtprice;
        private MetroFramework.Controls.MetroComboBox ComboBoxCata;
        private System.Windows.Forms.PictureBox txtImage;
        private FontAwesome.Sharp.IconButton iconButtonBrowse;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private System.Windows.Forms.Label labelId;
    }
}