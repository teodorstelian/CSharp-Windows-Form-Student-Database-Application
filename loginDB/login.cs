using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace loginDB
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R3G2N6V\SQLEXPRESS;Initial Catalog=logDB;Integrated Security=True");

            if (txtUsername.Text == "")
            {
                LBLdisplay.Text = "Please enter a desired Username";
            }
            else
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("Insert into login_table(username, password) values (@Username, @Password)");
                cmd.Parameters.Add("@Username", txtUsername.Text);
                cmd.Parameters.Add("@Password", txtPassword.Text);

                cmd.CommandTimeout = 600;
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                try
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LBLdisplay.Text = "Upload successful";
                }
                catch(SqlException sqe)
                {
                    if (sqe.Number == 2627 || sqe.Number == 2601)
                    {
                        LBLdisplay.Text = "Username already exists";
                    }
                }

                finally
                {
                    if (con != null)
                    { con.Close(); }
                }

            }
        }

            private void btnExit_Click(object sender, EventArgs e)
            {
                this.Close();
            }
    }
}
