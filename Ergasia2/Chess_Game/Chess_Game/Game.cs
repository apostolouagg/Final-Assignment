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
    public partial class Game : Form
    {
        private Player playerWhite;
        private Player playerBlack;
        private ChessBoard board;
        private bool Started = false;
        private bool Finished = false;
        public bool Restarting = false;
        public Game(Player playerWhite, Player playerBlack)
        {
            InitializeComponent();
            this.playerWhite = playerWhite;
            this.playerBlack = playerBlack;
            boardBack.Controls.Add(board = new ChessBoard(this)
            {
                Location = new Point(31, 35),
                Size = new Size(480, 480),
                BackColor = Color.Transparent
            });

            board.Enabled = false;
        }

        private void Form_Chess_Game_Load(object sender, EventArgs e)
        {
            label_Player_1.Text = playerWhite.Name;
            label_Player_2.Text = playerBlack.Name;
            label_Date.Text = DateTime.Now.ToString("dd/MM/yyyy"); 
        }

        private void button_Restart_Click(object sender, EventArgs e)
        {
            /* edw na stamatei ton timer tou paikth pou paizei (epeidh patithike to restart) */
            var answer = MessageBox.Show("Are you sure you want to restart?", "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                playerWhite.RestartTimer();
                playerBlack.RestartTimer();
                Started = false;
                Finished = false;
                buttonBlack.Enabled = true;
                buttonWhite.Enabled = true;
                buttonBlack.Text = "Start Game";
                buttonWhite.Text = "Start Game";

                Restarting = true;
                Task.Run(board.Restart);
            }
        }

        private void TurnButton_Press(object sender, EventArgs e)
        {
            var pressed = (Button)sender;
            if (!Started)
            {
                board.Enabled = true;
                Started = true;
                buttonBlack.Text = "End Turn";
                buttonWhite.Text = "End Turn";
                if (pressed.Name.Equals("buttonWhite"))
                {
                    buttonBlack.Enabled = false;
                    playerWhite.StartTimer();
                }
                else
                {
                    buttonWhite.Enabled = false;
                    playerBlack.StartTimer();
                }
            }
            else
            {
                if (pressed.Name.Equals("buttonWhite"))
                {
                    buttonBlack.Enabled = true;
                    buttonWhite.Enabled = false;
                    playerWhite.StopTimer();
                    playerBlack.StartTimer();
                }
                else
                {
                    buttonWhite.Enabled = true;
                    buttonBlack.Enabled = false;
                    playerBlack.StopTimer();
                    playerWhite.StartTimer();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!Finished && Restarting == false)
            {
                label_Timer_1.Text = playerWhite.Time.ToString("0.0");
                label_Timer_2.Text = playerBlack.Time.ToString("0.0");

                // If a player's time goes to 0
                if (playerWhite.Time == 0f)
                {
                    Finished = true;
                    MessageBox.Show("Black Wins!!", "Game Finished", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    board.Enabled = false;
                }
                else if (playerBlack.Time == 0f)
                {
                    Finished = true;
                    MessageBox.Show("White Wins!!", "Game Finished", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    board.Enabled = false;
                }

                // If someones pawns are gone
                if (!board.Controls.OfType<Pawn>().Any(x => x.Team.Equals("White")))
                {
                    Finished = true;
                    MessageBox.Show("Black Wins!!", "Game Finished", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    board.Enabled = false;
                }
                else if (!board.Controls.OfType<Pawn>().Any(x => x.Team.Equals("Black")))
                {
                    Finished = true;
                    MessageBox.Show("White Wins!!", "Game Finished", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    board.Enabled = false;
                }
            }

        }
        // Exit to menu
        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
