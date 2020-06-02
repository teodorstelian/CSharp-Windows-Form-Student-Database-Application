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
    public partial class FinalResultsQuestionnaire2 : Form
    {
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr Handle, int Msg, int Param1, int Param2);

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

        public FinalResultsQuestionnaire2(string punctajLingvistica, string punctajMatem, string punctajMuzicala, string punctajMotrica, string punctajSpatiala, string punctajInterpersonala, string punctajIntrapersonala, string punctajNaturalista, string UserName)
        {
            InitializeComponent();

            lbl_Results_FinalResults2.Text = "Punctaje obtinute:\n\n Inteligenta lingvistica: " + punctajLingvistica + "\n\n Inteligenta logico-matematica: " + punctajMatem + "\n\n Inteligenta muzicala: " + punctajMuzicala + "\n\n Inteligenta motrica si kinestezica: " + punctajMotrica + "\n\n Inteligenta spatiala: " + punctajSpatiala + "\n\n Inteligenta interpersonala: " + punctajInterpersonala + "\n\n Inteligenta intra personala: " + punctajIntrapersonala + "\n\n Inteligenta naturalista: " + punctajNaturalista;

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

        private void btn_Exit_FinalResults2_Click(object sender, EventArgs e)
        {
            MainApp mainApp = new MainApp();
            this.Hide();
            mainApp.ShowDialog();
            this.Close();
        }

        private void btn_Submit_FinalResults2_Click(object sender, EventArgs e)
        {
            //Claudiu
            myCon.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'D:\Documents\GitHub\CSharp-Windows-Form-Student-Database-Application\LoginForm\LoginForm\Database1.mdf'; Integrated Security = True";
            //myCon.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\filda\Desktop\Chestionar2\Chestionar2\Database1.mdf'; Integrated Security = True";

            string sqlstring2 = "UPDATE TableRez1 SET Lingvistica=@lin, LogicaMate=@lm, Muzicala=@mz, Motrica=@mo, Spatiala=@sp, Interpersonala=@interp, Intrapersonala=@intrap, Naturalista=@na WHERE UserName=@un";
            SqlCommand command2 = new SqlCommand(sqlstring2, myCon);

            command2.Parameters.AddWithValue("@un", UserNamelocal);// AICI TREBUIE PUS NUMELE UTILIZATORULU

            command2.Parameters.AddWithValue("@lin", punctajA);
            command2.Parameters.AddWithValue("@lm", punctajB);
            command2.Parameters.AddWithValue("@mz", punctajC);
            command2.Parameters.AddWithValue("@mo", punctajD);

            command2.Parameters.AddWithValue("@sp", punctajE);
            command2.Parameters.AddWithValue("@interp", punctajF);
            command2.Parameters.AddWithValue("@intrap", punctajG);
            command2.Parameters.AddWithValue("@na", punctajH);

            command2.CommandType = CommandType.Text;
            myCon.Open();

            command2.ExecuteNonQuery();
            myCon.Close();

            // End Claudiu
        }

        private void FinalResultsQuestionnaire2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
    }
}
