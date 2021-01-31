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
        private static int PawnSize { get; } = 60;
        private static Panel Board { get; set; }
        private static int Limit { get; } = 15;
        private bool Selected { get; set; }

        public Pawn(Panel board)
        {
            Board = board;
            this.Size = new Size(PawnSize,PawnSize);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Color.Transparent;
            this.Cursor = Cursors.Hand;
            this.MouseDown += mouse_Down;
            this.MouseMove += mouse_Move;
            this.MouseUp += mouse_Up;

            // Add it to the board
            Board.Controls.Add(this);
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
                if (e.Location.Y < 0 /*- Limit / 3*/ && e.Location.X < 0 /*- Limit / 3*/) // Top-Left
                {
                    this.Location = new Point(this.Location.X - PawnSize, this.Location.Y - PawnSize);
                }
                else if (e.Location.Y > 60 /*+ Limit / 3*/ && e.Location.X > 60 /*+ Limit / 3*/) // Bottom-Right
                {
                    this.Location = new Point(this.Location.X + PawnSize, this.Location.Y + PawnSize);
                }
                else if (e.Location.Y < 0 /*- Limit / 3*/ && e.Location.X > 60 /*+ Limit / 3*/) // Top-Right
                {
                    this.Location = new Point(this.Location.X + PawnSize, this.Location.Y - PawnSize);
                }
                else if (e.Location.Y > 60 /*+ Limit / 3*/ && e.Location.X < 0 /*- Limit / 3*/) // Bottom-Left
                {
                    this.Location = new Point(this.Location.X - PawnSize, this.Location.Y + PawnSize);
                }

                // Normal Movement
                if (e.Location.Y < 0 - Limit) // Forward.
                {
                    this.Location = new Point(this.Location.X, this.Location.Y - PawnSize);
                }
                else if (e.Location.Y > 60 + Limit) // Backwards.
                {
                    this.Location = new Point(this.Location.X, this.Location.Y + PawnSize);
                }
                else if (e.Location.X < 0 - Limit) // Left.
                {
                    this.Location = new Point(this.Location.X - PawnSize, this.Location.Y);
                }
                else if (e.Location.X > 60 + Limit) // Right.
                {
                    this.Location = new Point(this.Location.X + PawnSize, this.Location.Y);
                }
            }
        }

        private void mouse_Up(object sender, MouseEventArgs e)
        {
            Selected = false;
        }
    }
}
