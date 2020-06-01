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
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace LoginForm
{
	public partial class RegisterForm : Form
	{
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr Handle, int Msg, int Param1, int Param2);


		public RegisterForm()
		{
			InitializeComponent();

			usernameRegister.ForeColor = Color.FromArgb(3, 174, 218);
			usernameRegister.Text = "Username";


			passwordRegister.ForeColor = Color.FromArgb(3, 174, 218);
			passwordRegister.UseSystemPasswordChar = false;
			passwordRegister.Text = "Password";

			confirmPasswordRegister.ForeColor = Color.FromArgb(3, 174, 218);
			confirmPasswordRegister.UseSystemPasswordChar = false;
			confirmPasswordRegister.Text = "Confirm Password";

			emailRegister.ForeColor = Color.FromArgb(3, 174, 218);
			emailRegister.Text = "Email";
		}


		/// <summary>
		///  Register method - Determins if a user has been inserted or not.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void  register_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(usernameRegister.Text))
			{
				passwordRegisterError.Clear();
				usernameRegisterError.Text = "Please enter your username";
				return;

			}
			else if (string.IsNullOrEmpty(passwordRegister.Text))
			{
				usernameRegisterError.Clear();
				passwordRegisterError.Text = "Please enter your password";
				return;
			}

			if (passwordRegister.Text != confirmPasswordRegister.Text)
			{
				confirmPasswordRegisterError.Text = "Password don't match!";
				return;
			}

			Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);

			if (reg.IsMatch(emailRegister.Text) == false)
			{
				usernameRegisterError.Clear();
				passwordRegisterError.Clear();
				confirmPasswordRegisterError.Clear();
				emailRegisterError.Text = "Email is not valid";
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
		/// Shows the main menu of the application
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mainMenu_Click(object sender, EventArgs e)
		{
			FormMainMenu Menu = new FormMainMenu();
			this.Hide();
			Menu.ShowDialog();
			this.Close();
		}


        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }


		/// <summary>
		///  Changes the color of both, the username textBox and the text.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void usernameRegister_Click(object sender, EventArgs e)
		{
			usernameRegister.Clear();

			userBarRegister.BackColor = Color.FromArgb(3, 174, 218);
			usernameRegister.ForeColor = Color.FromArgb(3, 174, 218);

			passBarRegister.BackColor = Color.WhiteSmoke;
			passwordRegister.ForeColor = Color.WhiteSmoke;

			confirmPasswordRegister.ForeColor = Color.WhiteSmoke;
			confirmPassBar.BackColor = Color.WhiteSmoke;

			mailBarRegister.BackColor = Color.WhiteSmoke;
			emailRegister.ForeColor = Color.WhiteSmoke;
		}


		/// <summary>
		/// Changes the color of both, the password textBox and the text.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void passwordRegister_Click(object sender, EventArgs e)
		{
			passwordRegister.Clear();

			userBarRegister.BackColor = Color.WhiteSmoke;
			usernameRegister.ForeColor = Color.WhiteSmoke;

			passBarRegister.BackColor = Color.FromArgb(3, 174, 218);
			passwordRegister.ForeColor = Color.FromArgb(3, 174, 218);

			confirmPasswordRegister.ForeColor = Color.WhiteSmoke;
			confirmPassBar.BackColor = Color.WhiteSmoke;

			mailBarRegister.BackColor = Color.WhiteSmoke;
			emailRegister.ForeColor = Color.WhiteSmoke;
		}

		/// <summary>
		/// Changes the color of both, the confirmPAssword textBox and the text.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void confirmPasswordRegister_Click(object sender, EventArgs e)
		{
			confirmPasswordRegister.Clear();

			userBarRegister.BackColor = Color.WhiteSmoke;
			usernameRegister.ForeColor = Color.WhiteSmoke;

			passBarRegister.BackColor = Color.WhiteSmoke;
			passwordRegister.ForeColor = Color.WhiteSmoke;

			confirmPasswordRegister.ForeColor = Color.FromArgb(3, 174, 218);
			confirmPassBar.BackColor = Color.FromArgb(3, 174, 218);

			mailBarRegister.BackColor = Color.WhiteSmoke;
			emailRegister.ForeColor = Color.WhiteSmoke;
		}

		/// <summary>
		/// Changes the color of both, the email textBox and the text.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>

		private void emailRegister_Click(object sender, EventArgs e)
		{
			emailRegister.Clear();

			userBarRegister.BackColor = Color.WhiteSmoke;
			usernameRegister.ForeColor = Color.WhiteSmoke;

			passBarRegister.BackColor = Color.WhiteSmoke;
			passwordRegister.ForeColor = Color.WhiteSmoke;

			confirmPasswordRegister.ForeColor = Color.WhiteSmoke;
			confirmPassBar.BackColor = Color.WhiteSmoke;

			mailBarRegister.BackColor = Color.FromArgb(3, 174, 218);
			emailRegister.ForeColor = Color.FromArgb(3, 174, 218);
		}

		private void facebook_Click(object sender, EventArgs e)
		{
			facebookService1.ConnectToFacebook();
		}
	}
}
