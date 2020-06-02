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
            this.checkBox_NU = new System.Windows.Forms.CheckBox();
            this.checkBox_DA = new System.Windows.Forms.CheckBox();
            this.lbl_PB_Category = new System.Windows.Forms.Label();
            this.lbl_PB_Total = new System.Windows.Forms.Label();
            this.progressBar_Total = new System.Windows.Forms.ProgressBar();
            this.progressBar_Category = new System.Windows.Forms.ProgressBar();
            this.trackBar_Choice = new System.Windows.Forms.TrackBar();
            this.btn_Result = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Abort = new System.Windows.Forms.Button();
            this.btn_StartQ2 = new System.Windows.Forms.Button();
            this.lbl_Indicator = new System.Windows.Forms.Label();
            this.lbl_Instruction = new System.Windows.Forms.Label();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.lbl_QuestionNumber = new System.Windows.Forms.Label();
            this.lbl_Motivation = new System.Windows.Forms.Label();
            this.lbl_Subtitle = new System.Windows.Forms.Label();
            this.btn_StartQ1 = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.UniversitiesButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.MyAccountButton = new System.Windows.Forms.Button();
            this.panelLoginSubMenu = new System.Windows.Forms.Panel();
            this.TestResultsButton = new System.Windows.Forms.Button();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pb_StudentHelperLogo = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Choice)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelLoginSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_StudentHelperLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.checkBox_NU);
            this.panelSideMenu.Controls.Add(this.checkBox_DA);
            this.panelSideMenu.Controls.Add(this.lbl_PB_Category);
            this.panelSideMenu.Controls.Add(this.lbl_PB_Total);
            this.panelSideMenu.Controls.Add(this.progressBar_Total);
            this.panelSideMenu.Controls.Add(this.progressBar_Category);
            this.panelSideMenu.Controls.Add(this.trackBar_Choice);
            this.panelSideMenu.Controls.Add(this.btn_Result);
            this.panelSideMenu.Controls.Add(this.btn_Next);
            this.panelSideMenu.Controls.Add(this.btn_Abort);
            this.panelSideMenu.Controls.Add(this.btn_StartQ2);
            this.panelSideMenu.Controls.Add(this.lbl_Indicator);
            this.panelSideMenu.Controls.Add(this.lbl_Instruction);
            this.panelSideMenu.Controls.Add(this.lbl_Question);
            this.panelSideMenu.Controls.Add(this.lbl_QuestionNumber);
            this.panelSideMenu.Controls.Add(this.lbl_Motivation);
            this.panelSideMenu.Controls.Add(this.lbl_Subtitle);
            this.panelSideMenu.Controls.Add(this.btn_StartQ1);
            this.panelSideMenu.Controls.Add(this.lbl_Title);
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
            // checkBox_NU
            // 
            this.checkBox_NU.AutoSize = true;
            this.checkBox_NU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.checkBox_NU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_NU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_NU.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox_NU.Location = new System.Drawing.Point(488, 402);
            this.checkBox_NU.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_NU.Name = "checkBox_NU";
            this.checkBox_NU.Size = new System.Drawing.Size(42, 21);
            this.checkBox_NU.TabIndex = 24;
            this.checkBox_NU.Text = "No";
            this.checkBox_NU.UseVisualStyleBackColor = false;
            this.checkBox_NU.Click += new System.EventHandler(this.checkBox_NU_Click);
            // 
            // checkBox_DA
            // 
            this.checkBox_DA.AutoSize = true;
            this.checkBox_DA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.checkBox_DA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_DA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_DA.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox_DA.Location = new System.Drawing.Point(418, 402);
            this.checkBox_DA.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_DA.Name = "checkBox_DA";
            this.checkBox_DA.Size = new System.Drawing.Size(48, 21);
            this.checkBox_DA.TabIndex = 23;
            this.checkBox_DA.Text = "Yes";
            this.checkBox_DA.UseVisualStyleBackColor = false;
            this.checkBox_DA.Click += new System.EventHandler(this.checkBox_DA_Click);
            // 
            // lbl_PB_Category
            // 
            this.lbl_PB_Category.AutoSize = true;
            this.lbl_PB_Category.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_PB_Category.Location = new System.Drawing.Point(852, 402);
            this.lbl_PB_Category.Name = "lbl_PB_Category";
            this.lbl_PB_Category.Size = new System.Drawing.Size(113, 17);
            this.lbl_PB_Category.TabIndex = 22;
            this.lbl_PB_Category.Text = "lbl_PB_Category";
            // 
            // lbl_PB_Total
            // 
            this.lbl_PB_Total.AutoSize = true;
            this.lbl_PB_Total.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_PB_Total.Location = new System.Drawing.Point(852, 340);
            this.lbl_PB_Total.Name = "lbl_PB_Total";
            this.lbl_PB_Total.Size = new System.Drawing.Size(88, 17);
            this.lbl_PB_Total.TabIndex = 21;
            this.lbl_PB_Total.Text = "lbl_PB_Total";
            // 
            // progressBar_Total
            // 
            this.progressBar_Total.Location = new System.Drawing.Point(855, 360);
            this.progressBar_Total.Name = "progressBar_Total";
            this.progressBar_Total.Size = new System.Drawing.Size(170, 23);
            this.progressBar_Total.TabIndex = 20;
            // 
            // progressBar_Category
            // 
            this.progressBar_Category.Location = new System.Drawing.Point(855, 422);
            this.progressBar_Category.Name = "progressBar_Category";
            this.progressBar_Category.Size = new System.Drawing.Size(170, 23);
            this.progressBar_Category.TabIndex = 19;
            // 
            // trackBar_Choice
            // 
            this.trackBar_Choice.Location = new System.Drawing.Point(526, 400);
            this.trackBar_Choice.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar_Choice.Name = "trackBar_Choice";
            this.trackBar_Choice.Size = new System.Drawing.Size(78, 45);
            this.trackBar_Choice.TabIndex = 18;
            this.trackBar_Choice.Scroll += new System.EventHandler(this.trackBar_Choice_Scroll);
            // 
            // btn_Result
            // 
            this.btn_Result.Location = new System.Drawing.Point(382, 453);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(84, 32);
            this.btn_Result.TabIndex = 16;
            this.btn_Result.Text = "btn_Result";
            this.btn_Result.UseVisualStyleBackColor = true;
            this.btn_Result.Click += new System.EventHandler(this.btn_Result_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(259, 453);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(83, 32);
            this.btn_Next.TabIndex = 15;
            this.btn_Next.Text = "btn_Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Abort
            // 
            this.btn_Abort.Location = new System.Drawing.Point(137, 453);
            this.btn_Abort.Name = "btn_Abort";
            this.btn_Abort.Size = new System.Drawing.Size(92, 32);
            this.btn_Abort.TabIndex = 14;
            this.btn_Abort.Text = "btn_Abort";
            this.btn_Abort.UseVisualStyleBackColor = true;
            this.btn_Abort.Click += new System.EventHandler(this.btn_Abort_Click);
            // 
            // btn_StartQ2
            // 
            this.btn_StartQ2.Location = new System.Drawing.Point(722, 296);
            this.btn_StartQ2.Name = "btn_StartQ2";
            this.btn_StartQ2.Size = new System.Drawing.Size(107, 28);
            this.btn_StartQ2.TabIndex = 13;
            this.btn_StartQ2.Text = "btn_StartQ2";
            this.btn_StartQ2.UseVisualStyleBackColor = true;
            this.btn_StartQ2.Click += new System.EventHandler(this.btn_StartQ2_Click);
            // 
            // lbl_Indicator
            // 
            this.lbl_Indicator.AutoSize = true;
            this.lbl_Indicator.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Indicator.Location = new System.Drawing.Point(609, 400);
            this.lbl_Indicator.Name = "lbl_Indicator";
            this.lbl_Indicator.Size = new System.Drawing.Size(84, 17);
            this.lbl_Indicator.TabIndex = 12;
            this.lbl_Indicator.Text = "lbl_Indicator";
            // 
            // lbl_Instruction
            // 
            this.lbl_Instruction.AutoSize = true;
            this.lbl_Instruction.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Instruction.Location = new System.Drawing.Point(92, 400);
            this.lbl_Instruction.Name = "lbl_Instruction";
            this.lbl_Instruction.Size = new System.Drawing.Size(95, 17);
            this.lbl_Instruction.TabIndex = 11;
            this.lbl_Instruction.Text = "lbl_Instruction";
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Question.Location = new System.Drawing.Point(92, 360);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(87, 17);
            this.lbl_Question.TabIndex = 10;
            this.lbl_Question.Text = "lbl_Question";
            // 
            // lbl_QuestionNumber
            // 
            this.lbl_QuestionNumber.AutoSize = true;
            this.lbl_QuestionNumber.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_QuestionNumber.Location = new System.Drawing.Point(92, 343);
            this.lbl_QuestionNumber.Name = "lbl_QuestionNumber";
            this.lbl_QuestionNumber.Size = new System.Drawing.Size(137, 17);
            this.lbl_QuestionNumber.TabIndex = 9;
            this.lbl_QuestionNumber.Text = "lbl_QuestionNumber";
            // 
            // lbl_Motivation
            // 
            this.lbl_Motivation.AutoSize = true;
            this.lbl_Motivation.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Motivation.Location = new System.Drawing.Point(487, 256);
            this.lbl_Motivation.Name = "lbl_Motivation";
            this.lbl_Motivation.Size = new System.Drawing.Size(94, 17);
            this.lbl_Motivation.TabIndex = 8;
            this.lbl_Motivation.Text = "lbl_Motivation";
            // 
            // lbl_Subtitle
            // 
            this.lbl_Subtitle.AutoSize = true;
            this.lbl_Subtitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Subtitle.Location = new System.Drawing.Point(504, 223);
            this.lbl_Subtitle.Name = "lbl_Subtitle";
            this.lbl_Subtitle.Size = new System.Drawing.Size(77, 17);
            this.lbl_Subtitle.TabIndex = 7;
            this.lbl_Subtitle.Text = "lbl_Subtitle";
            // 
            // btn_StartQ1
            // 
            this.btn_StartQ1.Location = new System.Drawing.Point(154, 296);
            this.btn_StartQ1.Name = "btn_StartQ1";
            this.btn_StartQ1.Size = new System.Drawing.Size(112, 28);
            this.btn_StartQ1.TabIndex = 6;
            this.btn_StartQ1.Text = "btn_StartQ1";
            this.btn_StartQ1.UseVisualStyleBackColor = true;
            this.btn_StartQ1.Click += new System.EventHandler(this.btn_StartQ1_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Title.Location = new System.Drawing.Point(514, 195);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(57, 17);
            this.lbl_Title.TabIndex = 5;
            this.lbl_Title.Text = "lbl_Title";
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
            this.UniversitiesButton.Click += new System.EventHandler(this.UniversitiesButton_Click);
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
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
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
            this.MyAccountButton.Click += new System.EventHandler(this.MyAccountButton_Click);
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
            this.TestResultsButton.Click += new System.EventHandler(this.TestResultsButton_Click);
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
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pb_StudentHelperLogo);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(294, 63);
            this.panelLogo.TabIndex = 0;
            // 
            // pb_StudentHelperLogo
            // 
            this.pb_StudentHelperLogo.Image = ((System.Drawing.Image)(resources.GetObject("pb_StudentHelperLogo.Image")));
            this.pb_StudentHelperLogo.Location = new System.Drawing.Point(2, 3);
            this.pb_StudentHelperLogo.Name = "pb_StudentHelperLogo";
            this.pb_StudentHelperLogo.Size = new System.Drawing.Size(292, 54);
            this.pb_StudentHelperLogo.TabIndex = 0;
            this.pb_StudentHelperLogo.TabStop = false;
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
            this.Text = "Student Helper";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Choice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelLoginSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_StudentHelperLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLoginSubMenu;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button SignOutButton;
        private System.Windows.Forms.Button TestResultsButton;
        private System.Windows.Forms.PictureBox pb_StudentHelperLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MyAccountButton;
        private System.Windows.Forms.Button UniversitiesButton;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.TrackBar trackBar_Choice;
        private System.Windows.Forms.Button btn_Result;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Abort;
        private System.Windows.Forms.Button btn_StartQ2;
        private System.Windows.Forms.Label lbl_Indicator;
        private System.Windows.Forms.Label lbl_Instruction;
        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.Label lbl_QuestionNumber;
        private System.Windows.Forms.Label lbl_Motivation;
        private System.Windows.Forms.Label lbl_Subtitle;
        private System.Windows.Forms.Button btn_StartQ1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ProgressBar progressBar_Category;
        private System.Windows.Forms.Label lbl_PB_Category;
        private System.Windows.Forms.Label lbl_PB_Total;
        private System.Windows.Forms.ProgressBar progressBar_Total;
        private System.Windows.Forms.CheckBox checkBox_NU;
        private System.Windows.Forms.CheckBox checkBox_DA;
    }
}

