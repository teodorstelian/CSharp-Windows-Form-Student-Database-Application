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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
			this.usernameRegister = new System.Windows.Forms.TextBox();
			this.userBarRegister = new System.Windows.Forms.FlowLayoutPanel();
			this.passBarRegister = new System.Windows.Forms.FlowLayoutPanel();
			this.passwordRegister = new System.Windows.Forms.TextBox();
			this.mailBarRegister = new System.Windows.Forms.FlowLayoutPanel();
			this.register = new System.Windows.Forms.Button();
			this.mainMenu = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.emailRegister = new System.Windows.Forms.TextBox();
			this.instagram = new System.Windows.Forms.PictureBox();
			this.facebook = new System.Windows.Forms.PictureBox();
			this.emailImg = new System.Windows.Forms.PictureBox();
			this.passImg = new System.Windows.Forms.PictureBox();
			this.userImg = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.instagram)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.facebook)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emailImg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.passImg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userImg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// usernameRegister
			// 
			this.usernameRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.usernameRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.usernameRegister.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameRegister.ForeColor = System.Drawing.Color.LightGray;
			this.usernameRegister.Location = new System.Drawing.Point(99, 130);
			this.usernameRegister.Name = "usernameRegister";
			this.usernameRegister.Size = new System.Drawing.Size(208, 21);
			this.usernameRegister.TabIndex = 2;
			this.usernameRegister.Click += new System.EventHandler(this.username_Click);
			// 
			// userBarRegister
			// 
			this.userBarRegister.BackColor = System.Drawing.Color.White;
			this.userBarRegister.Location = new System.Drawing.Point(60, 161);
			this.userBarRegister.Name = "userBarRegister";
			this.userBarRegister.Size = new System.Drawing.Size(250, 1);
			this.userBarRegister.TabIndex = 3;
			// 
			// passBarRegister
			// 
			this.passBarRegister.BackColor = System.Drawing.Color.White;
			this.passBarRegister.Location = new System.Drawing.Point(60, 219);
			this.passBarRegister.Name = "passBarRegister";
			this.passBarRegister.Size = new System.Drawing.Size(250, 1);
			this.passBarRegister.TabIndex = 6;
			// 
			// passwordRegister
			// 
			this.passwordRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.passwordRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordRegister.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordRegister.ForeColor = System.Drawing.Color.LightGray;
			this.passwordRegister.Location = new System.Drawing.Point(98, 189);
			this.passwordRegister.Name = "passwordRegister";
			this.passwordRegister.Size = new System.Drawing.Size(208, 21);
			this.passwordRegister.TabIndex = 5;
			this.passwordRegister.UseSystemPasswordChar = true;
			this.passwordRegister.Click += new System.EventHandler(this.password_Click);
			// 
			// mailBarRegister
			// 
			this.mailBarRegister.BackColor = System.Drawing.Color.White;
			this.mailBarRegister.Location = new System.Drawing.Point(60, 277);
			this.mailBarRegister.Name = "mailBarRegister";
			this.mailBarRegister.Size = new System.Drawing.Size(250, 1);
			this.mailBarRegister.TabIndex = 9;
			// 
			// register
			// 
			this.register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
			this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.register.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.register.Location = new System.Drawing.Point(60, 315);
			this.register.Name = "register";
			this.register.Size = new System.Drawing.Size(250, 40);
			this.register.TabIndex = 10;
			this.register.Text = "Register";
			this.register.UseVisualStyleBackColor = false;
			// 
			// mainMenu
			// 
			this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.mainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mainMenu.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mainMenu.ForeColor = System.Drawing.Color.LightGray;
			this.mainMenu.Location = new System.Drawing.Point(60, 376);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(250, 39);
			this.mainMenu.TabIndex = 12;
			this.mainMenu.Text = "Main Menu";
			this.mainMenu.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.LightGray;
			this.label1.Location = new System.Drawing.Point(143, 454);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 24);
			this.label1.TabIndex = 14;
			this.label1.Text = "register with";
			// 
			// emailRegister
			// 
			this.emailRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.emailRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.emailRegister.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailRegister.ForeColor = System.Drawing.Color.LightGray;
			this.emailRegister.Location = new System.Drawing.Point(101, 246);
			this.emailRegister.Name = "emailRegister";
			this.emailRegister.Size = new System.Drawing.Size(208, 21);
			this.emailRegister.TabIndex = 15;
			this.emailRegister.Click += new System.EventHandler(this.email_Click);
			// 
			// instagram
			// 
			this.instagram.Image = ((System.Drawing.Image)(resources.GetObject("instagram.Image")));
			this.instagram.Location = new System.Drawing.Point(249, 497);
			this.instagram.Name = "instagram";
			this.instagram.Size = new System.Drawing.Size(57, 57);
			this.instagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.instagram.TabIndex = 13;
			this.instagram.TabStop = false;
			// 
			// facebook
			// 
			this.facebook.Image = ((System.Drawing.Image)(resources.GetObject("facebook.Image")));
			this.facebook.Location = new System.Drawing.Point(60, 497);
			this.facebook.Name = "facebook";
			this.facebook.Size = new System.Drawing.Size(57, 57);
			this.facebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.facebook.TabIndex = 11;
			this.facebook.TabStop = false;
			// 
			// emailImg
			// 
			this.emailImg.Image = ((System.Drawing.Image)(resources.GetObject("emailImg.Image")));
			this.emailImg.Location = new System.Drawing.Point(60, 240);
			this.emailImg.Name = "emailImg";
			this.emailImg.Size = new System.Drawing.Size(31, 31);
			this.emailImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.emailImg.TabIndex = 7;
			this.emailImg.TabStop = false;
			// 
			// passImg
			// 
			this.passImg.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.passImg.Image = ((System.Drawing.Image)(resources.GetObject("passImg.Image")));
			this.passImg.Location = new System.Drawing.Point(60, 182);
			this.passImg.Name = "passImg";
			this.passImg.Size = new System.Drawing.Size(31, 31);
			this.passImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.passImg.TabIndex = 4;
			this.passImg.TabStop = false;
			// 
			// userImg
			// 
			this.userImg.Image = global::LoginForm.Properties.Resources.user1;
			this.userImg.Location = new System.Drawing.Point(60, 130);
			this.userImg.Name = "userImg";
			this.userImg.Size = new System.Drawing.Size(31, 32);
			this.userImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.userImg.TabIndex = 1;
			this.userImg.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(147, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(96, 79);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.ClientSize = new System.Drawing.Size(385, 566);
			this.Controls.Add(this.emailRegister);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.instagram);
			this.Controls.Add(this.mainMenu);
			this.Controls.Add(this.facebook);
			this.Controls.Add(this.register);
			this.Controls.Add(this.mailBarRegister);
			this.Controls.Add(this.emailImg);
			this.Controls.Add(this.passBarRegister);
			this.Controls.Add(this.passwordRegister);
			this.Controls.Add(this.passImg);
			this.Controls.Add(this.userBarRegister);
			this.Controls.Add(this.usernameRegister);
			this.Controls.Add(this.userImg);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RegisterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.instagram)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.facebook)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emailImg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.passImg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userImg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox userImg;
		private System.Windows.Forms.TextBox usernameRegister;
		private System.Windows.Forms.FlowLayoutPanel userBarRegister;
		private System.Windows.Forms.FlowLayoutPanel passBarRegister;
		private System.Windows.Forms.TextBox passwordRegister;
		private System.Windows.Forms.PictureBox passImg;
		private System.Windows.Forms.FlowLayoutPanel mailBarRegister;
		private System.Windows.Forms.PictureBox emailImg;
		private System.Windows.Forms.Button register;
		private System.Windows.Forms.PictureBox facebook;
		private System.Windows.Forms.Button mainMenu;
		private System.Windows.Forms.PictureBox instagram;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox emailRegister;
	}
}

