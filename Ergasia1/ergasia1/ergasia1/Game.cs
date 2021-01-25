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

        string username;
        int time = 0;
        int sameCards = 0;
        int attemps = 0;

        String connectionString = "Data Source=c:DB1.db;Version=3;";
        SQLiteConnection conn;

        // To do list:
        // 1. Na kanei flip tis eikones otan pataei restart (kai ustera na tis anoigei ksana gia na ginei to 2)
        // 2. sthn arxh na anoigei tis kartes gia 5 deuterolepta gia na tis blepei o paikths kai meta na tis kleinei  <- to 2
        // 3. o timer na ksekinaei thn wra pou oi kartes kleinoun (afou ginei to 2)
        // 4. na prosthetei grammes sthn SQLite me to idio onoma alla diaforetika time kai attempt (giati NOMIZW pws telika den to katafera)
        public Game(List<string> imageList, string user)
        {
            InitializeComponent();
            images = imageList;
            username = user;
        }

        // kanei th images random
        // afto einai poli paromio me kati pou vrika sto google elpizo min theorithei antigrafh :(((((
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
            conn = new SQLiteConnection(connectionString);

            labelUsername.Text = username; // deixnei to username
            labelTime.Text = time.ToString(); // deixnei to xrono se deuterolepta
            buttonRestart.Enabled = false; // to koubi restart einai disabled

            // Initialize Random
            random = new Random((int)DateTime.Now.Ticks);

            images.AddRange(images); // add the same images. so 12 + 12
            images = Randomize(images); // randomize it

            // Create 24 cards | 6 X 4 
            // to aplopiisa poli
            // to int name einai axristo min sas niazei to aferoume an einai
            int name = 0;
            for (int i = 0; i < 24; i++)
            {
                var card = new Card(images[i])
                {
                    Size = new Size(100, 100),
                    Margin = new Padding(4), // To keno metaksi kathe eikonas einai 4 pixels
                    BorderStyle = BorderStyle.FixedSingle, // na exoun border oi kartes
                    Cursor = Cursors.Hand, // Add hand cursor when hovering over it
                    Name = name++.ToString(), // give it a name
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                // tou dinoume ena event handel gia otan pataei o xrhsths click pano tou
                card.MouseClick += Card_Click;
                 
                // Prosthetoume thn karta sto panel
                flowLayoutPanelCards.Controls.Add(card);
            }
        }

        // Trexei kathe fora pou o xrisths pataei mia apo tis kartes
        private void Card_Click(object sender, EventArgs e)
        {
            // Otan ksekinaei to paixnidi
            if (time == 0)
            {
                timerGameDuration.Start(); // ksekinaei na metraei o xronos
                labelAttemps.Text = attemps++.ToString(); // metraei thn prospatheia kai thn emfanizei
                buttonRestart.Enabled = false; // kanei disable to restart button
            }

            // Etsi prosdiourizoume pia karta patithike
            Card clicked = (Card)sender;

            // Emfanizoume to onoma ths kartas pou patithike
            Console.WriteLine($"Clicked card '{clicked.Name}'");
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
                        Console.WriteLine($"CORRECT {first.Name} the same as {second.Name}");
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
                        });
                        Console.WriteLine($"WRONG {first.Name} not the same as {second.Name}");
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

                // updates the DB / gia kapoio logo de ftiaxnei kainourgia grammh me to idio onoma xrhsth
                conn.Open();
                string insertQuery = $"Insert into Users(Name, Time, Attemps) values('{username}', '{time}', '{attemps}')";
                SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn);
                int count = cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void timerGameDuration_Tick(object sender, EventArgs e)
        {
            labelTime.Text = time++.ToString(); // deixnei ton xrono ston paikth thn wra pou paizei
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            time = 0;
            buttonRestart.Enabled = false;

            // den kserw pws na kanw flip tis eikones gia na ksekinisei pali to paixnidi
            /*flowLayoutPanelCards.Enabled = true;
            
            Task.Run(() =>
            {
                Invoke(new Action(() =>
                {
                    flowLayoutPanelCards.Enabled = true;
                    first = null;
                    second = null;
                }));


            });*/
        }
    }
}
