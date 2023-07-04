using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_management_system
{
    public partial class Menu :Form
    {
        public Menu(string role)
        {
            InitializeComponent();
            rolestatus.Text = role;
        }
        bool sidebarExpand;
        bool homeCollapsed;
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Tidebar_Timer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) {
                sidebar.Width -= 10;
                if(sidebar.Width==sidebar.MinimumSize.Width){
                    sidebartimer.Stop();
                    sidebarExpand = false;
                }
            
            }
            else
            {
                sidebar.Width += 10;

                if(sidebar.Width== sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebartimer.Stop();
                }
            }

        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }

        private void home_timer_Tick(object sender, EventArgs e)
        {
            if (homeCollapsed)
            {
                homecontainer.Height += 10;
                if(homecontainer.Height==homecontainer.MaximumSize.Height) {
                    homeCollapsed = false;
                    home_timer.Stop();
                }

            }
            else
            {
                homecontainer.Height -= 10;
                if(homecontainer.Height== homecontainer.MinimumSize.Height)
                {
                    homeCollapsed = true;
                    home_timer.Stop();
                }
            }

        }

        private void home_Click(object sender, EventArgs e)
        {
            home_timer.Start();
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void expand_Click(object sender, EventArgs e)
        {
           if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rolestatus_Click(object sender, EventArgs e)
        {

        }
    }
}
