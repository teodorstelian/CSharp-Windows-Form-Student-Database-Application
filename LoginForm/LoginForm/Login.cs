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
using Dapper;
using System.Text.RegularExpressions;

namespace LoginForm
{
	public partial class Login : Form
	{
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr Handle, int Msg, int Param1, int Param2);

		public Login()
		{
			InitializeComponent();

			emailLogin.ForeColor = Color.FromArgb(3, 174, 218);
			emailLogin.Text = "Email";

			passwordLogin.ForeColor = Color.FromArgb(3, 174, 218);
			passwordLogin.UseSystemPasswordChar = false;
			passwordLogin.Text = "Password";
		}

		private void closeErrorTb()
		{
			emailLoginError.Clear();
			passwordLoginError.Clear();
		}

		/// <summary>
		///  Changes the color of both, the emial textBox and the text.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void emailLogin_TextChanged(object sender, EventArgs e)
		{
			emailLogin.Clear();		

			passBarLogin.BackColor = Color.WhiteSmoke;
			passwordLogin.ForeColor = Color.WhiteSmoke;

			mailBarLogin.BackColor = Color.FromArgb(3, 174, 218);
			emailLogin.ForeColor = Color.FromArgb(3, 174, 218);
		}

		/// <summary>
		/// Changes the color of both, the password textBox and the text.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void passwordLogin_TextChanged(object sender, EventArgs e)
		{
			passwordLogin.Clear();

			passBarLogin.BackColor = Color.FromArgb(3, 174, 218);
			passwordLogin.ForeColor = Color.FromArgb(3, 174, 218);

			mailBarLogin.BackColor = Color.WhiteSmoke;
			emailLogin.ForeColor = Color.WhiteSmoke;

			closeErrorTb();
			if (Control.IsKeyLocked(Keys.CapsLock))
			{
				passwordLoginError.Text = "Caps is ON.";
			}
		}

		/// <summary>
		///  Register method - Determins if a user has been inserted or not.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void loginButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(emailLogin.Text))
			{
				closeErrorTb();
				emailLoginError.Text = "Please enter your email.";
				return;

			}
			else if (string.IsNullOrEmpty(passwordLogin.Text))
			{
				closeErrorTb();
				passwordLoginError.Text = "Please enter your email";
				return;
			}

			Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);

			if (reg.IsMatch(emailLogin.Text) == false && emailLogin.Text != "admin")  // Am adaugat aici exceptia pentru cand esti admin
			{
				closeErrorTb();
				emailLoginError.Text = "Email is not valid";
				return;
			}

			try
			{
				using (IDbConnection db = new SqlConnection(AppHelper.ConnectionString))
				{
					if (db.State == ConnectionState.Closed)
						db.Open();
					
					User obj = db.Query<User>($"select *from Users where Email = '{emailLogin.Text}'", commandType: CommandType.Text).SingleOrDefault();
					if (obj != null)
					{
						if (obj.Password == passwordLogin.Text)
						{
							using (MainApp frm = new MainApp())
							{
								this.Hide();
								frm.ShowDialog();
							}
						}
						else
							passwordLoginError.Text = "Your username and password don't match.";
					}
					else
						passwordLoginError.Text = "Your username and password don't match.";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		/// <summary>
		/// Displays the main menu of the application
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainMenuButton_Click(object sender, EventArgs e)
		{
			FormMainMenu Menu = new FormMainMenu();
			this.Hide();
			Menu.ShowDialog();
			this.Close();
		}

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
    }
}
