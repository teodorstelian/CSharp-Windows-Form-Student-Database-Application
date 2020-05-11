using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LoginForm
{
	public partial class RegisterForm : Form
	{

		public RegisterForm()
		{
			InitializeComponent();
		}


		private async void  register_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(usernameRegister.Text))
			{
				MessageBox.Show("Please enter your username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
			if(passwordRegister.Text != confirmPasswordRegister.Text)
			{
				MessageBox.Show("Password don't match! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			IUserRepository repository = new UserRepository();
			bool result = await repository.Insert(new User() { UserName = usernameRegister.Text, Password = passwordRegister.Text, Email = emailRegister.Text });

			if (result)
			{
				MessageBox.Show("You have successfully signed in", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
				MessageBox.Show("Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void mainMenu_Click(object sender, EventArgs e)
		{
			FormMainMenu Menu = new FormMainMenu();
			this.Hide();
			Menu.ShowDialog();
			this.Close();
		}

	}
}
