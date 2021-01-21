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
    public partial class Form2 : Form
    {
        List<Card> cards = new List<Card>();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int x = 10;
            int y = 10;
            bool h = true;

            for (int i = 0; i<4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    var temp = new Card()
                    {
                        Size = new Size(100, 100),
                        Location = new Point(x, y),
                    };
                    

                    if (h) {
                        temp.BackColor = Color.Red;
                        h = false;
                    }
                    else {
                        temp.BackColor = Color.Blue;
                        h = true;
                    }

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
