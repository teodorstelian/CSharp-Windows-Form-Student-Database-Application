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
    public partial class FormMainMenu : Form
    {

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
    }
}
