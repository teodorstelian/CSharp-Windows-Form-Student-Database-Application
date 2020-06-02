using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class ListOfUniversities : Form
    {
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr Handle, int Msg, int Param1, int Param2);

        SqlConnection myCon = new SqlConnection();
        DataSet dsUniv;

        public ListOfUniversities()
        {
            InitializeComponent();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
            myCon.Open();
            dsUniv = new DataSet();

            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universities", myCon);
            daUniv.Fill(dsUniv, "Universities");
 

            foreach (DataRow dr in dsUniv.Tables["Universities"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                ListUniv1.Items.Add(name);
                ListUniv2.Items.Add(name);
            }
            myCon.Close();


        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainApp App = new MainApp();
            this.Hide();
            App.ShowDialog();
            this.Close();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ComputerBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ArtsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListUniv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String UnivSelected = ListUniv2.SelectedItem.ToString();
            foreach (DataRow dr in dsUniv.Tables["Universities"].Rows)
            {
                if (UnivSelected == dr.ItemArray.GetValue(1).ToString())
                {
                    NameBox2.Text = dr.ItemArray.GetValue(1).ToString();
                    SelectUnivBox2.Text = dr.ItemArray.GetValue(1).ToString();
                    CountryBox2.Text = dr.ItemArray.GetValue(2).ToString();
                    OverallBox2.Text = dr.ItemArray.GetValue(3).ToString();
                    ArtsBox2.Text = dr.ItemArray.GetValue(4).ToString();
                    HealthBox2.Text = dr.ItemArray.GetValue(5).ToString();
                    EngineeringBox2.Text = dr.ItemArray.GetValue(6).ToString();
                    LifeBox2.Text = dr.ItemArray.GetValue(7).ToString();
                    PhysicalBox2.Text = dr.ItemArray.GetValue(8).ToString();
                    SocialBox2.Text = dr.ItemArray.GetValue(9).ToString();
                    BusinessBox2.Text = dr.ItemArray.GetValue(10).ToString();
                    ComputerBox2.Text = dr.ItemArray.GetValue(11).ToString();
                    LawBox2.Text = dr.ItemArray.GetValue(12).ToString();
                }
            }
        }

        private void ReadMoreButton1_Click(object sender, EventArgs e)
        {
            if (NameBox1.Text == "MIT")
            {
                System.Diagnostics.Process.Start("https://www.mit.edu");
            }
            else if (NameBox1.Text == "Oxford")
            {
                System.Diagnostics.Process.Start("http://www.ox.ac.uk");
            }
            else if (NameBox1.Text == "Stanford")
            {
                System.Diagnostics.Process.Start("https://www.stanford.edu");
            }
            else if (NameBox1.Text == "Princeton")
            {
                System.Diagnostics.Process.Start("https://www.princeton.edu");
            }
            else if (NameBox1.Text == "Cambridge")
            {
                System.Diagnostics.Process.Start("https://www.cam.ac.uk");
            }
            else if (NameBox1.Text == "Harvard")
            {
                System.Diagnostics.Process.Start("https://www.harvard.edu");
            }
            else if (NameBox1.Text == "California Institute of Technology")
            {
                System.Diagnostics.Process.Start("https://www.caltech.edu");
            }
            else if (NameBox1.Text == "Imperial College of London")
            {
                System.Diagnostics.Process.Start("https://www.imperial.ac.uk");
            }
            else if (NameBox1.Text == "Yale")
            {
                System.Diagnostics.Process.Start("https://www.yale.edu");
            }
            else if (NameBox1.Text == "Chicago")
            {
                System.Diagnostics.Process.Start("https://www.uchicago.edu");
            }
            else
                MessageBox.Show("No information available for selected university!");
        }

        private void ReadMoreButton2_Click(object sender, EventArgs e)
        {
            if (NameBox2.Text == "MIT")
            {
                System.Diagnostics.Process.Start("https://www.mit.edu");
            }
            else if (NameBox2.Text == "Oxford")
            {
                System.Diagnostics.Process.Start("http://www.ox.ac.uk");
            }
            else if (NameBox2.Text == "Stanford")
            {
                System.Diagnostics.Process.Start("https://www.stanford.edu");
            }
            else if (NameBox2.Text == "Princeton")
            {
                System.Diagnostics.Process.Start("https://www.princeton.edu");
            }
            else if (NameBox2.Text == "Cambridge")
            {
                System.Diagnostics.Process.Start("https://www.cam.ac.uk");
            }
            else if (NameBox2.Text == "Harvard")
            {
                System.Diagnostics.Process.Start("https://www.harvard.edu");
            }
            else if (NameBox2.Text == "California Institute of Technology")
            {
                System.Diagnostics.Process.Start("https://www.caltech.edu");
            }
            else if (NameBox2.Text == "Imperial College of London")
            {
                System.Diagnostics.Process.Start("https://www.imperial.ac.uk");
            }
            else if (NameBox2.Text == "Yale")
            {
                System.Diagnostics.Process.Start("https://www.yale.edu");
            }
            else if (NameBox2.Text == "Chicago")
            {
                System.Diagnostics.Process.Start("https://www.uchicago.edu");
            }
            else
                MessageBox.Show("No information available for selected university!");
        }

        private void ListUniv1_SelectedIndexChanged(object sender, EventArgs e)
        {
           String UnivSelected = ListUniv1.SelectedItem.ToString();
            foreach (DataRow dr in dsUniv.Tables["Universities"].Rows)
            {
                if (UnivSelected == dr.ItemArray.GetValue(1).ToString())
                {
                    NameBox1.Text = dr.ItemArray.GetValue(1).ToString();
                    SelectUnivBox1.Text = dr.ItemArray.GetValue(1).ToString();
                    CountryBox1.Text = dr.ItemArray.GetValue(2).ToString();
                    OverallBox1.Text = dr.ItemArray.GetValue(3).ToString();
                    ArtsBox1.Text = dr.ItemArray.GetValue(4).ToString();
                    HealthBox1.Text = dr.ItemArray.GetValue(5).ToString();
                    EngineeringBox1.Text = dr.ItemArray.GetValue(6).ToString();
                    LifeBox1.Text = dr.ItemArray.GetValue(7).ToString();
                    PhysicalBox1.Text = dr.ItemArray.GetValue(8).ToString();
                    SocialBox1.Text = dr.ItemArray.GetValue(9).ToString();
                    BusinessBox1.Text = dr.ItemArray.GetValue(10).ToString();
                    ComputerBox1.Text = dr.ItemArray.GetValue(11).ToString();
                    LawBox1.Text = dr.ItemArray.GetValue(12).ToString();
                }
            }
        }

        private void panelSideMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
    }
}
