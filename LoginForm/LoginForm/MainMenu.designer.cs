namespace LoginForm
{
    partial class FormMainMenu
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterMenuBTN = new System.Windows.Forms.Button();
            this.LoginMenuBTN = new System.Windows.Forms.Button();
            this.QuitMenuBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panelSideMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.label1);
            this.panelSideMenu.Controls.Add(this.RegisterMenuBTN);
            this.panelSideMenu.Controls.Add(this.LoginMenuBTN);
            this.panelSideMenu.Controls.Add(this.QuitMenuBTN);
            this.panelSideMenu.Controls.Add(this.pictureBox1);
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(1067, 554);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSideMenu_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("RM Typerighter", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(310, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bringing the future you deserve";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RegisterMenuBTN
            // 
            this.RegisterMenuBTN.FlatAppearance.BorderSize = 0;
            this.RegisterMenuBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterMenuBTN.ForeColor = System.Drawing.Color.Gainsboro;
            this.RegisterMenuBTN.Location = new System.Drawing.Point(456, 397);
            this.RegisterMenuBTN.Name = "RegisterMenuBTN";
            this.RegisterMenuBTN.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RegisterMenuBTN.Size = new System.Drawing.Size(106, 54);
            this.RegisterMenuBTN.TabIndex = 4;
            this.RegisterMenuBTN.Text = "Register";
            this.RegisterMenuBTN.UseVisualStyleBackColor = true;
            this.RegisterMenuBTN.Click += new System.EventHandler(this.RegisterMenuBTN_Click);
            // 
            // LoginMenuBTN
            // 
            this.LoginMenuBTN.FlatAppearance.BorderSize = 0;
            this.LoginMenuBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginMenuBTN.ForeColor = System.Drawing.Color.Gainsboro;
            this.LoginMenuBTN.Location = new System.Drawing.Point(456, 337);
            this.LoginMenuBTN.Name = "LoginMenuBTN";
            this.LoginMenuBTN.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LoginMenuBTN.Size = new System.Drawing.Size(106, 54);
            this.LoginMenuBTN.TabIndex = 3;
            this.LoginMenuBTN.Text = "Login";
            this.LoginMenuBTN.UseVisualStyleBackColor = true;
            this.LoginMenuBTN.Click += new System.EventHandler(this.LoginMenuBTN_Click);
            // 
            // QuitMenuBTN
            // 
            this.QuitMenuBTN.FlatAppearance.BorderSize = 0;
            this.QuitMenuBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitMenuBTN.ForeColor = System.Drawing.Color.Gainsboro;
            this.QuitMenuBTN.Location = new System.Drawing.Point(456, 457);
            this.QuitMenuBTN.Name = "QuitMenuBTN";
            this.QuitMenuBTN.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.QuitMenuBTN.Size = new System.Drawing.Size(106, 54);
            this.QuitMenuBTN.TabIndex = 1;
            this.QuitMenuBTN.Text = "Quit";
            this.QuitMenuBTN.UseVisualStyleBackColor = true;
            this.QuitMenuBTN.Click += new System.EventHandler(this.QuitMenuBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginForm.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(374, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 54);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RegisterMenuBTN;
        private System.Windows.Forms.Button LoginMenuBTN;
        private System.Windows.Forms.Button QuitMenuBTN;
        private System.Windows.Forms.Label label1;
    }
}

