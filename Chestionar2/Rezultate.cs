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
{
    public partial class Rezultate : Form
    {

        SqlConnection myCon = new SqlConnection();
   

        string punctajA;
        string punctajB;
        string punctajC;
        string punctajD;

        string punctajE;
        string punctajF;
        string punctajG;
        string punctajH;

        string UserNamelocal;

        public Rezultate(string punctajLingvistica, string punctajMatem, string punctajMuzicala, string punctajMotrica, string punctajSpatiala, string punctajInterpersonala, string punctajIntrapersonala, string punctajNaturalista, string UserName)
        {
            InitializeComponent();

            label_Rezultate.Text = "Punctaje obtinute:\n\n Inteligenta lingvistica: " + punctajLingvistica + "\n\n Inteligenta logico-matematica: " + punctajMatem + "\n\n Inteligenta muzicala: " + punctajMuzicala + "\n\n Inteligenta motrica si kinestezica: " + punctajMotrica + "\n\n Inteligenta spatiala: " + punctajSpatiala + "\n\n Inteligenta interpersonala: " + punctajInterpersonala + "\n\n Inteligenta intra personala: " + punctajIntrapersonala + "\n\n Inteligenta naturalista: " + punctajNaturalista;

            //clau

            punctajA = punctajLingvistica;
            punctajB = punctajMatem;
            punctajC = punctajMuzicala;
            punctajD = punctajMotrica;

            punctajE = punctajSpatiala;
            punctajF = punctajInterpersonala;
            punctajG = punctajIntrapersonala;
            punctajH = punctajNaturalista;
                        
            UserNamelocal = UserName;

            // end clau
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //Claudiu
            myCon.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'E:\an 3 sem 2\Industrial Informatics - II\proiect\actual\Chestionar2 ultima versiune\VERSIUNE 5\Chestionar2\Chestionar2\Database1.mdf'; Integrated Security = True";
            //myCon.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\filda\Desktop\Chestionar2\Chestionar2\Database1.mdf'; Integrated Security = True";
         
            string sqlstring2 = "UPDATE TableRez1 SET Lingvistica=@lin, LogicaMate=@lm, Muzicala=@mz, Motrica=@mo, Spatiala=@sp, Interpersonala=@interp, Intrapersonala=@intrap, Naturalista=@na WHERE UserName=@un";
            SqlCommand command2 = new SqlCommand(sqlstring2, myCon);


            command2.Parameters.AddWithValue("@un", UserNamelocal);// AICI TREBUIE PUS NUMELE UTILIZATORULU

            command2.Parameters.AddWithValue("@lin", punctajA);
            command2.Parameters.AddWithValue("@lm",  punctajB);
            command2.Parameters.AddWithValue("@mz",  punctajC);
            command2.Parameters.AddWithValue("@mo",  punctajD);

            command2.Parameters.AddWithValue("@sp",  punctajE);
            command2.Parameters.AddWithValue("@interp", punctajF);
            command2.Parameters.AddWithValue("@intrap", punctajG);
            command2.Parameters.AddWithValue("@na", punctajH);

            command2.CommandType = CommandType.Text;
            myCon.Open();

            command2.ExecuteNonQuery();
            myCon.Close();

            // End Claudiu
        }
    }
}
