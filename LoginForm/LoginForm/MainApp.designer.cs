namespace LoginForm
{
    partial class MainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.UniversitiesButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.MyAccountButton = new System.Windows.Forms.Button();
            this.panelLoginSubMenu = new System.Windows.Forms.Panel();
            this.TestResultsButton = new System.Windows.Forms.Button();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLoginSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Controls.Add(this.panelLoginSubMenu);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.MaximumSize = new System.Drawing.Size(1100, 600);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(1067, 554);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSideMenu_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.WelcomeLabel);
            this.panel1.Controls.Add(this.UniversitiesButton);
            this.panel1.Controls.Add(this.QuitButton);
            this.panel1.Controls.Add(this.MyAccountButton);
            this.panel1.Location = new System.Drawing.Point(300, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 54);
            this.panel1.TabIndex = 4;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.WelcomeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.WelcomeLabel.Location = new System.Drawing.Point(552, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(106, 54);
            this.WelcomeLabel.TabIndex = 5;
            this.WelcomeLabel.Text = "Hello";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UniversitiesButton
            // 
            this.UniversitiesButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.UniversitiesButton.FlatAppearance.BorderSize = 0;
            this.UniversitiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UniversitiesButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.UniversitiesButton.Location = new System.Drawing.Point(106, 0);
            this.UniversitiesButton.Name = "UniversitiesButton";
            this.UniversitiesButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.UniversitiesButton.Size = new System.Drawing.Size(106, 54);
            this.UniversitiesButton.TabIndex = 4;
            this.UniversitiesButton.Text = "Universities";
            this.UniversitiesButton.UseVisualStyleBackColor = true;
            // 
            // QuitButton
            // 
            this.QuitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.QuitButton.FlatAppearance.BorderSize = 0;
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.QuitButton.Location = new System.Drawing.Point(658, 0);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.QuitButton.Size = new System.Drawing.Size(106, 54);
            this.QuitButton.TabIndex = 1;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MyAccountButton
            // 
            this.MyAccountButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MyAccountButton.FlatAppearance.BorderSize = 0;
            this.MyAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyAccountButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.MyAccountButton.Location = new System.Drawing.Point(0, 0);
            this.MyAccountButton.Name = "MyAccountButton";
            this.MyAccountButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MyAccountButton.Size = new System.Drawing.Size(106, 54);
            this.MyAccountButton.TabIndex = 3;
            this.MyAccountButton.Text = "My Account";
            this.MyAccountButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyAccountButton.UseVisualStyleBackColor = true;
            this.MyAccountButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // panelLoginSubMenu
            // 
            this.panelLoginSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panelLoginSubMenu.Controls.Add(this.TestResultsButton);
            this.panelLoginSubMenu.Controls.Add(this.SignOutButton);
            this.panelLoginSubMenu.Location = new System.Drawing.Point(300, 63);
            this.panelLoginSubMenu.Name = "panelLoginSubMenu";
            this.panelLoginSubMenu.Size = new System.Drawing.Size(106, 54);
            this.panelLoginSubMenu.TabIndex = 2;
            this.panelLoginSubMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLoginSubMenu_Paint);
            // 
            // TestResultsButton
            // 
            this.TestResultsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TestResultsButton.FlatAppearance.BorderSize = 0;
            this.TestResultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestResultsButton.ForeColor = System.Drawing.Color.LightGray;
            this.TestResultsButton.Location = new System.Drawing.Point(0, 25);
            this.TestResultsButton.Name = "TestResultsButton";
            this.TestResultsButton.Size = new System.Drawing.Size(106, 26);
            this.TestResultsButton.TabIndex = 2;
            this.TestResultsButton.Text = "Test Results";
            this.TestResultsButton.UseVisualStyleBackColor = true;
            this.TestResultsButton.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // SignOutButton
            // 
            this.SignOutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SignOutButton.FlatAppearance.BorderSize = 0;
            this.SignOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOutButton.ForeColor = System.Drawing.Color.LightGray;
            this.SignOutButton.Location = new System.Drawing.Point(0, 0);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(106, 25);
            this.SignOutButton.TabIndex = 0;
            this.SignOutButton.Text = "Sign Out";
            this.SignOutButton.UseVisualStyleBackColor = true;
            this.SignOutButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(294, 63);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 54);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelLoginSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLoginSubMenu;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button SignOutButton;
        private System.Windows.Forms.Button TestResultsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MyAccountButton;
        private System.Windows.Forms.Button UniversitiesButton;
        private System.Windows.Forms.Label WelcomeLabel;
    }
}

