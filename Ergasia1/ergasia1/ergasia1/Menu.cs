using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ergasia1
{
    public partial class Menu : Form
    {
        private List<string> images;

        String connectionString = "Data Source=c:DB1.db;Version=3;";
        SQLiteConnection conn;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            timerWelcome.Start();
            buttonBack.Hide();
            buttonOpenFolder.Hide();
            buttonShowAttemps.Hide();
            label1Settings.Hide();

            conn = new SQLiteConnection(connectionString);

            // Get images from a folder
            // logika tha prepei na metakinisoume afto to komati sto menu oste na boroume na tou emfanizoume minima an den exei valei eikones sto fakelo
            images = Directory.GetFiles(@"Cards\Default", "*jpg").ToList(); // prepei na tsekaroume pio meta na ontos evale eikones
            images.AddRange(Directory.GetFiles(@"Cards\Default", "*png").ToList()); // prepei na tsekaroume pio meta na ontos evale eikones
            images.AddRange(Directory.GetFiles(@"Cards\Default", "*bmp").ToList()); // prepei na tsekaroume pio meta na ontos evale eikones
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
            buttonExit.Hide();
            
            buttonBack.Show();
            buttonOpenFolder.Show();
            buttonOpenFolder.Location = new Point(362, 107);
            buttonShowAttemps.Show();
            buttonShowAttemps.Location = new Point(362, 157);
            label1Settings.Show();
            label1Settings.Location = new Point(340, 4);
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelWelcome.Show();
            buttonExit.Show();

            buttonBack.Hide();
            buttonOpenFolder.Hide();
            buttonShowAttemps.Hide();
            label1Settings.Hide();
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
            string name = textBoxName.Text;

            conn.Open();
            try
            {
                // elegxei mesa sthn DB an to onoma pou ebale o xrhsths sto textbox uparxei hdh
                /* to ekana etsi giati ta onomata sthn database den einai tikarismena ws monadika dioti o kathe paikths exei polles
                   prospatheies, dld to idio name exei polla times kai attemps. Kai auto sumbainei dioti sto telos ths askhshs leei
                   na deixnoume tis 10 kaluteres prospatheies twn paiktwn, ara oi prospatheies sto idio name einai parapanw apo 1. */
                string selectQuery = "Select Name from Users";
                SQLiteCommand cmd1 = new SQLiteCommand(selectQuery, conn);
                SQLiteDataReader reader = cmd1.ExecuteReader();

                while (reader.Read())
                {
                    if (name.Equals(reader.GetValue(0).ToString()))
                    {
                        throw new Exception();
                    }
                }

                Game game = new Game(new List<string>(images), textBoxName.Text);

                this.Hide();
                game.ShowDialog();
                this.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("This username already exists!");
            }
            conn.Close();
        }

        private void buttonOpenFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get images from a folder
                // logika tha prepei na metakinisoume afto to komati sto menu oste na boroume na tou emfanizoume minima an den exei valei eikones sto fakelo
                var tempImages = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*jpg").ToList(); // prepei na tsekaroume pio meta na ontos evale eikones
                tempImages.AddRange(Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*png").ToList()); // prepei na tsekaroume pio meta na ontos evale eikones
                tempImages.AddRange(Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*bmp").ToList()); // prepei na tsekaroume pio meta na ontos evale eikones

                if (tempImages.Count >= 12)
                {
                    tempImages.RemoveRange(11, tempImages.Count - 12);
                    images = tempImages;
                    Console.WriteLine(tempImages.Count);
                }
                else
                {
                    MessageBox.Show("Error! The images in your folder must be 12 or above.");
                    return;
                }
            }

        }

        // Show Attemps
        private void buttonShowLeaderboard_Click(object sender, EventArgs e)
        {
            TopPlayers topPlayers = new TopPlayers();

            this.Hide();
            topPlayers.ShowDialog();
            this.Show();
        }
    }
}
