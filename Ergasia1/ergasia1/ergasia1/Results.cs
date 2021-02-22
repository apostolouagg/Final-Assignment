using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace ergasia1
{
    // Emfanish results otan teleiwnei to paixnidi
    public partial class Results : Form
    {
        string username;
        private String connectionString = "Data Source=DB1.db;Version=3;";

        public Results(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Results_Load(object sender, EventArgs e)
        {
            labelUsername.Text = username;
            timer1ForAppearance.Start(); // timer gia ta labels me xrwma
            listBox1.Items.Clear();

            /* pairnei apo thn DB ta stoixeia tou paikth xrhsimopoiontas to onoma tou kai ta bazei sto listbox1 me seira apo megalutero sto
            mikrotero me bash to Attemps */
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string selectQuery = $"SELECT Attemps, Time FROM Users WHERE Name='{username}' ORDER BY Attemps DESC";
                SQLiteCommand cmd = new SQLiteCommand(selectQuery, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add($"           " + reader.GetValue(0).ToString() + "                                " + reader.GetValue(1).ToString());
                }

            }
        }

        // Gia na allazoun xrwma ta labels
        private void timer1ForAppearance_Tick(object sender, EventArgs e)
        {
            if (label1GoodJob.ForeColor == Color.DodgerBlue)
            {
                label1GoodJob.ForeColor = Color.Black;
                labelUsername.ForeColor = Color.Black;
            }
            else
            {
                label1GoodJob.ForeColor = Color.DodgerBlue;
                labelUsername.ForeColor = Color.DodgerBlue;
            }
        }

        private void buttonBackToGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
