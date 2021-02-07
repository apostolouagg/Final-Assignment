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

        public ChessBoard()
        {
            this.DoubleBuffered = true;

            // Creates and places the pawns
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == 0)
                    {

                        Controls.Add(new Pawn()
                        {
                            Image = pawns[j, 1],
                            Location = new Point(j * pawnSize, i * pawnSize),
                            //Name = $"White.{j * pawnSize}.{i * pawnSize}" // den ksero an tha xreiastei akoma afto
                        });
                    }
                    else if (i == 1)
                    {
                        Controls.Add(new Pawn()
                        {
                            Image = Properties.Resources.w4,
                            Location = new Point(j * pawnSize, i * pawnSize),
                            //Name = $"White.{j * pawnSize}.{i * pawnSize}"
                        });
                    }
                    else if (i == 6)
                    {
                        Controls.Add(new Pawn()
                        {
                            Image = Properties.Resources.b4,
                            Location = new Point(j * pawnSize, i * pawnSize),
                            //Name = $"Black.{j * pawnSize}.{i * pawnSize}"
                        });
                    }
                    else if (i == 7)
                    {
                        Controls.Add(new Pawn()
                        {
                            Image = pawns[j, 0],
                            Location = new Point(j * pawnSize, i * pawnSize),
                            //Name = $"Black.{j * pawnSize}.{i * pawnSize}"
                        });
                    }
                }
            }
        }

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
    }
}
