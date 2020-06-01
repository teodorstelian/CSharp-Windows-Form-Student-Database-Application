using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class ListOfUniversities : Form
    {

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
                UniversitiesList.Items.Add(name);
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

        private void UniversitiesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            String UnivSelected = UniversitiesList.SelectedItem.ToString();
            foreach (DataRow dr in dsUniv.Tables["Universities"].Rows)
            {
                if (UnivSelected == dr.ItemArray.GetValue(1).ToString())
                {
                   NameBox.Text = dr.ItemArray.GetValue(1).ToString();
                   CountryBox.Text = dr.ItemArray.GetValue(2).ToString();
                   OverallBox.Text = dr.ItemArray.GetValue(3).ToString();
                   ArtsBox.Text = dr.ItemArray.GetValue(4).ToString();
                   HealthBox.Text = dr.ItemArray.GetValue(5).ToString();
                   EngineeringBox.Text = dr.ItemArray.GetValue(6).ToString();
                   LifeBox.Text = dr.ItemArray.GetValue(7).ToString();
                   PhysicalBox.Text = dr.ItemArray.GetValue(8).ToString();
                   SocialBox.Text = dr.ItemArray.GetValue(9).ToString();
                   BusinessBox.Text = dr.ItemArray.GetValue(10).ToString();
                   ComputerBox.Text = dr.ItemArray.GetValue(11).ToString();
                   LawBox.Text = dr.ItemArray.GetValue(12).ToString();
                }
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ComputerBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
