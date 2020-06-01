﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class MainApp : Form
    {

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr Handle, int Msg, int Param1, int Param2);

        public MainApp()
        {
            InitializeComponent();
            customizeDesing();
            WelcomeUser();
        }
        /// <summary>
        /// IN PROGRESS - Display the user inthe label
        /// </summary>
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
            FormMainMenu Menu = new FormMainMenu();
            this.Hide();
            Menu.ShowDialog();
            this.Close();
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

        private void panelSideMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void UniversitiesButton_Click(object sender, EventArgs e)
        {
            ListOfUniversities Univ = new ListOfUniversities();
            this.Hide();
            Univ.ShowDialog();
            this.Close();
        }
    }
}
