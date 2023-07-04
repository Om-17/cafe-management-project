using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FormMainMenu()
        {
        
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible=false;
            this.Text = String.Empty;
            //this.ControlBox = false;
            this.MaximizedBounds=Screen.FromHandle(this.Handle).WorkingArea;

        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(IconButton))
                {
                    previousBtn.BackColor = Color.FromArgb(33, 47, 61);
                    previousBtn.ForeColor = Color.WhiteSmoke;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null) {
                if(currentButton!=(IconButton)btnSender)
                {
                    DisableButton();
                    Color color= SelectThemeColor();
                    currentButton=(IconButton)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font= new System.Drawing.Font("Microsoft Sans Serif", 11.50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor= color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
      

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AddCustomer(), sender);
          

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProduct(), sender);

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void btnFiance_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);


        }

       
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitle.BackColor = Color.FromArgb(186, 74, 0);
            panelLogo.BackColor = Color.FromArgb(135, 54, 0);
            currentButton = null;
            btnCloseChildForm.Visible= false;

        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btnCloseChildForm_Click_1(object sender, EventArgs e)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
