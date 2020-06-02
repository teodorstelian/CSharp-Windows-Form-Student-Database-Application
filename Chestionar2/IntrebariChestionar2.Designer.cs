namespace Chestionar2
{
    partial class IntrebariChestionar2
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.label_NrIntrebare = new System.Windows.Forms.Label();
            this.label_Intrebare = new System.Windows.Forms.Label();
            this.checkBox_DA = new System.Windows.Forms.CheckBox();
            this.checkBox_NU = new System.Windows.Forms.CheckBox();
            this.label_Info = new System.Windows.Forms.Label();
            this.btn_Urmatoarea = new System.Windows.Forms.Button();
            this.btn_Renunt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Start.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Start.Location = new System.Drawing.Point(444, 110);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(106, 54);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // label_NrIntrebare
            // 
            this.label_NrIntrebare.AutoSize = true;
            this.label_NrIntrebare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.label_NrIntrebare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_NrIntrebare.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_NrIntrebare.Location = new System.Drawing.Point(66, 180);
            this.label_NrIntrebare.Name = "label_NrIntrebare";
            this.label_NrIntrebare.Size = new System.Drawing.Size(137, 20);
            this.label_NrIntrebare.TabIndex = 1;
            this.label_NrIntrebare.Text = "Question number";
            // 
            // label_Intrebare
            // 
            this.label_Intrebare.AutoSize = true;
            this.label_Intrebare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.label_Intrebare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Intrebare.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_Intrebare.Location = new System.Drawing.Point(66, 230);
            this.label_Intrebare.Name = "label_Intrebare";
            this.label_Intrebare.Size = new System.Drawing.Size(76, 20);
            this.label_Intrebare.TabIndex = 2;
            this.label_Intrebare.Text = "Question";
            // 
            // checkBox_DA
            // 
            this.checkBox_DA.AutoSize = true;
            this.checkBox_DA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.checkBox_DA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_DA.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox_DA.Location = new System.Drawing.Point(444, 391);
            this.checkBox_DA.Name = "checkBox_DA";
            this.checkBox_DA.Size = new System.Drawing.Size(59, 24);
            this.checkBox_DA.TabIndex = 3;
            this.checkBox_DA.Text = "Yes";
            this.checkBox_DA.UseVisualStyleBackColor = false;
            this.checkBox_DA.Click += new System.EventHandler(this.checkBox_DA_Click);
            // 
            // checkBox_NU
            // 
            this.checkBox_NU.AutoSize = true;
            this.checkBox_NU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.checkBox_NU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_NU.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox_NU.Location = new System.Drawing.Point(537, 391);
            this.checkBox_NU.Name = "checkBox_NU";
            this.checkBox_NU.Size = new System.Drawing.Size(52, 24);
            this.checkBox_NU.TabIndex = 4;
            this.checkBox_NU.Text = "No";
            this.checkBox_NU.UseVisualStyleBackColor = false;
            this.checkBox_NU.Click += new System.EventHandler(this.checkBox_NU_Click);
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.label_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Info.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_Info.Location = new System.Drawing.Point(412, 353);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(221, 20);
            this.label_Info.TabIndex = 5;
            this.label_Info.Text = "Is the question right for you?";
            // 
            // btn_Urmatoarea
            // 
            this.btn_Urmatoarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_Urmatoarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Urmatoarea.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Urmatoarea.Location = new System.Drawing.Point(456, 442);
            this.btn_Urmatoarea.Name = "btn_Urmatoarea";
            this.btn_Urmatoarea.Size = new System.Drawing.Size(106, 54);
            this.btn_Urmatoarea.TabIndex = 6;
            this.btn_Urmatoarea.Text = "Next";
            this.btn_Urmatoarea.UseVisualStyleBackColor = false;
            this.btn_Urmatoarea.Click += new System.EventHandler(this.btn_Urmatoarea_Click);
            // 
            // btn_Renunt
            // 
            this.btn_Renunt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_Renunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Renunt.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Renunt.Location = new System.Drawing.Point(864, 12);
            this.btn_Renunt.Name = "btn_Renunt";
            this.btn_Renunt.Size = new System.Drawing.Size(106, 54);
            this.btn_Renunt.TabIndex = 7;
            this.btn_Renunt.Text = "Quit";
            this.btn_Renunt.UseVisualStyleBackColor = false;
            this.btn_Renunt.Click += new System.EventHandler(this.btn_Renunt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Questionnaire";
            // 
            // IntrebariChestionar2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(982, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Renunt);
            this.Controls.Add(this.btn_Urmatoarea);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.checkBox_NU);
            this.Controls.Add(this.checkBox_DA);
            this.Controls.Add(this.label_Intrebare);
            this.Controls.Add(this.label_NrIntrebare);
            this.Controls.Add(this.btn_Start);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IntrebariChestionar2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label label_NrIntrebare;
        private System.Windows.Forms.Label label_Intrebare;
        private System.Windows.Forms.CheckBox checkBox_DA;
        private System.Windows.Forms.CheckBox checkBox_NU;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Button btn_Urmatoarea;
        private System.Windows.Forms.Button btn_Renunt;
        private System.Windows.Forms.Label label1;
    }
}

