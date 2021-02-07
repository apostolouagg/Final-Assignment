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
        // 4. na apenergopioume ta piona tou mavrou px an pezei o aspros

        private Player player1;
        private Player player2;
        private ChessBoard board;
        private bool Started = false; 

        public Form_Chess_Game(Player player1, Player player2)
        {
            InitializeComponent();
            this.player1 = player1;
            this.player2 = player2;

            boardBack.Controls.Add(board = new ChessBoard()
            {
                Location = new Point(31, 35),
                Size = new Size(480, 480),
                BackColor = Color.Transparent
            });
            //board.Restart();
        }

        // Exit to menu
        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Chess_Game_Load(object sender, EventArgs e)
        {
            label_Player_1.Text = player1.Name;
            label_Player_2.Text = player2.Name;
            label_Date.Text = DateTime.Now.ToString("dd/MM/yyyy"); // HELLAS HELLINON RISTIANON hmerominia
        }

        private void button_Restart_Click(object sender, EventArgs e)
        {
            /* edw na stamatei ton timer tou paikth pou paizei (epeidh patithike to restart) */
            var answer = MessageBox.Show("Are you sure you want to restart?", "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                player1.RestartTimer();
                player2.RestartTimer();
                board.Restart();
            }
            else
            {
                // na kanei start to timer tou paikth pou epaikse teleutaios
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_Timer_1.Text = player1.Time.ToString("0.0");
            label_Timer_2.Text = player2.Time.ToString("0.0");
        }

        private void TurnButton_Press(object sender, EventArgs e)
        {
            var pressed = (Button)sender;
            if (!Started)
            {
                Started = true;
                buttonBlack.Text = "End Turn";
                buttonWhite.Text = "End Turn";
                if (pressed.Name.Equals("buttonWhite"))
                {
                    buttonBlack.Enabled = false;

                    player1.StartTimer();
                }
                else
                {
                    buttonWhite.Enabled = false;

                    player2.StartTimer();
                }
            }
            else
            {
                if (pressed.Name.Equals("buttonWhite"))
                {
                    buttonBlack.Enabled = true;

                    buttonWhite.Enabled = false;

                    player1.StopTimer();
                    player2.StartTimer();
                }
                else
                {
                    buttonWhite.Enabled = true;
                    buttonBlack.Enabled = false;
                    player2.StopTimer();
                    player1.StartTimer();
                }
            }
        }

    }
}
