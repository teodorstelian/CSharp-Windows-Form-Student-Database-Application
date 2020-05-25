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

namespace LoginForm
{
    public partial class FormMainMenu : Form
    {
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr Handle, int Msg, int Param1, int Param2);

        public FormMainMenu()
        {

            InitializeComponent();

        }

        /// <summary>
        /// Quit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitMenuBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        /// <summary>
        /// Shows the register form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterMenuBTN_Click(object sender, EventArgs e)
        {
            RegisterForm Register = new RegisterForm();
            this.Hide();
            Register.ShowDialog();
            this.Close();

        }

        /// <summary>
        /// Shows the Login Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginMenuBTN_Click(object sender, EventArgs e)
        {
            Login Log = new Login();
            this.Hide();
            Log.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelSideMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
    }
}
