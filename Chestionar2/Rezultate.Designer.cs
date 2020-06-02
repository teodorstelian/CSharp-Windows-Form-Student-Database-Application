namespace Chestionar2
{
    partial class Rezultate
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
            this.label_Rezultate = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Rezultate
            // 
            this.label_Rezultate.AutoSize = true;
            this.label_Rezultate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.label_Rezultate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Rezultate.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_Rezultate.Location = new System.Drawing.Point(70, 141);
            this.label_Rezultate.Name = "label_Rezultate";
            this.label_Rezultate.Size = new System.Drawing.Size(80, 20);
            this.label_Rezultate.TabIndex = 0;
            this.label_Rezultate.Text = "Rezultate";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Exit.Location = new System.Drawing.Point(516, 12);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(106, 54);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Submit.Location = new System.Drawing.Point(516, 534);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(106, 54);
            this.btn_Submit.TabIndex = 2;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // Rezultate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(634, 600);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label_Rezultate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rezultate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezultate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Rezultate;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Submit;
    }
}