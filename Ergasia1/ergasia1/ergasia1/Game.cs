using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ergasia1
{
    public partial class Game : Form
    {
        private static Random random;

        private Card first;
        private Card second;

        private List<string> images;

        private string username;
        private int time;
        private int sameCards;
        private int attemps;
        private bool started;

        String connectionString = "Data Source=DB1.db;Version=3;";

        public Game(List<string> imageList, string user)
        {
            InitializeComponent();
            images = imageList;
            username = user;
        }

        // Randomizes a list
        public static List<string> Randomize(List<string> images)
        {
            random = new Random((int) DateTime.Now.Ticks);

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

            images.AddRange(images); // add the same images to the image list so its 12 + 12
            images = Randomize(images); // randomize it

            // Create 24 cards | 6 X 4 
            for (int i = 0; i < 24; i++)
            {
                var card = new Card(images[i])
                {
                    Size = new Size(100, 100),
                    Margin = new Padding(4), // To keno metaksi kathe eikonas einai 4 pixels
                    BorderStyle = BorderStyle.FixedSingle, // Border around the card
                    Cursor = Cursors.Hand, // Add hand cursor when hovering over it
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                // Add an event handler for mouseClick to the card
                card.MouseClick += Card_Click;
                 
                // Add card to panel
                flowLayoutPanelCards.Controls.Add(card);
            }

            flowLayoutPanelCards.Enabled = false; // Disable panel first so the user cant click any card while showing
            ShowAllCards();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            // On first card clicked
            if (!started)
            {
                timerGameDuration.Start();
                labelAttemps.Text = (++attemps).ToString();
                started = true;
            }

            // Card pressed
            Card clicked = (Card)sender;
            clicked.Flip();

            if (first == null)
            {
                first = clicked;
            }
            else
            {
                if (clicked != first) // Checks if the second card pressed is the same as the first 
                {
                    second = clicked;
                    if (first.ImagePathLocation == second.ImagePathLocation) // If same picture disable the cards
                    {
                        first.Enabled = false;
                        second.Enabled = false;

                        // reset clicked
                        first = null;
                        second = null;

                        // adding number of same cards
                        sameCards++;
                    }
                    else // If wrong stop the user from choosing another one for 500ms
                    {
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
                            catch (Exception)
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
                timerGameDuration.Stop(); // Stop Timer
                buttonRestart.Enabled = true; // Enable Restart button

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    // Add the the game played to the Database
                    conn.Open();
                    string insertQuery = $"Insert into Users(Name, Time, Attemps) values('{username}', '{time}', '{attemps}')";
                    SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn);
                    cmd.ExecuteNonQuery();
                }

                // Open result form
                Results results = new Results(username);
                results.ShowDialog();
            }
        }

        private void timerGameDuration_Tick(object sender, EventArgs e)
        {
            labelTime.Text = (++time).ToString(); // Show user the time
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
            flowLayoutPanelCards.Enabled = false;
            // Makes Restart appear smoother to the user
            Task.Run(() =>
            {
                try
                {
                    foreach (var card in flowLayoutPanelCards.Controls.OfType<Card>())
                    {
                        Invoke(new Action(() =>
                        {
                            card.Flip();
                            card.Enabled = true;
                            card.ChangeImage(images[i++]);
                        }));
                        Thread.Sleep(100);
                    }

                }
                catch (Exception)
                {
                    //
                }
                Thread.Sleep(500);
                ShowAllCards();
            });
        }

        // Shows all cards for 4s
        private void ShowAllCards()
        {
            // Create a thread so the main thread doesn't freeze (faster than creating a timer)
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

                    Thread.Sleep(4000); // Wait 4 Seconds for the user to memorize the cards.

                    Invoke(new Action(() =>
                    {
                        foreach (var card in flowLayoutPanelCards.Controls.OfType<Card>())
                        {
                            card.Flip();
                        }
                    }));

                    // Enable panel
                    Invoke(new Action(() =>
                    {
                        flowLayoutPanelCards.Enabled = true;
                    }));
                }
                catch (Exception)
                {
                    //
                }

            });
        }

        // Quit button
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
