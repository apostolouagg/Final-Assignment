using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ergasia1
{
    public partial class Game : Form
    {
        private Random random;
        private List<Card> cards;

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            random = new Random((int)DateTime.Now.Ticks);
            cards = new List<Card>();

            int x = 10;
            int y = 10;

            // Create cards
            for (int i = 0; i<4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    var temp = new Card()
                    {
                        Size = new Size(100, 100),
                        Location = new Point(x, y),
                    };

                    this.Controls.Add(temp);
                    cards.Append(temp);
                    x += 100;
                }
                y += 100;
                x = 10;
            }
        }
    }
}
