using System.Collections.Generic;

namespace ergasia1
{
    public class Player
    {
        public string Name { get; set; }
        public List<Attempt> Attempts { get; set; } // Kathe pexths exei 1 lista me tis prospathies tou

        public Player(string name, List<Attempt> attempts)
        {
            this.Name = name;
            this.Attempts = attempts;
        }
    }
}
