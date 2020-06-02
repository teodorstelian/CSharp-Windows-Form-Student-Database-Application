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
    public partial class MainApp : Form
    {
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr Handle, int Msg, int Param1, int Param2);

        public MainApp()
        {
            InitializeComponent();
            customizeDesign();
            WelcomeUser();
            Reset();
        }
        /// <summary>
        /// IN PROGRESS - Display the user inthe label
        /// </summary>
        private void WelcomeUser()
        {
            WelcomeLabel.Text = "Hello!";
        }

       private void customizeDesign()
        {
            panelLoginSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelLoginSubMenu.Visible == true)
                panelLoginSubMenu.Visible = false;
        }

        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MyAccountButton_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLoginSubMenu);
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            FormMainMenu Menu = new FormMainMenu();
            this.Hide();
            Menu.ShowDialog();
            this.Close();
        }

        private void TestResultsButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void panelSideMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void UniversitiesButton_Click(object sender, EventArgs e)
        {
            ListOfUniversities Univ = new ListOfUniversities();
            this.Hide();
            Univ.ShowDialog();
            this.Close();
        }

        // Claudiu & Ionela

        int counterintrebare = 0;
        int counterintrebareMax;
        SqlConnection myCon = new SqlConnection();
        DataSet dsIntrebari;

        int punctajG = 0;
        int punctajV = 0;
        int punctajN = 0;
        int punctajC = 0;

        int categorieGNivel = 0;
        int categorieVNivel = 0;
        int categorieNNivel = 0;
        int categorieCNivel = 0;

        string UserName;

        string categoryID = "G";
        int counterG = 0;
        int counterV = 0;
        int counterN = 0;
        int counterC = 0;
        bool directionQ;

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (directionQ)
            {
                GetQuestion();

                if (categoryID == "G" && progressBar_Category.Value != counterG)
                {
                    progressBar_Category.Value = counterintrebare;
                }
                else if (categoryID == "G" && progressBar_Category.Value == counterG)
                {
                    categoryID = "V";
                    progressBar_Category.Value = 0;
                    progressBar_Category.Maximum = counterV;
                }
                if (categoryID == "V" && progressBar_Category.Value != counterV)
                {
                    progressBar_Category.Value = counterintrebare - counterG;
                }
                else if (categoryID == "V" && progressBar_Category.Value == counterV)
                {
                    categoryID = "N";
                    progressBar_Category.Value = 0;
                    progressBar_Category.Maximum = counterN;
                }
                if (categoryID == "N" && progressBar_Category.Value != counterN)
                {
                    progressBar_Category.Value = counterintrebare - counterG - counterV;
                }
                else if (categoryID == "N" && progressBar_Category.Value == counterN)
                {
                    categoryID = "C";
                    progressBar_Category.Value = 0;
                    progressBar_Category.Maximum = counterC;
                }
                if (categoryID == "C" && progressBar_Category.Value != counterC)
                {
                    progressBar_Category.Value = counterintrebare - counterG - counterV - counterN;
                }
            }
            else
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
        }

        private void GetQuestion()
        {
            // Claudiu

            trackBar_Choice.Visible = true;

            myCon.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\dania\OneDrive\Scoală\An3Sem2\Industrial Informatics (II)\Project\IntrebariChestionar1\Database1.mdf'; Integrated Security = True";
            // myCon.ConnectionString = @"Data Source = (LocalDB)\MSSQC:\Users\filda\Desktop\IntrebariChestionar1\IntrebariChestionar1\Renunta.csLLocalDB; AttachDbFilename = 'E:\an 3 sem 2\Industrial Informatics - II\proiect\actual\II PROIECT\II PROIECT\VERSIUNE 1\IntrebariChestionar1\Database1.mdf'; Integrated Security = True";

            myCon.Open();

            dsIntrebari = new DataSet();
            counterintrebare = counterintrebare + 1;
            progressBar_Total.Value = counterintrebare;

            lbl_QuestionNumber.Text = "Intrebarea numarul: " + counterintrebare.ToString();

            string sqlstring1 = "SELECT * FROM Intrebari WHERE ID=" + counterintrebare.ToString();
            SqlDataAdapter daIntrebari = new SqlDataAdapter(sqlstring1, myCon);
            daIntrebari.Fill(dsIntrebari, "TestChestionar");
            String name = "";

            if (counterintrebare <= counterintrebareMax)
            {
                foreach (DataRow dr in dsIntrebari.Tables[0].Rows)
                {
                    name = dr.ItemArray.GetValue(2).ToString();
                }

                lbl_Question.Text = name;

                if (counterintrebare <= 10 && counterintrebare >= 1)
                {
                    punctajG = punctajG + trackBar_Choice.Value;
                }

                if (counterintrebare == 11)
                {
                    //MessageBox.Show("La categoria G (invatare generala) s-au inregistrat punctele: " + categorieG.ToString());
                    string valG = "La categoria G (invatare generala)\n s-au inregistrat " + punctajG.ToString() + " puncte";

                    // RezultateIntermediare1 form1 = new RezultateIntermediare1(valG);
                    // form1.ShowDialog();
                }

                if (counterintrebare <= 21 && counterintrebare >= 11)
                {
                    punctajV = punctajV + trackBar_Choice.Value;
                }

                if (counterintrebare == 22)
                {
                    //MessageBox.Show("La categoria V (abilitate verbala) s-au inregistrat punctele: " + punctajV.ToString());

                    string valV = "La categoria V (aptitudine verbala) \n s-au inregistrat " + punctajV.ToString() + " puncte";

                    // RezultateIntermediare2 form2 = new RezultateIntermediare2(valV);
                    // form2.ShowDialog();
                }
                //end Claudiu

                //Ionela

                if (counterintrebare >= 22 && counterintrebare <= 30)
                {
                    punctajN = punctajN + trackBar_Choice.Value;
                }

                if (counterintrebare == 31)
                {
                    // MessageBox.Show("La categoria N (abilitate numerica) s-au inregistrat " + punctajN.ToString() + " puncte");

                    string valN = "La categoria N (aptitudine numerica) \n s-au inregistrat " + punctajN.ToString() + " puncte";

                    // RezultateIntermediare3 form3 = new RezultateIntermediare3(valN);
                    // form3.ShowDialog();
                }

                if (counterintrebare >= 31 && counterintrebare <= counterintrebareMax)
                {
                    punctajC = punctajC + trackBar_Choice.Value;
                }

                if (counterintrebare == counterintrebareMax)
                {
                    //MessageBox.Show("La categoria C (coordonare ochi-mana) s-au inregistrat " + punctajC.ToString() + " puncte");

                    string valC = "La categoria C (coordonare ochi-mana) \n s-au inregistrat " + punctajC.ToString() + " puncte";

                    // RezultateIntermediare4 form4 = new RezultateIntermediare4(valC);
                    // form4.ShowDialog();
                }

                //end Ionela
            }

            if (counterintrebare == counterintrebareMax)
            {
                btn_Next.Enabled = false;
                btn_Result.Visible = true;
            }

            myCon.Close();
        }

        private void trackBar_Choice_Scroll(object sender, EventArgs e)
        {
            switch (trackBar_Choice.Value)
            {
                case 1: lbl_Indicator.Text = "Constantly"; break;
                case 2: lbl_Indicator.Text = "Regularly"; break;
                case 3: lbl_Indicator.Text = "Often"; break;
                case 4: lbl_Indicator.Text = "Sometimes"; break;
                case 5: lbl_Indicator.Text = "A few times"; break;
                case 6: lbl_Indicator.Text = "Never"; break;
                default: lbl_Indicator.Text = "Error"; break;
            }
        }

        private void btn_Result_Click(object sender, EventArgs e)
        {
            //Claudiu
            // MessageBox.Show("Punctajul obtinut la categoria G este: " + categorieG.ToString());

            if (punctajG >= 10 && punctajG <= 15)
            {
                categorieGNivel = 1;
            }
            if (punctajG >= 16 && punctajG <= 28)
            {
                categorieGNivel = 2;
            }
            if (punctajG >= 29 && punctajG <= 40)
            {
                categorieGNivel = 3;
            }
            if (punctajG >= 41 && punctajG <= 53)
            {
                categorieGNivel = 4;
            }
            if (punctajG >= 54 && punctajG <= 60)
            {
                categorieGNivel = 5;
            }

            // MessageBox.Show("Nivelul meu de invatare generala (G) este: " + categorieGNivel.ToString());

            // end Claudiu

            //Ionela
            // MessageBox.Show("Punctajul obtinut la categoria V este: " + punctajV.ToString());

            if (punctajV >= 11 && punctajV <= 17)
            {
                categorieVNivel = 1;
            }

            if (punctajV >= 18 && punctajV <= 30)
            {
                categorieVNivel = 2;
            }

            if (punctajV >= 31 && punctajV <= 44)
            {
                categorieVNivel = 3;
            }

            if (punctajV >= 45 && punctajV <= 58)
            {
                categorieVNivel = 4;
            }

            if (punctajV >= 59 && punctajV <= 66)
            {
                categorieVNivel = 5;
            }

            // MessageBox.Show("Nivelul meu de abilitate verbala (V) este: " + categorieVNivel.ToString());

            // MessageBox.Show("Punctajul obtinut la categoria N este: " + punctajN.ToString());

            // atribuirea punctajului obtinut nivelului corespunzator categoriei N (abilitate numerica) 
            if (punctajN >= 9 && punctajN <= 14)
            {
                categorieNNivel = 1;
            }

            if (punctajN >= 15 && punctajN <= 24)
            {
                categorieNNivel = 2;
            }

            if (punctajN >= 25 && punctajN <= 34)
            {
                categorieNNivel = 3;
            }

            if (punctajN >= 35 && punctajN <= 45)
            {
                categorieNNivel = 4;
            }

            if (punctajN >= 46 && punctajN <= 54)
            {
                categorieNNivel = 5;
            }

            // MessageBox.Show("Nivelul meu de abilitate numerica (N) este: " + categorieNNivel.ToString());

            // MessageBox.Show("Punctajul obtinut la categoria C este: " + punctajC.ToString());

            // atribuirea punctajului obtinut nivelului corespunzator categoriei C (coordonare ochi-mana) 
            if (punctajC >= 14 && punctajC <= 21)
            {
                categorieCNivel = 1;
            }

            if (punctajC >= 22 && punctajC <= 39)
            {
                categorieCNivel = 2;
            }

            if (punctajC >= 40 && punctajC <= 56)
            {
                categorieCNivel = 3;
            }

            if (punctajC >= 57 && punctajC <= 74)
            {
                categorieCNivel = 4;
            }

            if (punctajC >= 75 && punctajC <= 84)
            {
                categorieCNivel = 5;
            }

            //  MessageBox.Show("Nivelul meu de coordonare ochi-mana (C) este: " + categorieCNivel.ToString());

            FinalResults thirdForm = new FinalResults(punctajG.ToString(), punctajV.ToString(), punctajN.ToString(), punctajC.ToString(), categorieGNivel.ToString(), categorieVNivel.ToString(), categorieNNivel.ToString(), categorieCNivel.ToString(), UserName);
            this.Hide();
            thirdForm.ShowDialog();
            this.Close();
        }

        public void Reset()
        {
            // Claudiu

            UserName = "User1";//  AICI TREBUIE SA PRIMESC PARAMETRU DE LA PROIECTUL PRINCTIPAL !!!!!!!!!!!!!

            categoryID = "G";
            counterG = 0;
            counterV = 0;
            counterN = 0;
            counterC = 0;

            trackBar_Choice.Minimum = 1;
            trackBar_Choice.Maximum = 6;

            lbl_Title.Text = "Questionnaire";
            lbl_Subtitle.Text = "The first steps towards universities.";
            lbl_Motivation.Text = "Are you ready?";
            lbl_QuestionNumber.Text = "";
            lbl_Question.Text = "";
            lbl_Instruction.Text = "";
            lbl_Indicator.Text = "";

            counterintrebare = 0;
            //lbl_QuestionNumber.Text = "Intrebarea numarul: " + counterintrebare.ToString();

            counterintrebareMax = 44;

            trackBar_Choice.Visible = false;
            btn_Next.Visible = false;
            btn_Result.Visible = false;
            btn_Abort.Visible = false;
            btn_StartQ1.Visible = true;
            btn_StartQ2.Visible = true;
            checkBox_DA.Visible = false;
            checkBox_NU.Visible = false;

            progressBar_Category.Value = 0;
            progressBar_Total.Value = 0;

            progressBar_Total.Visible = false;
            progressBar_Category.Visible = false;
            lbl_PB_Category.Visible = false;
            lbl_PB_Total.Visible = false;

            // end Claudiu
        }

        private void btn_Abort_Click(object sender, EventArgs e)
        {
            //AbortForm abortForm = new AbortForm();
            //abortForm.ShowDialog();
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Quit Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            switch (result)
            {
                case DialogResult.Yes: Reset(); break;
                default: break;
            }
        }

        private void btn_StartQ1_Click(object sender, EventArgs e)
        {
            btn_StartQ1.Hide();
            btn_StartQ2.Hide();
            lbl_Motivation.Hide();
            directionQ = true;

            progressBar_Total.Maximum = counterintrebareMax;

            GetQuestion();
            lbl_Indicator.Text = "Constantly";
            lbl_Instruction.Text = "Alege nivelul care te caracterizeaza";

            btn_Next.Visible = true;
            btn_Abort.Visible = true;
            progressBar_Category.Visible = true;
            progressBar_Total.Visible = true;
            lbl_PB_Category.Visible = true;
            lbl_PB_Total.Visible = true;

            myCon.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\dania\OneDrive\Scoală\An3Sem2\Industrial Informatics (II)\Project\IntrebariChestionar1\Database1.mdf'; Integrated Security = True";
            // myCon.ConnectionString = @"Data Source = (LocalDB)\MSSQC:\Users\filda\Desktop\IntrebariChestionar1\IntrebariChestionar1\Renunta.csLLocalDB; AttachDbFilename = 'E:\an 3 sem 2\Industrial Informatics - II\proiect\actual\II PROIECT\II PROIECT\VERSIUNE 1\IntrebariChestionar1\Database1.mdf'; Integrated Security = True";

            myCon.Open();

            dsIntrebari = new DataSet();
            lbl_QuestionNumber.Text = "Intrebarea numarul: " + counterintrebare.ToString();

            string sqlstring1 = "SELECT * FROM Intrebari";
            SqlDataAdapter daIntrebari = new SqlDataAdapter(sqlstring1, myCon);
            daIntrebari.Fill(dsIntrebari, "TestChestionar");

            foreach (DataRow dr in dsIntrebari.Tables[0].Rows)
            {
                switch(dr.ItemArray.GetValue(1).ToString())
                {
                    case "G": counterG += 1; break;
                    case "V": counterV += 1; break;
                    case "N": counterN += 1; break;
                    case "C": counterC += 1; break;
                    default: break;
                }
            }

            myCon.Close();
            progressBar_Category.Maximum = counterG;
            progressBar_Category.Value = counterintrebare;
        }

        // Questionnaire 2
        SqlConnection myConn = new SqlConnection();
        DataSet dsIntrebari1;

        int punctajLingvistica = 0;
        int punctajMatem = 0;
        int punctajMuzicala = 0;
        int punctajMotrica = 0;
        int punctajSpatiala = 0;
        int punctajInterpersonala = 0;
        int punctajIntrapersonala = 0;
        int punctajNaturalista = 0;

        private void btn_StartQ2_Click(object sender, EventArgs e)
        {
            btn_StartQ1.Hide();
            btn_StartQ2.Hide();
            lbl_Motivation.Hide();
            CitesteIntrebare();
            directionQ = false;

            counterintrebare = 0;
            counterintrebareMax = 79;

            lbl_Instruction.Text = "Is the question right for you?";

            btn_Next.Visible = true;
            btn_Abort.Visible = true;

            checkBox_DA.Visible = true;
            checkBox_NU.Visible = true;
        }

        private void CitesteIntrebare()
        {
            myConn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\dania\Desktop\Chestionar2\Chestionar2.mdf'; Integrated Security = True";
            //myConn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\filda\Desktop\Chestionar2\Chestionar2\Chestionar2.mdf'; Integrated Security = True";
            myConn.Open();

            dsIntrebari1 = new DataSet();
            counterintrebare = counterintrebare + 1;
            lbl_QuestionNumber.Text = "Question no.: " + counterintrebare.ToString();

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

                lbl_Question.Text = name;

                if (counterintrebare <= 10 && counterintrebare >= 1)
                {
                    if (checkBox_DA.Checked == true)
                        punctajLingvistica = punctajLingvistica + 1;
                }

                if (counterintrebare <= 20 && counterintrebare >= 11)
                {
                    if (checkBox_DA.Checked == true)
                        punctajMatem = punctajMatem + 1;
                }
                if (counterintrebare <= 30 && counterintrebare >= 21)
                {
                    if (checkBox_DA.Checked == true)
                        punctajMuzicala = punctajMuzicala + 1;
                }

                if (counterintrebare <= 40 && counterintrebare >= 31)
                {
                    if (checkBox_DA.Checked == true)
                        punctajMotrica = punctajMotrica + 1;
                }

                if (counterintrebare <= 50 && counterintrebare >= 41)
                {
                    if (checkBox_DA.Checked == true)
                        punctajSpatiala = punctajSpatiala + 1;
                }

                if (counterintrebare <= 60 && counterintrebare >= 51)
                {
                    if (checkBox_DA.Checked == true)
                        punctajInterpersonala = punctajInterpersonala + 1;
                }

                if (counterintrebare <= 70 && counterintrebare >= 61)
                {
                    if (checkBox_DA.Checked == true)
                        punctajIntrapersonala = punctajIntrapersonala + 1;
                }

                if (counterintrebare <= 79 && counterintrebare >= 71)
                {
                    if (checkBox_DA.Checked == true)
                        punctajNaturalista = punctajNaturalista + 1;
                }

                if (counterintrebare == counterintrebareMax)
                {
                    FinalResultsQuestionnaire2 form = new FinalResultsQuestionnaire2(punctajLingvistica.ToString(), punctajMatem.ToString(), punctajMuzicala.ToString(), punctajMotrica.ToString(), punctajSpatiala.ToString(), punctajInterpersonala.ToString(), punctajIntrapersonala.ToString(), punctajNaturalista.ToString(), UserName);
                    //MessageBox.Show("Punctaje obtinute:\n Inteligenta lingvistica: " + punctajLingvistica.ToString() + "\n Inteligenta logico-matematica: " + punctajMatem.ToString() + "\n Inteligenta muzicala: " + punctajMuzicala.ToString() + "\n Inteligenta motrica si kinestezica: " + punctajMotrica.ToString() + "\n Inteligenta spatiala: " + punctajSpatiala.ToString() + "\n Inteligenta interpersonala: " + punctajInterpersonala.ToString() + "\n Inteligenta intra personala: " + punctajIntrapersonala.ToString() + "\n Inteligenta naturalista: " + punctajNaturalista.ToString());
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
            }

            myConn.Close();
        }

        private void checkBox_DA_Click(object sender, EventArgs e)
        {
            checkBox_NU.Checked = false;
        }

        private void checkBox_NU_Click(object sender, EventArgs e)
        {
            checkBox_DA.Checked = false;
        }
    }
}
