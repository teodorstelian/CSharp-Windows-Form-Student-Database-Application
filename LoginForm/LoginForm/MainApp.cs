using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
            customizeDesing();
            WelcomeUser();
        }

        private void WelcomeUser()
        {
            WelcomeLabel.Text = "Hello!";
        }

       private void customizeDesing()
        {
            panelLoginSubMenu.Visible = false;
            
        }

        private void hideSubMenu()
        {
            if (panelLoginSubMenu.Visible == true)
                panelLoginSubMenu.Visible = false;
        }

        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void panelLoginSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLoginSubMenu);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
