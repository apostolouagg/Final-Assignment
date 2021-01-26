using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ergasia1
{
    public partial class TopPlayers : Form
    {
        private string connectionstring = "Data Source=c:DB1.db;Version=3;";
        private List<Player> playerList;

        public TopPlayers()
        {
            InitializeComponent();
        }

        private void TopPlayers_Load(object sender, EventArgs e)
        {
            playerList = new List<Player>();
            using (SQLiteConnection conn = new SQLiteConnection(connectionstring)) //(automatically closes the connection)
            {
                conn.Open();
                string selectQuery = "SELECT Name, Time, Attemps FROM Users;";
                SQLiteCommand cmd = new SQLiteCommand(selectQuery, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) // episis aggeliki edo vazeis While oxi If
                {
                    if (playerList.Any(x=>x.Name == reader.GetString(0))) // if user exist in the list then we just add its attempt
                    {
                        playerList.Find(x=>x.Name == reader.GetString(0)).Attempts.Add(new Attempt(reader.GetInt16(1), reader.GetInt16(2)));
                        Console.WriteLine(playerList.Find(x => x.Name == reader.GetString(0)).Name);
                    }
                    else // if user doesn't exist we add him to the list with its attempt
                    {
                        playerList.Add(new Player(reader.GetString(0), new List<Attempt>
                        {
                            new Attempt(reader.GetInt16(1), reader.GetInt16(2))
                        }));
                    }
                }

                // We add only the names of the player list
                listBox1.DataSource = playerList.Select(x => x.Name).ToList();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            var selected = playerList.Find(x => x.Name == listBox1.SelectedItem.ToString());
            foreach (var selectedAttempt in selected.Attempts)
            {
                listBox2.Items.Add($"Attempt:{selectedAttempt.AttemptNumber} | Time:{selectedAttempt.Time}");
            }
        }
    }
}
