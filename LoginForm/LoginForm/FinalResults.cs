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
    public partial class FinalResults : Form
    {
        //clau 
        String punctajGlocal;
        String punctajVlocal;
        String punctajNlocal;
        String punctajClocal;

        String nivelGlocal;
        String nivelVlocal;
        String nivelNlocal;
        String nivelClocal;

        String UserNamelocal;

        SqlConnection myCon = new SqlConnection();

        //end clau

        public FinalResults(string punctajG, string punctajV, string punctajN, string punctajC, string nivelG, string nivelV, string nivelN, string nivelC, string UserName)
        {
            InitializeComponent();

            // Ionela
            lbl_Title_FinalResults.Text = "Rezultatele obtinute de tine sunt urmatoarele: ";

            lbl_CategoryG_FinalResult.Text = "Categoria G (invatare generala)";
            lbl_CategoryV_FinalResult.Text = "Categoria V (aptitudine verbala)";
            lbl_CategoryN_FinalResult.Text = "Categoria N (aptitudinea numerica)";
            lbl_CategoryC_FinalResult.Text = "Categoria C (coordonare ochi-mana)";

            lbl_CatG_Points_FinalResult.Text = "Punctaj cat. G: " + punctajG;
            lbl_CatV_Points_FinalResult.Text = "Punctaj cat. V: " + punctajV;

            lbl_CatN_Points_FinalResult.Text = "Punctaj cat. N: " + punctajN;
            lbl_CatC_Points_FinalResult.Text = "Punctaj cat. C: " + punctajC;

            //End Ionela

            //clau

            punctajGlocal = punctajG;
            punctajVlocal = punctajV;
            punctajNlocal = punctajN;
            punctajClocal = punctajC;

            nivelGlocal = nivelG;
            nivelVlocal = nivelV;
            nivelNlocal = nivelN;
            nivelClocal = nivelC;

            UserNamelocal = UserName;

            // end clau
        }

        private void btn_Exit_FinalResult_Click(object sender, EventArgs e)
        {
            MainApp mainApp = new MainApp();
            this.Hide();
            mainApp.ShowDialog();
            this.Close();
        }

        private void btn_Submit_FinalResult_Click(object sender, EventArgs e)
        {
            UpdateUsersAfterTest1();
        }

        private void UpdateUsersAfterTest1()
        {
            // clau

            myCon.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\filda\Desktop\IntrebariChestionar1\IntrebariChestionar1\Database1.mdf'; Integrated Security = True";

            string sqlstring2 = "INSERT INTO TableRez1 (UserName, punctajG, punctajV, punctajN, punctajC, nivelG, nivelV, nivelN, nivelC) VALUES ( @un, @pg, @pv ,@pn, @pc, @ng, @nv, @nn, @nc)";

            SqlCommand command2 = new SqlCommand(sqlstring2, myCon);
            
            command2.Parameters.AddWithValue("@un", "userj3");// AICI TREBUIE PUS NUMELE UTILIZATORULU
            // SCHIMBA-L LA FIECARE RULARE
            //command2.Parameters.AddWithValue("@un", UserNamelocal);

            command2.Parameters.AddWithValue("@pg", punctajGlocal);
            command2.Parameters.AddWithValue("@pv", punctajVlocal);
            command2.Parameters.AddWithValue("@pn", punctajNlocal);
            command2.Parameters.AddWithValue("@pc", punctajClocal);

            command2.Parameters.AddWithValue("@ng", nivelGlocal);
            command2.Parameters.AddWithValue("@nv", nivelVlocal);
            command2.Parameters.AddWithValue("@nn", nivelNlocal);
            command2.Parameters.AddWithValue("@nc", nivelClocal);

            command2.CommandType = CommandType.Text;
            myCon.Open();

            command2.ExecuteNonQuery();
            myCon.Close();

            // end clau
        }
    }
}
