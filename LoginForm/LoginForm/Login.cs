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
using Dapper;

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

		private void loginButton_Click(object sender, EventArgs e)
		{
			//Check username is null or empty
			if (string.IsNullOrEmpty(emailLogin.Text))
			{
				MessageBox.Show(this, "Please enter your email.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				emailLogin.Focus();
				return;
			}
			try
			{
				using (IDbConnection db = new SqlConnection(AppHelper.ConnectionString))
				{
					if (db.State == ConnectionState.Closed)
						db.Open();
					//Excute sql query, then map data return from sql to User class
					User obj = db.Query<User>($"select *from Users where Email = '{emailLogin.Text}'", commandType: CommandType.Text).SingleOrDefault();
					if (obj != null)
					{
						if (obj.Password == passwordLogin.Text)//True
						{
							using (MainApp frm = new MainApp())//Open main form and hide login form
							{
								this.Hide();
								frm.ShowDialog();
							}
						}
						else
							MessageBox.Show(this, "Your username and password don't match.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
						MessageBox.Show(this, "Your username and password don't match.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


			/*	MainApp User = new MainApp();
				this.Hide();
				User.ShowDialog();
				this.Close();*/

		}

		private void MainMenuButton_Click(object sender, EventArgs e)
		{
			FormMainMenu Menu = new FormMainMenu();
			this.Hide();
			Menu.ShowDialog();
			this.Close();
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}
	}
}
