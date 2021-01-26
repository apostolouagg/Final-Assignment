using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_Game
{
    public partial class Form_Chess_Game : Form
    {
        // To do list
        // 1. Na kanei start to timer tou paikth pou epaikse teleutaios otan pataei "Restart" kai meta "No"
        // 2. Na kanei start ton taimer tou paixth pou paizei otan ksekinaei to paixnidi
        // 3. Gia na ginei to parapanw (to 2) prepei na doume prwta pws tha ftiaksoume to paixnidi etsi wste o timer na ksekina otan tha ginetai click
        // 4. Mporoume na xrhsimopoihsoume tis classes gia th leitourgia twn pioniwn

        string player1;
        string player2;
        int timePlayer1;
        int timePLayer2;

        String connectionString = "Data Source=c:DB1.db;Version=3;";
        SQLiteConnection conn;

        public Form_Chess_Game(string player1, string player2)
        {
            InitializeComponent();
            this.player1 = player1;
            this.player2 = player2;
        }

        private void label_Timer_1_Click(object sender, EventArgs e)
        {

        }

        // Exit to menu
        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Chess_Game_Load(object sender, EventArgs e)
        {
            label_Player_1.Text = player1;
            label_Player_2.Text = player2;
            label_Date.Text = DateTime.Now.ToString();

            conn = new SQLiteConnection(connectionString);

            conn.Open();
            string insertQuery = $"Insert into PLayers(Player1, Player2, Date) values('{player1}','{player2}','{DateTime.Now}')";
            SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void timer_Player1_Tick(object sender, EventArgs e)
        {
            timePlayer1++;
        }

        private void timer_Player2_Tick(object sender, EventArgs e)
        {
            timePLayer2++;
        }

        private void button_Restart_Click(object sender, EventArgs e)
        {
            /* edw na stamatei ton timer tou paikth pou paizei (epeidh patithike to restart) */

            var answer = MessageBox.Show("Are you sure you want to restart?", "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                timePlayer1 = 0;
                timePLayer2 = 0;
            }
            else
            {
                // na kanei start to timer tou paikth pou epaikse teleutaios
            }
        }
    }
}
