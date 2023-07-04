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

namespace CMS
{
    public partial class AddModelSample : Form
    {
        public AddModelSample()
        {
            InitializeComponent();
            ThemeLoad();
        }
        public void ThemeLoad()
        {
            panelheader.BackColor = ThemeColor.PrimaryColor;
            foreach (Control btns in panelfooter.Controls)
            {
                if (btns.GetType() == typeof(IconButton))
                {

                    IconButton btn = (IconButton)btns;
                    btn.BackColor= ThemeColor.PrimaryColor;
                    btn.ForeColor= Color.White;
                    btn.IconColor=Color.White;


                }
            }
        }
        public virtual void iconButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public virtual void iconButtonSave_Click(object sender, EventArgs e)
        {

        }

        private void AddModelSample_Load(object sender, EventArgs e)
        {

        }
    }
}
