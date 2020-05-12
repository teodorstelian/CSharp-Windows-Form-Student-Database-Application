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
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
          
        }

        private void panelLoginSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void button3_Click_1(object sender, EventArgs e)
        {
            MainApp Main = new MainApp();
            this.Hide();
            Main.ShowDialog();
            this.Close();

        }


        private void RegisterMenuBTN_Click(object sender, EventArgs e)
        {
            RegisterForm Register = new RegisterForm();
            this.Hide();
            Register.ShowDialog();
            this.Close();

        }

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
