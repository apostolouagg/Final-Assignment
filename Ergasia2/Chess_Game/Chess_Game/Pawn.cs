using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Chess_Game
{
    public class Pawn : PictureBox
    {
        private static int PawnSize { get; set; }
        private static int Limit { get; set; }
        private ChessBoard Board { get;}
        private bool Selected { get; set; }
        public Point StartingPosition { get; set; }
        public string Team { get; set; }

        public Pawn(ChessBoard board)
        {
            PawnSize = 60;
            Limit = 15;

            // initialize pictureBox
            this.Board = board;
            this.Size = new Size(PawnSize,PawnSize);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Margin = new Padding(0, 0, 0, 0);
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


                // Normal Movement (allow jumping over pawns)
                if (e.Location.Y < 0 - Limit) // Forward.
                {
                    if (e.Location.Y < 0 - PawnSize - Limit) MovePawn(new Point(this.Location.X, this.Location.Y - PawnSize * 2));
                    else MovePawn(new Point(this.Location.X, this.Location.Y - PawnSize));
                }
                else if (e.Location.Y > PawnSize + Limit) // Backwards.
                {
                    if (e.Location.Y > PawnSize * 2 + Limit) MovePawn(new Point(this.Location.X, this.Location.Y + PawnSize * 2));
                    else MovePawn(new Point(this.Location.X, this.Location.Y + PawnSize));
                }
                else if (e.Location.X < 0 - Limit) // Left.
                {
                    if (e.Location.X < 0 - PawnSize - Limit) MovePawn(new Point(this.Location.X - PawnSize * 2, this.Location.Y));
                    else MovePawn(new Point(this.Location.X - PawnSize, this.Location.Y));
                }
                else if (e.Location.X > PawnSize + Limit) // Right.
                {
                    if (e.Location.X > PawnSize * 2) MovePawn(new Point(this.Location.X + PawnSize * 2, this.Location.Y));
                    else MovePawn(new Point(this.Location.X + PawnSize, this.Location.Y));
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
                    if (this.Team.Equals(pawn.Team))
                    {
                        return;
                    }
                    else
                    {
                        Board.Capture(pawn);
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
            if(this.Team == "White")
            {
                Board.Game.playerWhite.StopTimer();
                Board.Game.playerBlack.StartTimer();
            }
            else
            {
                Board.Game.playerBlack.StopTimer();
                Board.Game.playerWhite.StartTimer();
            }
        }
    }
}
