namespace CMS
{
    partial class AddModelSample
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
            this.panelheader = new System.Windows.Forms.Panel();
            this.labeltitle = new System.Windows.Forms.Label();
            this.pictureBoxlogo = new System.Windows.Forms.PictureBox();
            this.panelfooter = new System.Windows.Forms.Panel();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).BeginInit();
            this.panelfooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelheader
            // 
            this.panelheader.Controls.Add(this.labeltitle);
            this.panelheader.Controls.Add(this.pictureBoxlogo);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(798, 97);
            this.panelheader.TabIndex = 0;
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.Color.White;
            this.labeltitle.Location = new System.Drawing.Point(129, 35);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(76, 31);
            this.labeltitle.TabIndex = 1;
            this.labeltitle.Text = "label1";
            // 
            // pictureBoxlogo
            // 
            this.pictureBoxlogo.Image = global::CMS.Properties.Resources.cafelogo_3;
            this.pictureBoxlogo.Location = new System.Drawing.Point(12, 13);
            this.pictureBoxlogo.Name = "pictureBoxlogo";
            this.pictureBoxlogo.Size = new System.Drawing.Size(100, 72);
            this.pictureBoxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxlogo.TabIndex = 0;
            this.pictureBoxlogo.TabStop = false;
            // 
            // panelfooter
            // 
            this.panelfooter.BackColor = System.Drawing.Color.Gainsboro;
            this.panelfooter.Controls.Add(this.iconButtonClose);
            this.panelfooter.Controls.Add(this.iconButtonSave);
            this.panelfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelfooter.Location = new System.Drawing.Point(0, 408);
            this.panelfooter.Name = "panelfooter";
            this.panelfooter.Size = new System.Drawing.Size(798, 67);
            this.panelfooter.TabIndex = 1;
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonClose.ForeColor = System.Drawing.Color.White;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButtonClose.IconColor = System.Drawing.Color.White;
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose.IconSize = 32;
            this.iconButtonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonClose.Location = new System.Drawing.Point(682, 15);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(85, 38);
            this.iconButtonClose.TabIndex = 0;
            this.iconButtonClose.Text = "Close";
            this.iconButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonClose.UseVisualStyleBackColor = true;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // iconButtonSave
            // 
            this.iconButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSave.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSave.ForeColor = System.Drawing.Color.White;
            this.iconButtonSave.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.iconButtonSave.IconColor = System.Drawing.Color.White;
            this.iconButtonSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSave.IconSize = 32;
            this.iconButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSave.Location = new System.Drawing.Point(569, 15);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Size = new System.Drawing.Size(85, 38);
            this.iconButtonSave.TabIndex = 0;
            this.iconButtonSave.Text = "Save";
            this.iconButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonSave.UseVisualStyleBackColor = true;
            this.iconButtonSave.Click += new System.EventHandler(this.iconButtonSave_Click);
            // 
            // AddModelSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 475);
            this.Controls.Add(this.panelfooter);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddModelSample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddModelSample";
            this.Load += new System.EventHandler(this.AddModelSample_Load);
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).EndInit();
            this.panelfooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelheader;
        public System.Windows.Forms.Label labeltitle;
        public System.Windows.Forms.PictureBox pictureBoxlogo;
        public System.Windows.Forms.Panel panelfooter;
        public FontAwesome.Sharp.IconButton iconButtonClose;
        public FontAwesome.Sharp.IconButton iconButtonSave;
    }
}