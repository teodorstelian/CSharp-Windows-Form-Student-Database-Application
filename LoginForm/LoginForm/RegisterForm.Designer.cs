namespace LoginForm
{
	partial class RegisterForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
			this.register = new System.Windows.Forms.Button();
			this.mainMenu = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.instagram = new System.Windows.Forms.PictureBox();
			this.facebook = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.confirmPassBar = new System.Windows.Forms.FlowLayoutPanel();
			this.confirmPasswordRegister = new System.Windows.Forms.TextBox();
			this.confirmPassImg = new System.Windows.Forms.PictureBox();
			this.emailRegister = new System.Windows.Forms.TextBox();
			this.mailBarRegister = new System.Windows.Forms.FlowLayoutPanel();
			this.emailImg = new System.Windows.Forms.PictureBox();
			this.passBarRegister = new System.Windows.Forms.FlowLayoutPanel();
			this.passwordRegister = new System.Windows.Forms.TextBox();
			this.passImg = new System.Windows.Forms.PictureBox();
			this.userBarRegister = new System.Windows.Forms.FlowLayoutPanel();
			this.usernameRegister = new System.Windows.Forms.TextBox();
			this.userImg = new System.Windows.Forms.PictureBox();
			this.usernameRegisterError = new System.Windows.Forms.TextBox();
			this.passwordRegisterError = new System.Windows.Forms.TextBox();
			this.confirmPasswordRegisterError = new System.Windows.Forms.TextBox();
			this.emailRegisterError = new System.Windows.Forms.TextBox();
			this.facebookService1 = new Facebook.Winforms.Components.FacebookService(this.components);
			((System.ComponentModel.ISupportInitialize)(this.instagram)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.facebook)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.confirmPassImg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emailImg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.passImg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userImg)).BeginInit();
			this.SuspendLayout();
			// 
			// register
			// 
			this.register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
			this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.register.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.register.Location = new System.Drawing.Point(110, 377);
			this.register.Margin = new System.Windows.Forms.Padding(2);
			this.register.Name = "register";
			this.register.Size = new System.Drawing.Size(188, 32);
			this.register.TabIndex = 10;
			this.register.Text = "Register";
			this.register.UseVisualStyleBackColor = false;
			this.register.Click += new System.EventHandler(this.register_Click);
			// 
			// mainMenu
			// 
			this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.mainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mainMenu.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mainMenu.ForeColor = System.Drawing.Color.LightGray;
			this.mainMenu.Location = new System.Drawing.Point(110, 436);
			this.mainMenu.Margin = new System.Windows.Forms.Padding(2);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(188, 32);
			this.mainMenu.TabIndex = 12;
			this.mainMenu.Text = "Main Menu";
			this.mainMenu.UseVisualStyleBackColor = false;
			this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.LightGray;
			this.label1.Location = new System.Drawing.Point(170, 493);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 14;
			this.label1.Text = "register with";
			// 
			// instagram
			// 
			this.instagram.Image = ((System.Drawing.Image)(resources.GetObject("instagram.Image")));
			this.instagram.Location = new System.Drawing.Point(255, 529);
			this.instagram.Margin = new System.Windows.Forms.Padding(2);
			this.instagram.Name = "instagram";
			this.instagram.Size = new System.Drawing.Size(43, 46);
			this.instagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.instagram.TabIndex = 13;
			this.instagram.TabStop = false;
			// 
			// facebook
			// 
			this.facebook.Image = ((System.Drawing.Image)(resources.GetObject("facebook.Image")));
			this.facebook.Location = new System.Drawing.Point(110, 529);
			this.facebook.Margin = new System.Windows.Forms.Padding(2);
			this.facebook.Name = "facebook";
			this.facebook.Size = new System.Drawing.Size(43, 46);
			this.facebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.facebook.TabIndex = 11;
			this.facebook.TabStop = false;
			this.facebook.Click += new System.EventHandler(this.facebook_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(174, 11);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(72, 64);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// confirmPassBar
			// 
			this.confirmPassBar.BackColor = System.Drawing.Color.White;
			this.confirmPassBar.Location = new System.Drawing.Point(108, 265);
			this.confirmPassBar.Margin = new System.Windows.Forms.Padding(2);
			this.confirmPassBar.Name = "confirmPassBar";
			this.confirmPassBar.Size = new System.Drawing.Size(188, 1);
			this.confirmPassBar.TabIndex = 42;
			// 
			// confirmPasswordRegister
			// 
			this.confirmPasswordRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.confirmPasswordRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.confirmPasswordRegister.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.confirmPasswordRegister.ForeColor = System.Drawing.Color.LightGray;
			this.confirmPasswordRegister.Location = new System.Drawing.Point(136, 241);
			this.confirmPasswordRegister.Margin = new System.Windows.Forms.Padding(2);
			this.confirmPasswordRegister.Name = "confirmPasswordRegister";
			this.confirmPasswordRegister.Size = new System.Drawing.Size(156, 17);
			this.confirmPasswordRegister.TabIndex = 41;
			this.confirmPasswordRegister.TabStop = false;
			this.confirmPasswordRegister.UseSystemPasswordChar = true;
			this.confirmPasswordRegister.Click += new System.EventHandler(this.confirmPasswordRegister_Click);
			// 
			// confirmPassImg
			// 
			this.confirmPassImg.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.confirmPassImg.Image = ((System.Drawing.Image)(resources.GetObject("confirmPassImg.Image")));
			this.confirmPassImg.Location = new System.Drawing.Point(109, 233);
			this.confirmPassImg.Margin = new System.Windows.Forms.Padding(2);
			this.confirmPassImg.Name = "confirmPassImg";
			this.confirmPassImg.Size = new System.Drawing.Size(23, 25);
			this.confirmPassImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.confirmPassImg.TabIndex = 40;
			this.confirmPassImg.TabStop = false;
			// 
			// emailRegister
			// 
			this.emailRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.emailRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.emailRegister.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailRegister.ForeColor = System.Drawing.Color.LightGray;
			this.emailRegister.Location = new System.Drawing.Point(140, 304);
			this.emailRegister.Margin = new System.Windows.Forms.Padding(2);
			this.emailRegister.Name = "emailRegister";
			this.emailRegister.Size = new System.Drawing.Size(156, 17);
			this.emailRegister.TabIndex = 39;
			this.emailRegister.Click += new System.EventHandler(this.emailRegister_Click);
			// 
			// mailBarRegister
			// 
			this.mailBarRegister.BackColor = System.Drawing.Color.White;
			this.mailBarRegister.Location = new System.Drawing.Point(109, 329);
			this.mailBarRegister.Margin = new System.Windows.Forms.Padding(2);
			this.mailBarRegister.Name = "mailBarRegister";
			this.mailBarRegister.Size = new System.Drawing.Size(188, 1);
			this.mailBarRegister.TabIndex = 38;
			// 
			// emailImg
			// 
			this.emailImg.Image = ((System.Drawing.Image)(resources.GetObject("emailImg.Image")));
			this.emailImg.Location = new System.Drawing.Point(109, 296);
			this.emailImg.Margin = new System.Windows.Forms.Padding(2);
			this.emailImg.Name = "emailImg";
			this.emailImg.Size = new System.Drawing.Size(23, 25);
			this.emailImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.emailImg.TabIndex = 37;
			this.emailImg.TabStop = false;
			// 
			// passBarRegister
			// 
			this.passBarRegister.BackColor = System.Drawing.Color.White;
			this.passBarRegister.Location = new System.Drawing.Point(109, 197);
			this.passBarRegister.Margin = new System.Windows.Forms.Padding(2);
			this.passBarRegister.Name = "passBarRegister";
			this.passBarRegister.Size = new System.Drawing.Size(188, 1);
			this.passBarRegister.TabIndex = 36;
			// 
			// passwordRegister
			// 
			this.passwordRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.passwordRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordRegister.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordRegister.ForeColor = System.Drawing.Color.LightGray;
			this.passwordRegister.Location = new System.Drawing.Point(137, 173);
			this.passwordRegister.Margin = new System.Windows.Forms.Padding(2);
			this.passwordRegister.Name = "passwordRegister";
			this.passwordRegister.Size = new System.Drawing.Size(156, 17);
			this.passwordRegister.TabIndex = 35;
			this.passwordRegister.TabStop = false;
			this.passwordRegister.UseSystemPasswordChar = true;
			this.passwordRegister.Click += new System.EventHandler(this.passwordRegister_Click);
			// 
			// passImg
			// 
			this.passImg.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.passImg.Image = ((System.Drawing.Image)(resources.GetObject("passImg.Image")));
			this.passImg.Location = new System.Drawing.Point(110, 165);
			this.passImg.Margin = new System.Windows.Forms.Padding(2);
			this.passImg.Name = "passImg";
			this.passImg.Size = new System.Drawing.Size(23, 25);
			this.passImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.passImg.TabIndex = 34;
			this.passImg.TabStop = false;
			// 
			// userBarRegister
			// 
			this.userBarRegister.BackColor = System.Drawing.Color.White;
			this.userBarRegister.Location = new System.Drawing.Point(110, 136);
			this.userBarRegister.Margin = new System.Windows.Forms.Padding(2);
			this.userBarRegister.Name = "userBarRegister";
			this.userBarRegister.Size = new System.Drawing.Size(188, 1);
			this.userBarRegister.TabIndex = 33;
			// 
			// usernameRegister
			// 
			this.usernameRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.usernameRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.usernameRegister.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameRegister.ForeColor = System.Drawing.Color.LightGray;
			this.usernameRegister.Location = new System.Drawing.Point(139, 111);
			this.usernameRegister.Margin = new System.Windows.Forms.Padding(2);
			this.usernameRegister.Name = "usernameRegister";
			this.usernameRegister.Size = new System.Drawing.Size(156, 17);
			this.usernameRegister.TabIndex = 32;
			this.usernameRegister.TabStop = false;
			this.usernameRegister.Click += new System.EventHandler(this.usernameRegister_Click);
			// 
			// userImg
			// 
			this.userImg.Image = global::LoginForm.Properties.Resources.user1;
			this.userImg.Location = new System.Drawing.Point(110, 102);
			this.userImg.Margin = new System.Windows.Forms.Padding(2);
			this.userImg.Name = "userImg";
			this.userImg.Size = new System.Drawing.Size(23, 26);
			this.userImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.userImg.TabIndex = 31;
			this.userImg.TabStop = false;
			// 
			// usernameRegisterError
			// 
			this.usernameRegisterError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.usernameRegisterError.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.usernameRegisterError.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameRegisterError.ForeColor = System.Drawing.Color.OrangeRed;
			this.usernameRegisterError.Location = new System.Drawing.Point(110, 144);
			this.usernameRegisterError.Margin = new System.Windows.Forms.Padding(2);
			this.usernameRegisterError.Name = "usernameRegisterError";
			this.usernameRegisterError.Size = new System.Drawing.Size(188, 17);
			this.usernameRegisterError.TabIndex = 43;
			this.usernameRegisterError.TabStop = false;
			// 
			// passwordRegisterError
			// 
			this.passwordRegisterError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.passwordRegisterError.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordRegisterError.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordRegisterError.ForeColor = System.Drawing.Color.OrangeRed;
			this.passwordRegisterError.Location = new System.Drawing.Point(109, 202);
			this.passwordRegisterError.Margin = new System.Windows.Forms.Padding(2);
			this.passwordRegisterError.Name = "passwordRegisterError";
			this.passwordRegisterError.Size = new System.Drawing.Size(188, 17);
			this.passwordRegisterError.TabIndex = 44;
			this.passwordRegisterError.TabStop = false;
			// 
			// confirmPasswordRegisterError
			// 
			this.confirmPasswordRegisterError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.confirmPasswordRegisterError.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.confirmPasswordRegisterError.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.confirmPasswordRegisterError.ForeColor = System.Drawing.Color.OrangeRed;
			this.confirmPasswordRegisterError.Location = new System.Drawing.Point(109, 273);
			this.confirmPasswordRegisterError.Margin = new System.Windows.Forms.Padding(2);
			this.confirmPasswordRegisterError.Name = "confirmPasswordRegisterError";
			this.confirmPasswordRegisterError.Size = new System.Drawing.Size(188, 17);
			this.confirmPasswordRegisterError.TabIndex = 45;
			this.confirmPasswordRegisterError.TabStop = false;
			// 
			// emailRegisterError
			// 
			this.emailRegisterError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.emailRegisterError.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.emailRegisterError.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailRegisterError.ForeColor = System.Drawing.Color.OrangeRed;
			this.emailRegisterError.Location = new System.Drawing.Point(108, 334);
			this.emailRegisterError.Margin = new System.Windows.Forms.Padding(2);
			this.emailRegisterError.Name = "emailRegisterError";
			this.emailRegisterError.Size = new System.Drawing.Size(188, 17);
			this.emailRegisterError.TabIndex = 46;
			this.emailRegisterError.TabStop = false;
			// 
			// facebookService1
			// 
			this.facebookService1.ApplicationKey = "344921126478071|n-Qbz9E0igO6K3sjwG_7iZAucWQ";
			this.facebookService1.SessionKey = null;
			this.facebookService1.uid = ((long)(0));
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
			this.ClientSize = new System.Drawing.Size(433, 600);
			this.Controls.Add(this.emailRegisterError);
			this.Controls.Add(this.confirmPasswordRegisterError);
			this.Controls.Add(this.passwordRegisterError);
			this.Controls.Add(this.usernameRegisterError);
			this.Controls.Add(this.confirmPassBar);
			this.Controls.Add(this.confirmPasswordRegister);
			this.Controls.Add(this.confirmPassImg);
			this.Controls.Add(this.emailRegister);
			this.Controls.Add(this.mailBarRegister);
			this.Controls.Add(this.emailImg);
			this.Controls.Add(this.passBarRegister);
			this.Controls.Add(this.passwordRegister);
			this.Controls.Add(this.passImg);
			this.Controls.Add(this.userBarRegister);
			this.Controls.Add(this.usernameRegister);
			this.Controls.Add(this.userImg);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.instagram);
			this.Controls.Add(this.mainMenu);
			this.Controls.Add(this.facebook);
			this.Controls.Add(this.register);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "RegisterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.instagram)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.facebook)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.confirmPassImg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emailImg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.passImg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userImg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button register;
		private System.Windows.Forms.PictureBox facebook;
		private System.Windows.Forms.Button mainMenu;
		private System.Windows.Forms.PictureBox instagram;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel confirmPassBar;
		private System.Windows.Forms.TextBox confirmPasswordRegister;
		private System.Windows.Forms.PictureBox confirmPassImg;
		private System.Windows.Forms.TextBox emailRegister;
		private System.Windows.Forms.FlowLayoutPanel mailBarRegister;
		private System.Windows.Forms.PictureBox emailImg;
		private System.Windows.Forms.FlowLayoutPanel passBarRegister;
		private System.Windows.Forms.TextBox passwordRegister;
		private System.Windows.Forms.PictureBox passImg;
		private System.Windows.Forms.FlowLayoutPanel userBarRegister;
		private System.Windows.Forms.TextBox usernameRegister;
		private System.Windows.Forms.PictureBox userImg;
		private System.Windows.Forms.TextBox usernameRegisterError;
		private System.Windows.Forms.TextBox passwordRegisterError;
		private System.Windows.Forms.TextBox confirmPasswordRegisterError;
		private System.Windows.Forms.TextBox emailRegisterError;
		private Facebook.Winforms.Components.FacebookService facebookService1;
	}
}

