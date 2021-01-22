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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            timerWelcome.Start();
            buttonBack.Hide();
        }

        private void timerWelcome_Tick(object sender, EventArgs e)
        {
            if (labelWelcome.BackColor == Color.DodgerBlue)
            {
                labelWelcome.BackColor = Color.Black;
                labelWelcome.ForeColor = Color.DodgerBlue;
            }
            else
            {
                labelWelcome.ForeColor = Color.Black;
                labelWelcome.BackColor = Color.DodgerBlue;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            panelWelcome.Hide();
            buttonBack.Show();
            buttonExit.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelWelcome.Show();
            buttonBack.Hide();
            buttonExit.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                buttonPlay.Enabled = false;
            }
            else
            {
                buttonPlay.Enabled = true;
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Game game = new Game();

            this.Hide();
            game.ShowDialog();
            this.Show();
        }
    }
}
