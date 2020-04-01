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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private void username_Click(object sender, EventArgs e)
		{
			username.Clear();
			//userImg.BackgroundImage = Properties.Resources.ProfileWhite1;
			userBar.BackColor = Color.FromArgb(74, 184, 206);
			username.ForeColor = Color.FromArgb(74, 184, 206);

			//userImg.BackgroundImage = Properties.Resources.ProfileWhite;
			passBar.BackColor = Color.WhiteSmoke;
			password.ForeColor = Color.WhiteSmoke;

			//emailImg.BackgroundImage = Properties.Resources.MailBlue;
			mailBar.BackColor = Color.WhiteSmoke;
			email.ForeColor = Color.WhiteSmoke;
		}

		private void password_Click(object sender, EventArgs e)
		{
			password.Clear();

			//userImg.BackgroundImage = Properties.Resources.ProfileWhite;
			userBar.BackColor = Color.WhiteSmoke;
			username.ForeColor = Color.WhiteSmoke;

			//userImg.BackgroundImage = Properties.Resources.ProfileWhite;
			passBar.BackColor = Color.FromArgb(74, 184, 206);
			password.ForeColor = Color.FromArgb(74, 184, 206);


			//emailImg.BackgroundImage = Properties.Resources.MailBlue;
			mailBar.BackColor = Color.WhiteSmoke;
			email.ForeColor = Color.WhiteSmoke;
		}

		private void email_Click(object sender, EventArgs e)
		{
			email.Clear();

			//userImg.BackgroundImage = Properties.Resources.ProfileWhite;
			userBar.BackColor = Color.WhiteSmoke;
			username.ForeColor = Color.WhiteSmoke;

			//passImg.BackgroundImage = Properties.Resources.Lock;
			passBar.BackColor = Color.WhiteSmoke;
			password.ForeColor = Color.WhiteSmoke;

			//emailImg.BackgroundImage = Properties.Resources.MailBlue;
			mailBar.BackColor = Color.FromArgb(74, 184, 206);
			email.ForeColor = Color.FromArgb(74, 184, 206);
		}

	}
}
