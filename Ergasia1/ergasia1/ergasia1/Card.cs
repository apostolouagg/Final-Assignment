﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ergasia1
{
    public class Card : PictureBox
    {
        private Image Img { get;}  // Edo tha apothikevoume thn eikona tou meso tou constractora.
        public string ImgLocation { get; set; }
        private bool Hidden { get; set; } // Flag gia na kseroume an einai flipped h oxi

        public Card(string img)
        {
            Img = Image.FromFile(img);
            ImgLocation = img;

            // flip it
            Hidden = true;
            this.Image = Properties.Resources.back;
        }

        // afth h sinartish einai upefthinh sto na emfanizei / krivh thn eikona ths kartas
        public void Flip()
        {
            if (Hidden) // an h karta dixnei thn krimenh plevra
            {
                this.Image = Img; // Show image
                Hidden = false;
            }
            else
            {
                this.Image = Properties.Resources.back; // Hide image
                Hidden = true;
            }
        }
    }
}
