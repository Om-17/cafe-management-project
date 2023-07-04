namespace CMS.Forms
{
    partial class AddCatagories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneltop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddCata = new FontAwesome.Sharp.IconButton();
            this.btnUpdatecata = new FontAwesome.Sharp.IconButton();
            this.btn_cata_delete = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtcatagory = new MetroFramework.Controls.MetroTextBox();
            this.labelCata = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroGrid_cata = new MetroFramework.Controls.MetroGrid();
            this.paneltop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_cata)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.Controls.Add(this.panel3);
            this.paneltop.Controls.Add(this.panel2);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(848, 43);
            this.paneltop.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddCata);
            this.panel3.Controls.Add(this.btnUpdatecata);
            this.panel3.Controls.Add(this.btn_cata_delete);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(619, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 43);
            this.panel3.TabIndex = 4;
            // 
            // btnAddCata
            // 
            this.btnAddCata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCata.FlatAppearance.BorderSize = 0;
            this.btnAddCata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCata.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCata.ForeColor = System.Drawing.Color.Black;
            this.btnAddCata.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            this.btnAddCata.IconColor = System.Drawing.SystemColors.ControlDark;
            this.btnAddCata.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCata.IconSize = 32;
            this.btnAddCata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCata.Location = new System.Drawing.Point(3, 6);
            this.btnAddCata.Name = "btnAddCata";
            this.btnAddCata.Size = new System.Drawing.Size(51, 22);
            this.btnAddCata.TabIndex = 3;
            this.btnAddCata.Text = "Add";
            this.btnAddCata.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCata.UseVisualStyleBackColor = true;
            this.btnAddCata.Click += new System.EventHandler(this.btnAddCata_Click);
            // 
            // btnUpdatecata
            // 
            this.btnUpdatecata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdatecata.FlatAppearance.BorderSize = 0;
            this.btnUpdatecata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatecata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnUpdatecata.ForeColor = System.Drawing.Color.DarkGray;
            this.btnUpdatecata.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdatecata.IconColor = System.Drawing.Color.DarkGray;
            this.btnUpdatecata.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdatecata.IconSize = 32;
            this.btnUpdatecata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdatecata.Location = new System.Drawing.Point(75, 6);
            this.btnUpdatecata.Name = "btnUpdatecata";
            this.btnUpdatecata.Size = new System.Drawing.Size(61, 22);
            this.btnUpdatecata.TabIndex = 3;
            this.btnUpdatecata.Text = "Update";
            this.btnUpdatecata.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdatecata.UseVisualStyleBackColor = true;
            this.btnUpdatecata.Click += new System.EventHandler(this.btnUpdatecata_Click);
            // 
            // btn_cata_delete
            // 
            this.btn_cata_delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cata_delete.FlatAppearance.BorderSize = 0;
            this.btn_cata_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cata_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btn_cata_delete.ForeColor = System.Drawing.Color.Red;
            this.btn_cata_delete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_cata_delete.IconColor = System.Drawing.Color.Red;
            this.btn_cata_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cata_delete.IconSize = 32;
            this.btn_cata_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cata_delete.Location = new System.Drawing.Point(160, 6);
            this.btn_cata_delete.Name = "btn_cata_delete";
            this.btn_cata_delete.Size = new System.Drawing.Size(57, 22);
            this.btn_cata_delete.TabIndex = 3;
            this.btn_cata_delete.Text = "Delete";
            this.btn_cata_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cata_delete.UseVisualStyleBackColor = true;
            this.btn_cata_delete.Click += new System.EventHandler(this.btn_cata_delete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtcatagory);
            this.panel2.Controls.Add(this.labelCata);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 43);
            this.panel2.TabIndex = 3;
            // 
            // txtcatagory
            // 
            this.txtcatagory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.txtcatagory.CustomButton.Image = null;
            this.txtcatagory.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.txtcatagory.CustomButton.Name = "";
            this.txtcatagory.CustomButton.Size = new System.Drawing.Size(11, 11);
            this.txtcatagory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcatagory.CustomButton.TabIndex = 1;
            this.txtcatagory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcatagory.CustomButton.UseSelectable = true;
            this.txtcatagory.CustomButton.Visible = false;
            this.txtcatagory.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtcatagory.Lines = new string[0];
            this.txtcatagory.Location = new System.Drawing.Point(21, 12);
            this.txtcatagory.MaxLength = 32767;
            this.txtcatagory.Name = "txtcatagory";
            this.txtcatagory.PasswordChar = '\0';
            this.txtcatagory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcatagory.SelectedText = "";
            this.txtcatagory.SelectionLength = 0;
            this.txtcatagory.SelectionStart = 0;
            this.txtcatagory.ShortcutsEnabled = true;
            this.txtcatagory.Size = new System.Drawing.Size(190, 16);
            this.txtcatagory.TabIndex = 1;
            this.txtcatagory.UseSelectable = true;
            this.txtcatagory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcatagory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelCata
            // 
            this.labelCata.BackColor = System.Drawing.Color.Transparent;
            this.labelCata.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCata.Location = new System.Drawing.Point(18, 0);
            this.labelCata.Name = "labelCata";
            this.labelCata.Size = new System.Drawing.Size(102, 16);
            this.labelCata.TabIndex = 2;
            this.labelCata.Text = "Catagory Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroGrid_cata);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 416);
            this.panel1.TabIndex = 2;
            // 
            // metroGrid_cata
            // 
            this.metroGrid_cata.AllowUserToOrderColumns = true;
            this.metroGrid_cata.AllowUserToResizeRows = false;
            this.metroGrid_cata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid_cata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_cata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid_cata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid_cata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_cata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid_cata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid_cata.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid_cata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid_cata.EnableHeadersVisualStyles = false;
            this.metroGrid_cata.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid_cata.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_cata.Location = new System.Drawing.Point(0, 0);
            this.metroGrid_cata.Name = "metroGrid_cata";
            this.metroGrid_cata.ReadOnly = true;
            this.metroGrid_cata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_cata.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid_cata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid_cata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid_cata.Size = new System.Drawing.Size(848, 416);
            this.metroGrid_cata.TabIndex = 2;
            this.metroGrid_cata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid_cata_CellClick);
            // 
            // AddCatagories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paneltop);
            this.Name = "AddCatagories";
            this.Text = "AddCatagories";
            this.Load += new System.EventHandler(this.AddCatagories_Load);
            this.paneltop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_cata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private FontAwesome.Sharp.IconButton btn_cata_delete;
        private System.Windows.Forms.Label labelCata;
        private MetroFramework.Controls.MetroTextBox txtcatagory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnAddCata;
        private FontAwesome.Sharp.IconButton btnUpdatecata;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroGrid metroGrid_cata;
    }
}