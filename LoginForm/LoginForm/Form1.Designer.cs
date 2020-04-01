namespace LoginForm
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.username = new System.Windows.Forms.TextBox();
			this.userBar = new System.Windows.Forms.FlowLayoutPanel();
			this.passBar = new System.Windows.Forms.FlowLayoutPanel();
			this.password = new System.Windows.Forms.TextBox();
			this.mailBar = new System.Windows.Forms.FlowLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.email = new System.Windows.Forms.TextBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.emailImg = new System.Windows.Forms.PictureBox();
			this.passImg = new System.Windows.Forms.PictureBox();
			this.userImg = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emailImg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.passImg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userImg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// username
			// 
			this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.username.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username.ForeColor = System.Drawing.Color.LightGray;
			this.username.Location = new System.Drawing.Point(99, 130);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(208, 21);
			this.username.TabIndex = 2;
			this.username.Text = "Username";
			this.username.Click += new System.EventHandler(this.username_Click);
			// 
			// userBar
			// 
			this.userBar.BackColor = System.Drawing.Color.White;
			this.userBar.Location = new System.Drawing.Point(60, 161);
			this.userBar.Name = "userBar";
			this.userBar.Size = new System.Drawing.Size(250, 1);
			this.userBar.TabIndex = 3;
			// 
			// passBar
			// 
			this.passBar.BackColor = System.Drawing.Color.White;
			this.passBar.Location = new System.Drawing.Point(60, 219);
			this.passBar.Name = "passBar";
			this.passBar.Size = new System.Drawing.Size(250, 1);
			this.passBar.TabIndex = 6;
			// 
			// password
			// 
			this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.password.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password.ForeColor = System.Drawing.Color.LightGray;
			this.password.Location = new System.Drawing.Point(98, 189);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(208, 21);
			this.password.TabIndex = 5;
			this.password.Text = "Password";
			this.password.UseSystemPasswordChar = true;
			this.password.Click += new System.EventHandler(this.password_Click);
			// 
			// mailBar
			// 
			this.mailBar.BackColor = System.Drawing.Color.White;
			this.mailBar.Location = new System.Drawing.Point(60, 277);
			this.mailBar.Name = "mailBar";
			this.mailBar.Size = new System.Drawing.Size(250, 1);
			this.mailBar.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.button1.Location = new System.Drawing.Point(60, 315);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(250, 40);
			this.button1.TabIndex = 10;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.LightGray;
			this.button2.Location = new System.Drawing.Point(60, 376);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(250, 39);
			this.button2.TabIndex = 12;
			this.button2.Text = "Main Menu";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.LightGray;
			this.label1.Location = new System.Drawing.Point(143, 454);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 24);
			this.label1.TabIndex = 14;
			this.label1.Text = "login with";
			// 
			// email
			// 
			this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.email.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.email.ForeColor = System.Drawing.Color.LightGray;
			this.email.Location = new System.Drawing.Point(101, 246);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(208, 21);
			this.email.TabIndex = 15;
			this.email.Text = "Email";
			this.email.Click += new System.EventHandler(this.email_Click);
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(249, 497);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(57, 57);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 13;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(60, 497);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(57, 57);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 11;
			this.pictureBox5.TabStop = false;
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
			this.userImg.Image = ((System.Drawing.Image)(resources.GetObject("userImg.Image")));
			this.userImg.Location = new System.Drawing.Point(60, 124);
			this.userImg.Name = "userImg";
			this.userImg.Size = new System.Drawing.Size(31, 31);
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.ClientSize = new System.Drawing.Size(385, 566);
			this.Controls.Add(this.email);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.mailBar);
			this.Controls.Add(this.emailImg);
			this.Controls.Add(this.passBar);
			this.Controls.Add(this.password);
			this.Controls.Add(this.passImg);
			this.Controls.Add(this.userBar);
			this.Controls.Add(this.username);
			this.Controls.Add(this.userImg);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
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
		private System.Windows.Forms.TextBox username;
		private System.Windows.Forms.FlowLayoutPanel userBar;
		private System.Windows.Forms.FlowLayoutPanel passBar;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.PictureBox passImg;
		private System.Windows.Forms.FlowLayoutPanel mailBar;
		private System.Windows.Forms.PictureBox emailImg;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox email;
	}
}

