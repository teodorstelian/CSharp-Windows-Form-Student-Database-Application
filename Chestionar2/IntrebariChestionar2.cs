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

namespace Chestionar2
{ //Ionela
    public partial class IntrebariChestionar2 : Form
    {
        SqlConnection myConn = new SqlConnection();
        DataSet dsIntrebari1;

        string UserName = "";

        int counterintrebare = 0;
        int counterintrebareMax = 79;

        int punctajLingvistica = 0;
        int punctajMatem = 0;
        int punctajMuzicala = 0;
        int punctajMotrica = 0;
        int punctajSpatiala = 0;
        int punctajInterpersonala = 0;
        int punctajIntrapersonala = 0;
        int punctajNaturalista = 0;


        public IntrebariChestionar2()
        {
            InitializeComponent();

            UserName = "user22";

            btn_Start.Visible = true;
            btn_Renunt.Visible = false;
            btn_Urmatoarea.Visible = false;

            label_Info.Visible = false;
            label_Intrebare.Visible = false;
            label_NrIntrebare.Visible = false;

            checkBox_DA.Visible = false;
            checkBox_NU.Visible = false;

        }

        private void CitesteIntrebare()
        {
            myConn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'E:\an 3 sem 2\Industrial Informatics - II\proiect\actual\Chestionar2 ultima versiune\VERSIUNE 5\Chestionar2\Chestionar2\Chestionar2.mdf'; Integrated Security = True";
            //myConn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\filda\Desktop\Chestionar2\Chestionar2\Chestionar2.mdf'; Integrated Security = True";
            myConn.Open();

            dsIntrebari1 = new DataSet();
            counterintrebare = counterintrebare + 1;
            label_NrIntrebare.Text = "Question no.: " + counterintrebare.ToString();

            string sqlstring = "SELECT * FROM Intrebari WHERE ID=" + counterintrebare.ToString();
            SqlDataAdapter daIntrebari = new SqlDataAdapter(sqlstring, myConn);
            daIntrebari.Fill(dsIntrebari1, "TestChestionar2");
            String name = "";

            if (counterintrebare <= counterintrebareMax)
            {

                foreach (DataRow dr in dsIntrebari1.Tables[0].Rows)
                {
                    name = dr.ItemArray.GetValue(2).ToString();
                }

                label_Intrebare.Text = name;

                if (counterintrebare <= 10 && counterintrebare >= 1)
                {
                    if (checkBox_DA.Checked == true)
                        punctajLingvistica = punctajLingvistica + 1;

                    if (checkBox_NU.Checked == true)
                        punctajLingvistica = punctajLingvistica;
                }

                if (counterintrebare <= 20 && counterintrebare >= 11)
                {
                    if (checkBox_DA.Checked == true)
                        punctajMatem = punctajMatem + 1;

                    if (checkBox_NU.Checked == true)
                        punctajMatem = punctajMatem;
                }
                if (counterintrebare <= 30 && counterintrebare >= 21)
                {
                    if (checkBox_DA.Checked == true)
                        punctajMuzicala = punctajMuzicala + 1;

                    if (checkBox_NU.Checked == true)
                        punctajMuzicala = punctajMuzicala;
                }

                if (counterintrebare <= 40 && counterintrebare >= 31)
                {
                    if (checkBox_DA.Checked == true)
                        punctajMotrica = punctajMotrica + 1;

                    if (checkBox_NU.Checked == true)
                        punctajMotrica = punctajMotrica;
                }

                if (counterintrebare <= 50 && counterintrebare >= 41)
                {
                    if (checkBox_DA.Checked == true)
                        punctajSpatiala = punctajSpatiala + 1;

                    if (checkBox_NU.Checked == true)
                        punctajSpatiala = punctajSpatiala;
                }

                if (counterintrebare <= 60 && counterintrebare >= 51)
                {
                    if (checkBox_DA.Checked == true)
                        punctajInterpersonala = punctajInterpersonala + 1;

                    if (checkBox_NU.Checked == true)
                        punctajInterpersonala = punctajInterpersonala;
                }

                if (counterintrebare <= 70 && counterintrebare >= 61)
                {
                    if (checkBox_DA.Checked == true)
                        punctajIntrapersonala = punctajIntrapersonala + 1;

                    if (checkBox_NU.Checked == true)
                        punctajIntrapersonala = punctajIntrapersonala;
                }

                if (counterintrebare <= 79 && counterintrebare >= 71)
                {
                    if (checkBox_DA.Checked == true)
                        punctajNaturalista = punctajNaturalista + 1;

                    if (checkBox_NU.Checked == true)
                        punctajNaturalista = punctajNaturalista;
                }

                if (counterintrebare == counterintrebareMax)
                {
                    Rezultate form = new Rezultate(punctajLingvistica.ToString(), punctajMatem.ToString(), punctajMuzicala.ToString(), punctajMotrica.ToString(), punctajSpatiala.ToString(), punctajInterpersonala.ToString(), punctajIntrapersonala.ToString(), punctajNaturalista.ToString(), UserName);
                    form.Show();
                    //MessageBox.Show("Punctaje obtinute:\n Inteligenta lingvistica: " + punctajLingvistica.ToString() + "\n Inteligenta logico-matematica: " + punctajMatem.ToString() + "\n Inteligenta muzicala: " + punctajMuzicala.ToString() + "\n Inteligenta motrica si kinestezica: " + punctajMotrica.ToString() + "\n Inteligenta spatiala: " + punctajSpatiala.ToString() + "\n Inteligenta interpersonala: " + punctajInterpersonala.ToString() + "\n Inteligenta intra personala: " + punctajIntrapersonala.ToString() + "\n Inteligenta naturalista: " + punctajNaturalista.ToString());
                }
                    
                }

            myConn.Close();
            }

        private void btn_Urmatoarea_Click(object sender, EventArgs e)
        {
            if (checkBox_DA.Checked != true && checkBox_NU.Checked != true)
                MessageBox.Show("You haven't checked any answer!");


            if (((checkBox_DA.Checked == true) && (checkBox_NU.Checked == false)) || ((checkBox_DA.Checked == false) && (checkBox_NU.Checked == true)))
            {
                CitesteIntrebare();

                if (checkBox_DA.Checked == true)
                    checkBox_DA.Checked = !checkBox_DA.Checked;

                if (checkBox_NU.Checked == true)
                    checkBox_NU.Checked = !checkBox_NU.Checked;
            }

            checkBox_DA.Checked = false;
            checkBox_NU.Checked = false;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            CitesteIntrebare();

            btn_Start.Visible = false;
            btn_Renunt.Visible = true;
            btn_Urmatoarea.Visible = true;

            label_Info.Visible = true;
            label_Intrebare.Visible = true;
            label_NrIntrebare.Visible = true;

            checkBox_DA.Visible = true;
            checkBox_NU.Visible = true;
        }

        private void btn_Renunt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox_NU_Click(object sender, EventArgs e)
        {
            checkBox_DA.Checked = false;
        }

        private void checkBox_DA_Click(object sender, EventArgs e)
        {
            checkBox_NU.Checked = false;
        }
    }      
}
//End Ionela