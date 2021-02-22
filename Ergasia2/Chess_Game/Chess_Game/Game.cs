using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_Game
{
    public partial class Game : Form
    {
        public Player playerWhite;
        public Player playerBlack;
        private ChessBoard board;
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
        }

        private void Form_Chess_Game_Load(object sender, EventArgs e)
        {
            label_Player_1.Text = playerWhite.Name;
            label_Player_2.Text = playerBlack.Name;
            label_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            playerWhite.StartTimer();
        }

        private void button_Restart_Click(object sender, EventArgs e)
        {
            /* edw na stamatei ton timer tou paikth pou paizei (epeidh patithike to restart) */
            var answer = MessageBox.Show("Are you sure you want to restart?", "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                playerWhite.RestartTimer();
                playerBlack.RestartTimer();
                Finished = false;

                Restarting = true;
                Task.Run(board.Restart);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!Finished && !Restarting)
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

                // Check if a king is captured
                if (!board.Controls.OfType<Pawn>().Any(x => x.Name == "King" && x.Team == "White"))
                {
                    Finished = true;
                    MessageBox.Show("Black Wins!!", "Game Finished", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    board.Enabled = false;
                }
                else if(!board.Controls.OfType<Pawn>().Any(x => x.Name == "King" && x.Team == "Black"))
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