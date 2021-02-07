using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_Game
{
    public class ChessBoard : Panel
    {
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

        public void Restart()
        {
            var x = Controls.Count;
            for (int i = 0; i < x; i++)
            {
                this.Controls.RemoveAt(0);
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == 0)
                    {
                        this.Controls.Add(new Pawn(this)
                        {
                            Image = pawns[j, 1],
                            Location = new Point(j * pawnSize, i * pawnSize),
                            Tag = "White"
                            //Name = $"White.{j * pawnSize}.{i * pawnSize}" // den ksero an tha xreiastei akoma afto
                        });
                    }
                    else if (i == 1)
                    {
                        this.Controls.Add(new Pawn(this)
                        {
                            Image = Properties.Resources.w4,
                            Location = new Point(j * pawnSize, i * pawnSize),
                            Tag = "White"
                        });
                    }
                    else if (i == 6)
                    {
                        this.Controls.Add(new Pawn(this)
                        {
                            Image = Properties.Resources.b4,
                            Location = new Point(j * pawnSize, i * pawnSize),
                            Tag = "Black"
                        });
                    }
                    else if (i == 7)
                    {
                        this.Controls.Add(new Pawn(this)
                        {
                            Image = pawns[j, 0],
                            Location = new Point(j * pawnSize, i * pawnSize),
                            Tag = "Black"
                        });
                    }
                }
            }
        }

        public ChessBoard()
        {
            this.DoubleBuffered = true; // stops flickering
            Restart();
        }
    }
}
