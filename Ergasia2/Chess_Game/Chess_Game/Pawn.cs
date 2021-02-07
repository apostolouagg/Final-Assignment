using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_Game
{
    public class Pawn : PictureBox
    {
        private static int PawnSize { get;} = 60;
        private static int Limit { get;} = 15;
        private ChessBoard Board { get;}
        private bool Selected { get; set; }

        public Pawn(ChessBoard board)
        {
            this.Board = board;
            this.Size = new Size(PawnSize,PawnSize);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Color.Transparent;
            this.Cursor = Cursors.Hand;

            // Event handlers
            this.MouseDown += mouse_Down;
            this.MouseMove += mouse_Move;
            this.MouseUp += mouse_Up;
        }
        private void mouse_Down(object sender, MouseEventArgs e)
        {
            Selected = true;
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (Selected)
            {
                // Diagonal Movement ( Lower threshold so its easier to make that move )
                if (e.Location.Y < 0 - Limit / 3 && e.Location.X < 0 - Limit / 3) // Top-Left
                {
                    MovePawn(new Point(this.Location.X - PawnSize, this.Location.Y - PawnSize));
                }
                else if (e.Location.Y > 60 + Limit / 3 && e.Location.X > 60 + Limit / 3) // Bottom-Right
                {
                    MovePawn(new Point(this.Location.X + PawnSize, this.Location.Y + PawnSize));
                }
                else if (e.Location.Y < 0 - Limit / 3 && e.Location.X > 60 + Limit / 3) // Top-Right
                {
                    MovePawn(new Point(this.Location.X + PawnSize, this.Location.Y - PawnSize));
                }
                else if (e.Location.Y > 60 + Limit / 3 && e.Location.X < 0 - Limit / 3) // Bottom-Left
                { 
                    MovePawn(new Point(this.Location.X - PawnSize, this.Location.Y + PawnSize));
                }

                // Normal Movement
                if (e.Location.Y < 0 - Limit) // Forward.
                {
                    MovePawn(new Point(this.Location.X, this.Location.Y - PawnSize));
                }
                else if (e.Location.Y > 60 + Limit) // Backwards.
                {
                    MovePawn(new Point(this.Location.X, this.Location.Y + PawnSize));
                }
                else if (e.Location.X < 0 - Limit) // Left.
                {
                    MovePawn(new Point(this.Location.X - PawnSize, this.Location.Y));
                }
                else if (e.Location.X > 60) // Right.
                {
                    MovePawn(new Point(this.Location.X + PawnSize, this.Location.Y));
                }
            }
        }

        private void MovePawn(Point newLocation)
        {
            var targetLocation = new Rectangle(newLocation, this.Size);

            foreach (var pawn in Board.Controls.OfType<Pawn>())
            {
                if (pawn == this) continue;

                if (pawn.Bounds.IntersectsWith(targetLocation)) 
                {
                    if (this.Tag.Equals(pawn.Tag))
                    {
                        return;
                    }
                    else
                    {
                        Board.Controls.Remove(pawn);
                        pawn.Dispose();
                    }
                }
            }

            if (!(newLocation.X >= Board.Width || newLocation.X < 0 || newLocation.Y >= Board.Height || newLocation.Y < 0))
            {
                this.Location = newLocation;
            }
        }

        private void mouse_Up(object sender, MouseEventArgs e)
        {
            Selected = false;
        }
    }
}
