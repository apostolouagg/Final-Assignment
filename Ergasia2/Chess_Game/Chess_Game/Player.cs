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
        public int Time { get; private set; }
        private Timer PlayerTimer { get;}

        public Player(string name)
        {
            this.Name = name;
            this.Time = 0;
            PlayerTimer = new Timer();
            PlayerTimer.Tick += timer_tick;
            PlayerTimer.Interval = 1000;
        }
        private void timer_tick(object sender, EventArgs e)
        {
            Time += 1;
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
            Time = 0;
        }
    }
}
