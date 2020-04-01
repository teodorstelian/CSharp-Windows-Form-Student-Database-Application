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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void emailLogin_TextChanged(object sender, EventArgs e)
		{
			emailLogin.Clear();

			

			passBarLogin.BackColor = Color.WhiteSmoke;
			passwordLogin.ForeColor = Color.WhiteSmoke;

			mailBarLogin.BackColor = Color.FromArgb(3, 174, 218);
			emailLogin.ForeColor = Color.FromArgb(3, 174, 218);
		}

		private void passwordLogin_TextChanged(object sender, EventArgs e)
		{
			passwordLogin.Clear();

			passBarLogin.BackColor = Color.FromArgb(3, 174, 218);
			passwordLogin.ForeColor = Color.FromArgb(3, 174, 218);

			mailBarLogin.BackColor = Color.WhiteSmoke;
			emailLogin.ForeColor = Color.WhiteSmoke;
		}
	}
}
