using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            timerWelcome.Start();
            buttonBack.Hide();

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
            Game game = new Game(images);

            this.Hide();
            game.ShowDialog();
            this.Show();
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
    }
}
