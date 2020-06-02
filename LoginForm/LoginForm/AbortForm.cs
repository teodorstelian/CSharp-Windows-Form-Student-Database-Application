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
    public partial class AbortForm : Form
    {
        MainApp mainApp = new MainApp();
        public AbortForm()
        {
            InitializeComponent();
            lbl_Abort_Text.Text = "Are you sure you want to leave?";
            btn_Abort_No.Text = "No";
            btn_Abort_Yes.Text = "Yes";
        }

        private void btn_Abort_Yes_Click(object sender, EventArgs e)
        {
            mainApp.Reset();
            this.Close();
        }

        private void btn_Abort_No_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
