namespace CMS.Forms
{
    partial class FormProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelsubheader = new System.Windows.Forms.Panel();
            this.btnAddProduct = new FontAwesome.Sharp.IconButton();
            this.btnAddCatagories = new FontAwesome.Sharp.IconButton();
            this.btncClosesubform = new FontAwesome.Sharp.IconButton();
            this.panelSubDesktop = new System.Windows.Forms.Panel();
            this.GridProduct = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.sr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtid = new System.Windows.Forms.TextBox();
            this.deletebtn = new FontAwesome.Sharp.IconButton();
            this.btnupdate = new FontAwesome.Sharp.IconButton();
            this.panelsubheader.SuspendLayout();
            this.panelSubDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panelsubheader
            // 
            this.panelsubheader.Controls.Add(this.btnupdate);
            this.panelsubheader.Controls.Add(this.deletebtn);
            this.panelsubheader.Controls.Add(this.txtid);
            this.panelsubheader.Controls.Add(this.btnAddProduct);
            this.panelsubheader.Controls.Add(this.btnAddCatagories);
            this.panelsubheader.Controls.Add(this.btncClosesubform);
            this.panelsubheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsubheader.Location = new System.Drawing.Point(0, 0);
            this.panelsubheader.Name = "panelsubheader";
            this.panelsubheader.Size = new System.Drawing.Size(848, 54);
            this.panelsubheader.TabIndex = 1;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            this.btnAddProduct.IconColor = System.Drawing.Color.Black;
            this.btnAddProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddProduct.IconSize = 30;
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.Location = new System.Drawing.Point(63, 0);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(149, 54);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = " Add Product";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnAddCatagories
            // 
            this.btnAddCatagories.FlatAppearance.BorderSize = 0;
            this.btnAddCatagories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCatagories.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            this.btnAddCatagories.IconColor = System.Drawing.Color.Black;
            this.btnAddCatagories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCatagories.IconSize = 30;
            this.btnAddCatagories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCatagories.Location = new System.Drawing.Point(223, 0);
            this.btnAddCatagories.Margin = new System.Windows.Forms.Padding(20, 5, 6, 5);
            this.btnAddCatagories.Name = "btnAddCatagories";
            this.btnAddCatagories.Size = new System.Drawing.Size(162, 54);
            this.btnAddCatagories.TabIndex = 0;
            this.btnAddCatagories.Text = " Add Catagories";
            this.btnAddCatagories.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCatagories.UseVisualStyleBackColor = true;
            this.btnAddCatagories.Click += new System.EventHandler(this.btnAddCatagories_Click);
            // 
            // btncClosesubform
            // 
            this.btncClosesubform.Dock = System.Windows.Forms.DockStyle.Left;
            this.btncClosesubform.FlatAppearance.BorderSize = 0;
            this.btncClosesubform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncClosesubform.IconChar = FontAwesome.Sharp.IconChar.ArrowLeftLong;
            this.btncClosesubform.IconColor = System.Drawing.Color.Black;
            this.btncClosesubform.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncClosesubform.IconSize = 32;
            this.btncClosesubform.Location = new System.Drawing.Point(0, 0);
            this.btncClosesubform.Name = "btncClosesubform";
            this.btncClosesubform.Size = new System.Drawing.Size(54, 54);
            this.btncClosesubform.TabIndex = 1;
            this.btncClosesubform.UseVisualStyleBackColor = true;
            this.btncClosesubform.Click += new System.EventHandler(this.btncClosesubform_Click);
            // 
            // panelSubDesktop
            // 
            this.panelSubDesktop.Controls.Add(this.GridProduct);
            this.panelSubDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubDesktop.Location = new System.Drawing.Point(0, 54);
            this.panelSubDesktop.Name = "panelSubDesktop";
            this.panelSubDesktop.Size = new System.Drawing.Size(848, 405);
            this.panelSubDesktop.TabIndex = 2;
            this.panelSubDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSubDesktop_Paint);
            // 
            // GridProduct
            // 
            this.GridProduct.AllowUserToAddRows = false;
            this.GridProduct.AllowUserToDeleteRows = false;
            this.GridProduct.AllowUserToResizeRows = false;
            this.GridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sr,
            this.pro_name,
            this.cat_name,
            this.desc,
            this.price});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridProduct.EnableHeadersVisualStyles = false;
            this.GridProduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridProduct.Location = new System.Drawing.Point(0, 0);
            this.GridProduct.Name = "GridProduct";
            this.GridProduct.ReadOnly = true;
            this.GridProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridProduct.RowHeadersVisible = false;
            this.GridProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProduct.Size = new System.Drawing.Size(848, 405);
            this.GridProduct.TabIndex = 0;
            this.GridProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProduct_CellClick);
            this.GridProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProduct_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Image = global::CMS.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = global::CMS.Properties.Resources.delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // sr
            // 
            this.sr.DataPropertyName = "Sr.No.";
            this.sr.HeaderText = "Sr.No";
            this.sr.Name = "sr";
            this.sr.ReadOnly = true;
            // 
            // pro_name
            // 
            this.pro_name.DataPropertyName = "product_name";
            this.pro_name.HeaderText = "Product";
            this.pro_name.Name = "pro_name";
            this.pro_name.ReadOnly = true;
            // 
            // cat_name
            // 
            this.cat_name.DataPropertyName = "cat_name";
            this.cat_name.HeaderText = "Catagories";
            this.cat_name.Name = "cat_name";
            this.cat_name.ReadOnly = true;
            // 
            // desc
            // 
            this.desc.DataPropertyName = "description";
            this.desc.HeaderText = "Descriptions";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(405, 11);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(100, 34);
            this.txtid.TabIndex = 2;
            // 
            // deletebtn
            // 
            this.deletebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.ForeColor = System.Drawing.Color.Red;
            this.deletebtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.deletebtn.IconColor = System.Drawing.Color.Red;
            this.deletebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deletebtn.IconSize = 27;
            this.deletebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletebtn.Location = new System.Drawing.Point(747, 0);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(101, 54);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "Delete";
            this.deletebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnupdate.IconColor = System.Drawing.Color.Black;
            this.btnupdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnupdate.IconSize = 30;
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(640, 0);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(107, 54);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "Update";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 459);
            this.Controls.Add(this.panelSubDesktop);
            this.Controls.Add(this.panelsubheader);
            this.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.panelsubheader.ResumeLayout(false);
            this.panelsubheader.PerformLayout();
            this.panelSubDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnAddCatagories;
        private System.Windows.Forms.Panel panelsubheader;
        private System.Windows.Forms.Panel panelSubDesktop;
        private FontAwesome.Sharp.IconButton btncClosesubform;
        private FontAwesome.Sharp.IconButton btnAddProduct;
        private MetroFramework.Controls.MetroGrid GridProduct;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sr;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.TextBox txtid;
        private FontAwesome.Sharp.IconButton deletebtn;
        private FontAwesome.Sharp.IconButton btnupdate;
    }
}