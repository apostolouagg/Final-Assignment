using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ergasia1
{
    public partial class Game : Form
    {
        private Random random;

        private Card first;
        private Card second;

        private List<string> images;

        private string username;
        private int time;
        private int sameCards;
        private int attemps;
        private bool started;

        String connectionString = "Data Source=c:DB1.db;Version=3;";

        //To timer ksekinaei oti pataei click
        public Game(List<string> imageList, string user)
        {
            InitializeComponent();
            images = imageList;
            username = user;
        }

        // kanei th images random
        private List<string> Randomize(List<string> images)
        {
            var randomizedImages = new List<string>();
            while (images.Count > 0)
            {
                int index = random.Next(0, images.Count);
                randomizedImages.Add(images[index]);
                images.RemoveAt(index);
            }
            return randomizedImages;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            labelUsername.Text = username; // deixnei to username
            labelTime.Text = time.ToString(); // deixnei to xrono se deuterolepta
            buttonRestart.Enabled = false; // to koubi restart einai disabled
            labelAttemps.Text = attemps.ToString();

            time = 0;
            sameCards = 0;
            attemps = 0;
            started = false;

            // Initialize Random
            random = new Random((int)DateTime.Now.Ticks);

            images.AddRange(images); // add the same images. so 12 + 12
            images = Randomize(images); // randomize it

            // Create 24 cards | 6 X 4 
            for (int i = 0; i < 24; i++)
            {
                var card = new Card(images[i])
                {
                    Size = new Size(100, 100),
                    Margin = new Padding(4), // To keno metaksi kathe eikonas einai 4 pixels
                    BorderStyle = BorderStyle.FixedSingle, // na exoun border oi kartes
                    Cursor = Cursors.Hand, // Add hand cursor when hovering over it
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                // tou dinoume ena event handel gia otan pataei o xrhsths click pano tou
                card.MouseClick += Card_Click;
                 
                // Prosthetoume thn karta sto panel
                flowLayoutPanelCards.Controls.Add(card);
            }

            ShowAllCards();
        }

        // Trexei kathe fora pou o xrisths pataei mia apo tis kartes
        private void Card_Click(object sender, EventArgs e)
        {
            // Otan ksekinaei to paixnidi
            if (!started)
            {
                timerGameDuration.Start(); // ksekinaei na metraei o xronos
                labelAttemps.Text = (++attemps).ToString(); // metraei thn prospatheia kai thn emfanizei
                started = true;
            }

            // Etsi prosdiourizoume pia karta patithike
            Card clicked = (Card)sender;

            // Emfanizoume to onoma ths kartas pou patithike
            clicked.Flip();

            if (first == null)
            {
                first = clicked;
            }
            else
            {
                if (clicked != first) // an ksanapatisei to idio kse-epilekse to
                {
                    second = clicked;
                    if (first.ImagePathLocation == second.ImagePathLocation) 
                    {
                        // an einai sosta ta kanoume disable oste na min mporei na ta patisei pali
                        first.Enabled = false;
                        second.Enabled = false;

                        // reset clicked
                        first = null;
                        second = null;

                        // adding number of same cards
                        sameCards++;
                    }
                    else
                    {
                        // hide them again if wrong
                        Task.Run(() =>
                        {
                            try
                            {
                                Invoke(new Action(() => { flowLayoutPanelCards.Enabled = false; }));

                                Thread.Sleep(500); // 500ms pause

                                Invoke(new Action(() =>
                                {
                                    first.Flip();
                                    second.Flip();
                                    first = null;
                                    second = null;
                                    flowLayoutPanelCards.Enabled = true;
                                }));
                            }
                            catch (Exception exception)
                            {
                                //
                            }
                           
                        });
                    }
                }
                else
                {
                    first = null;
                }
            }

            // an oles oi kartes exoun gurisei dld o xrhsths kerdise
            if (sameCards == 12)
            {
                timerGameDuration.Stop(); // stamataei to timer efoson teleiwse to paixnidi
                buttonRestart.Enabled = true; // mporei na kanei restart efoson teleiwse to paixnidi

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    // updates the DB / ftiaxnei kainourgia grammh me to idio onoma xrhsth
                    conn.Open();
                    string insertQuery = $"Insert into Users(Name, Time, Attemps) values('{username}', '{time}', '{attemps}')";
                    SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn);
                    cmd.ExecuteNonQuery();
                }

                Results results = new Results(username);
                results.ShowDialog();
            }
        }

        private void timerGameDuration_Tick(object sender, EventArgs e)
        {
            labelTime.Text = (++time).ToString(); // deixnei ton xrono ston paikth thn wra pou paizei
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            buttonRestart.Enabled = false;

            time = 0;
            sameCards = 0;
            started = false;

            // Flip all cards and randomize them again
            var i = 0;
            images = Randomize(images);
            foreach (var card in flowLayoutPanelCards.Controls.OfType<Card>())
            {
                card.Flip();
                card.Enabled = true;
                card.ChangeImage(images[i++]);
            }

            Task.Run(() => { Invoke(new Action(() => { Thread.Sleep(1000); })); });
            ShowAllCards();
        }

        // Shows all cards for 4s
        private void ShowAllCards()
        {
            // Disable panel
            flowLayoutPanelCards.Enabled = false;

            Task.Run(() =>
            {
                try
                {
                    Invoke(new Action(() =>
                    {
                        foreach (var card in flowLayoutPanelCards.Controls.OfType<Card>())
                        {
                            card.Flip();
                        }
                    }));

                    Thread.Sleep(4000);

                    Invoke(new Action(() =>
                    {
                        foreach (var card in flowLayoutPanelCards.Controls.OfType<Card>())
                        {
                            card.Flip();
                        }
                    }));

                    // Enable panel
                    Invoke(new Action(() => { flowLayoutPanelCards.Enabled = true; }));
                }
                catch (Exception exception)
                {
                    // An klisoume to game eno trexei to ShowAllCards petaei exception
                }

            });
            
        }

        //Quit button
        private void buttonQuti_Click(object sender, EventArgs e)
        {
            timerGameDuration.Stop(); // otan petagetai to messageBox o xronos stamataei
            var answer = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                timerGameDuration.Start(); // an o xrhsths den kanei quit o xronos sunexizetai
            }
        }
    }
}
