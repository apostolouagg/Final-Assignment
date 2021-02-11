using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_Game
{
    public class ChessBoard : Panel
    {
        private int pawnSize = 60;
        private Game Game;

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

        public ChessBoard(Game game)
        {
            this.Game = game;
            this.DoubleBuffered = true; // stops flickering

            // places the pawns to the board
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
                            Team = "White",
                            StartingPosition = new Point(j * pawnSize, i * pawnSize)
                        });
                    }
                    else if (i == 1)
                    {
                        this.Controls.Add(new Pawn(this)
                        {
                            Image = Properties.Resources.w4,
                            Location = new Point(j * pawnSize, i * pawnSize),
                            Team = "White",
                            StartingPosition = new Point(j * pawnSize, i * pawnSize)
                        });
                    }
                    else if (i == 6)
                    {
                        this.Controls.Add(new Pawn(this)
                        {
                            Image = Properties.Resources.b4,
                            Location = new Point(j * pawnSize, i * pawnSize),
                            Team = "Black",
                            StartingPosition = new Point(j * pawnSize, i * pawnSize)
                        });
                    }
                    else if (i == 7)
                    {
                        this.Controls.Add(new Pawn(this)
                        {
                            Image = pawns[j, 0],
                            Location = new Point(j * pawnSize, i * pawnSize),
                            Team = "Black",
                            StartingPosition = new Point(j * pawnSize, i * pawnSize)
                        });
                    }
                }
            }
        }

        public void Capture(Pawn captured)
        {
            if (captured.Team.Equals("White"))
            {
                Game.panelBlacksCaptured.Controls.Add(captured);
                this.Controls.Remove(captured);
            }
            else
            {
                Game.panelWhitesCaptured.Controls.Add(captured);
                this.Controls.Remove(captured);
            }
        }

        public void Restart()
        {
            Pawn pawnMove;
            var panel = new FlowLayoutPanel();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (!(i == 0 || i == 1 || i == 6 || i == 7))
                        continue; // only check position that originally have pawns

                    // Find the pawn that belongs to the current position
                    try
                    {
                        // First check if its captured by the enemy
                        try
                        {
                            pawnMove = Game.panelBlacksCaptured.Controls.OfType<Pawn>().First(x =>
                                x.StartingPosition.Equals(new Point(pawnSize * j,
                                    pawnSize * i))); // search in captured first
                            panel = Game.panelBlacksCaptured;
                        }
                        catch (Exception)
                        {
                            pawnMove = Game.panelWhitesCaptured.Controls.OfType<Pawn>().First(x =>
                                x.StartingPosition.Equals(new Point(pawnSize * j,
                                    pawnSize * i))); // search in captured first
                            panel = Game.panelWhitesCaptured;
                        }
                    }
                    catch (Exception) // if its not captured then its at the chessboard
                    {
                        pawnMove = this.Controls.OfType<Pawn>().First(x =>
                            x.StartingPosition.Equals(new Point(pawnSize * j, pawnSize * i)));
                        panel = null;
                    }

                    // If the pawn we are about to move doesn't have the same location as its starting location OR
                    // its location is the same as its starting location BUT its not in the Board THEN move it (that happens sometimes. boro na sas eksigiso kapia stigmh giati an thelete)
                    if (pawnMove.Location != new Point(pawnSize * j, pawnSize * i) ||
                        (!this.Controls.Contains(pawnMove) &&
                         pawnMove.Location == new Point(pawnSize * j, pawnSize * i)))
                    {
                        // Invoke because we are accessing a control of a different thread
                        Invoke(new Action(() =>
                        {
                            if (panel != null)
                            {
                                panel.Controls.Remove(pawnMove);
                                this.Controls.Add(pawnMove);
                            }

                            pawnMove.Location = new Point(pawnSize * j, pawnSize * i);

                            // Checks if there is a pawn in the way so pawns dont overlap while restarting
                            foreach (var pawn in this.Controls.OfType<Pawn>())
                            {
                                if (pawnMove == pawn) continue;

                                if (pawnMove.Bounds.IntersectsWith(pawn.Bounds))
                                {
                                    pawn.Location = pawn.StartingPosition;
                                    break;
                                }
                            }
                        }));

                        Thread.Sleep(100);
                    }
                }
            }
        }
    }
}
