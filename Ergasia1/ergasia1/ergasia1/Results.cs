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

namespace ergasia1
{
    /// <summary>
    /// Emfanish results otan teleiwnei to paixnidi
    /// </summary>

    public partial class Results : Form
    {
        string username;
        private String connectionString = "Data Source=c:DB1.db;Version=3;";
        SQLiteConnection conn;

        public Results(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Results_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
            labelUsername.Text = username;
            timer1ForAppearance.Start(); // timer gia ta labels me xrwma

            listBox1.Items.Clear();

            /* pairnei apo thn DB ta stoixeia tou paikth xrhsimopoiontas to onoma tou kai ta bazei sto listbox1 me seira apo megalutero sto
               mikrotero me bash to Attemps */
            conn.Open();
            string selectQuery = "Select Attemps, Time from Users where Name='"+username+"' order by Attemps DESC";
            SQLiteCommand cmd = new SQLiteCommand(selectQuery, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listBox1.Items.Add("           "+ reader.GetValue(0).ToString() + "                                " + reader.GetValue(1).ToString());
            }
            conn.Close();

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
