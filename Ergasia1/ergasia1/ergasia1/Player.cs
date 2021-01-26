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
        public List<Attempt> Attempts { get; set; }

        public Player(string name, List<Attempt> attempts)
        {
            this.Name = name;
            this.Attempts = attempts;
        }
    }
}
