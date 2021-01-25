using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_Game
{
    public partial class Form_Chess_Menu : Form
    {
        public Form_Chess_Menu()
        {
            InitializeComponent();
        }

        private void button_Play_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Player1.Text) || string.IsNullOrWhiteSpace(textBox_Player2.Text))
            {
                MessageBox.Show("You need to write Player 1/ Player 2 name!");
            }
            else
            {
                this.Hide();
                Form_Chess_Game game = new Form_Chess_Game();
                game.Show();
            }
        }
    }
}
