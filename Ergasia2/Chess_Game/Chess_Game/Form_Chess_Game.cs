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

        private int pawnSize = 60;

        // 2D Array with the images
        private readonly Image[,] pawns =
        {
            {Properties.Resources.b6, Properties.Resources.w6},
            {Properties.Resources.b3, Properties.Resources.w3},
            {Properties.Resources.b1, Properties.Resources.w1},
            {Properties.Resources.b5, Properties.Resources.w5},
            {Properties.Resources.b2, Properties.Resources.w2},
            {Properties.Resources.b1, Properties.Resources.w1},
            {Properties.Resources.b3, Properties.Resources.w3},
            {Properties.Resources.b6, Properties.Resources.w6},
        };

        public Form_Chess_Game(Player player1, Player player2)
        {
            InitializeComponent();
            this.player1 = player1;
            this.player2 = player2;
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
            label_Date.Text = DateTime.Now.ToString("dd/MM/yyyy"); // ellinikh hmerominia

            // Creates and places the pawns
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == 0)
                    {
                        new Pawn(board)
                        {
                            Image = pawns[j, 1],
                            Location = new Point( j * pawnSize,  i * pawnSize),
                            //Name = $"White.{j * pawnSize}.{i * pawnSize}" // den ksero an tha xreiastei akoma afto
                        };
                    }
                    else if (i == 1)
                    {
                        new Pawn(board)
                        {
                            Image = Properties.Resources.w4,
                            Location = new Point(j  * pawnSize,  i * pawnSize),
                            //Name = $"White.{j * pawnSize}.{i * pawnSize}"
                        };
                    }
                    else if (i == 6)
                    {
                        new Pawn(board)
                        {
                            Image = Properties.Resources.b4,
                            Location = new Point(  j * pawnSize,  i * pawnSize),
                            //Name = $"Black.{j * pawnSize}.{i * pawnSize}"
                        };
                    }
                    else if (i == 7)
                    {
                        new Pawn(board)
                        {
                            Image = pawns[j, 0],
                            Location = new Point( j * pawnSize,  i * pawnSize),
                            //Name = $"Black.{j * pawnSize}.{i * pawnSize}"
                        };
                    }
                }
            }
        }

        private void button_Restart_Click(object sender, EventArgs e)
        {
            /* edw na stamatei ton timer tou paikth pou paizei (epeidh patithike to restart) */
            var answer = MessageBox.Show("Are you sure you want to restart?", "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                player1.RestartTimer();
                player2.RestartTimer();
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
    }
}
