using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
