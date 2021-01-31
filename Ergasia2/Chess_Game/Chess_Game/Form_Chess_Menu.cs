using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_Game
{
    public partial class Form_Chess_Menu : Form
    {
        private String connectionString = "Data Source=c:DB1.db;Version=3;";
        public Form_Chess_Menu()
        {
            InitializeComponent();
        }

        private void button_Play_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Player1.Text) || string.IsNullOrWhiteSpace(textBox_Player2.Text))
            {
                MessageBox.Show("You need to write Player 1 & Player 2 name!");
            }
            else
            {
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string insertQuery = $"Insert into PLayers(Player1, Player2, Date) values('{textBox_Player1.Text}','{textBox_Player2.Text}','{DateTime.Now}')";
                    SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn);
                    cmd.ExecuteNonQuery();
                }

                // Create players
                Player p1 = new Player(textBox_Player1.Text);
                Player p2 = new Player(textBox_Player2.Text);

                // Start Game
                this.Hide();
                Form_Chess_Game game = new Form_Chess_Game(p1,p2);
                game.ShowDialog();
                this.Show();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
