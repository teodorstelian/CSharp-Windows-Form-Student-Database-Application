namespace LoginForm
{
    partial class AbortForm
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
            this.btn_Abort_Yes = new System.Windows.Forms.Button();
            this.btn_Abort_No = new System.Windows.Forms.Button();
            this.lbl_Abort_Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Abort_Yes
            // 
            this.btn_Abort_Yes.Location = new System.Drawing.Point(217, 356);
            this.btn_Abort_Yes.Name = "btn_Abort_Yes";
            this.btn_Abort_Yes.Size = new System.Drawing.Size(75, 23);
            this.btn_Abort_Yes.TabIndex = 0;
            this.btn_Abort_Yes.Text = "btn_Abort_Yes";
            this.btn_Abort_Yes.UseVisualStyleBackColor = true;
            this.btn_Abort_Yes.Click += new System.EventHandler(this.btn_Abort_Yes_Click);
            // 
            // btn_Abort_No
            // 
            this.btn_Abort_No.Location = new System.Drawing.Point(404, 356);
            this.btn_Abort_No.Name = "btn_Abort_No";
            this.btn_Abort_No.Size = new System.Drawing.Size(75, 23);
            this.btn_Abort_No.TabIndex = 1;
            this.btn_Abort_No.Text = "btn_Abort_No";
            this.btn_Abort_No.UseVisualStyleBackColor = true;
            this.btn_Abort_No.Click += new System.EventHandler(this.btn_Abort_No_Click);
            // 
            // lbl_Abort_Text
            // 
            this.lbl_Abort_Text.AutoSize = true;
            this.lbl_Abort_Text.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Abort_Text.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Abort_Text.Location = new System.Drawing.Point(269, 255);
            this.lbl_Abort_Text.Name = "lbl_Abort_Text";
            this.lbl_Abort_Text.Size = new System.Drawing.Size(75, 13);
            this.lbl_Abort_Text.TabIndex = 2;
            this.lbl_Abort_Text.Text = "lbl_Abort_Text";
            // 
            // AbortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BackgroundImage = global::LoginForm.Properties.Resources.Abort_Bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.lbl_Abort_Text);
            this.Controls.Add(this.btn_Abort_No);
            this.Controls.Add(this.btn_Abort_Yes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AbortForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AbortForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Abort_Yes;
        private System.Windows.Forms.Button btn_Abort_No;
        private System.Windows.Forms.Label lbl_Abort_Text;
    }
}