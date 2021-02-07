using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chess_Game
{
    public class Player
    {
        public string Name { get; set; }
        public float Time { get; private set; }
        private Timer PlayerTimer { get;}

        public Player(string name)
        {
            this.Name = name;
            this.Time = 120;

            PlayerTimer = new Timer();
            PlayerTimer.Tick += timer_tick;
            PlayerTimer.Interval = 100; // every 0.1 seconds
        }
        private void timer_tick(object sender, EventArgs e)
        {
            Time -= 0.10f;
            if (Time <= 0.00f)
            {
                Time = 0f;
                this.StopTimer();
            }
        }

        public void StartTimer()
        { 
            PlayerTimer.Start();
        }
        public void StopTimer()
        {
            PlayerTimer.Stop();
        }
        public void RestartTimer()
        {
            PlayerTimer.Stop();
            Time = 120;
        }
    }
}
