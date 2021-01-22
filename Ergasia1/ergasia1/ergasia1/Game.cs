using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private List<Card> cards;

        private Card first;
        private Card second;


        // na tou valoume na dexete:
        // 1. Onoma pexth
        // 2. Ton fakelo apo ton opoio tha parei tis eikones( giati ta settings vriskonte sto menu)
        public Game()
        {
            InitializeComponent();
        }

        
        // kanei th list random
        // afto einai poli paromio me kati pou vrika sto google elpizo min theorithei antigrafh :(((((
        private List<string> Randomize(List<string> list)
        {
            List<string> randomized = new List<string>();
            while (list.Count > 0)
            {
                var index = random.Next(0, list.Count);
                randomized.Add(list[index]);
                list.RemoveAt(index);
            }
            return randomized;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            // Initialize Random
            random = new Random((int)DateTime.Now.Ticks);
            cards = new List<Card>();

            // Get images from a folder
            // logika tha prepei na metakinisoume afto to komati sto menu oste na boroume na tou emfanizoume minima an den exei valei eikones sto fakelo
            var images = Directory.GetFiles($@"Cards/Default").ToList(); // prepei na tsekaroume pio meta na ontos evale eikones
            images.AddRange(images); // add the same images. so 12 + 12
            var randomizedImages = Randomize(images); // randomize it

            // Create 24 cards | 6 X 4 
            // to aplopiisa poli
            // to int name einai axristo min sas niazei to aferoume an einai
            int name = 0;
            for (int i = 0; i < 24; i++)
            {
                var card = new Card(randomizedImages[i])
                {
                    Size = new Size(100, 100),
                    Margin = new Padding(4), // To keno metaksi kathe eikonas einai 4 pixels
                    BorderStyle = BorderStyle.FixedSingle, // na exoun border oi kartes
                    Cursor = Cursors.Hand, // Add hand cursor when hovering over it
                    Name = name++.ToString(), // give it a name
                };
                
                // tou dinoume ena event handel gia otan pataei o xrhsths click pano tou
                card.MouseClick += Card_Click;

                // Prosthetoume thn karta sto panel
                flowLayoutPanelCards.Controls.Add(card);
                cards.Add(card);
            }
        }

        // Trexei kathe fora pou o xrisths pataei mia apo tis kartes
        // Tsekarei an oi 2 eikones pou patise einai idies( vash to path )
        // prepei na valoume ena timer sto deftero click giati: otan patame to deftero an einai lathos o sindiasmos den tha to diksei kan giati to 
        // girnaei kai to ksanagirnaei poli grigora. ara prepei na valoume ena timer otan to girnaei na perimenei 500ms kai meta na to ksanagirnaei
        // gia na dei o xrhshts ti ekane lathos
        private void Card_Click(object sender, EventArgs e)
        {
            // Etsi prosdiourizoume pia karta patithike
            Card clicked = (Card) sender;

            // Emfanizoume to onoma ths kartas pou patithike
            Console.WriteLine($"Clicked card '{clicked.Name}'");

            clicked.Flip();
            if (first == null)
            {
                first = clicked;
            }
            else
            {
                if (clicked != first) // an ksanapatisei to idio apo epilekse to
                {
                    second = clicked;
                    if (first.ImgLocation == second.ImgLocation) 
                    {
                        // an einai sosta ta kanoume disable oste na min mporei na ta patisei pali
                        Console.WriteLine($"CORRECT {first.Name} the same as {second.Name}");
                        first.Enabled = false;
                        second.Enabled = false;

                        // reset clicked
                        first = null;
                        second = null;
                    }
                    else
                    {
                        // hide them again if wrong
                        first.Flip();
                        second.Flip();
                        Console.WriteLine($"WRONG {first.Name} not the same as {second.Name}");
                        // reset clicked
                        first = null;
                        second = null;
                    }
                }
                else
                {
                    first = null;
                }
            }
        }
    }
}
