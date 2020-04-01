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
	public partial class RegisterForm : Form
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		/// <summary>
		///  Metoda care schimba culoarea textului din textboxul username si a panelului de dedesupt.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void username_Click(object sender, EventArgs e)
		{
			usernameRegister.Clear();
			
			userBarRegister.BackColor = Color.FromArgb(3, 174, 218);
			usernameRegister.ForeColor = Color.FromArgb(3, 174, 218);

			passBarRegister.BackColor = Color.WhiteSmoke;
			passwordRegister.ForeColor = Color.WhiteSmoke;

			mailBarRegister.BackColor = Color.WhiteSmoke;
			emailRegister.ForeColor = Color.WhiteSmoke;
		}


		/// <summary>
		/// Metoda care schimba culoarea textului din textboxul password si a panelului de dedesupt.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void password_Click(object sender, EventArgs e)
		{
			passwordRegister.Clear();

			userBarRegister.BackColor = Color.WhiteSmoke;
			usernameRegister.ForeColor = Color.WhiteSmoke;

			passBarRegister.BackColor = Color.FromArgb(3, 174, 218);
			passwordRegister.ForeColor = Color.FromArgb(3, 174, 218);

			mailBarRegister.BackColor = Color.WhiteSmoke;
			emailRegister.ForeColor = Color.WhiteSmoke;
		}

		/// <summary>
		/// Metoda care schimba culoarea textului din textboxul email si a panelului de dedesupt.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void email_Click(object sender, EventArgs e)
		{
			emailRegister.Clear();

			userBarRegister.BackColor = Color.WhiteSmoke;
			usernameRegister.ForeColor = Color.WhiteSmoke;

			passBarRegister.BackColor = Color.WhiteSmoke;
			passwordRegister.ForeColor = Color.WhiteSmoke;

			mailBarRegister.BackColor = Color.FromArgb(3, 174, 218);
			emailRegister.ForeColor = Color.FromArgb(3, 174, 218);
		}

		private void register_Click(object sender, EventArgs e)
		{
			MainApp User = new MainApp();
			this.Hide();
			User.ShowDialog();
			this.Close();
		}

		private void mainMenu_Click(object sender, EventArgs e)
		{
			FormMainMenu Menu = new FormMainMenu();
			this.Hide();
			Menu.ShowDialog();
			this.Close();
		}
	}
}
