using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ergasia1
{
    public class Attempt
    {
        public int Time { get; set; }
        public int AttemptNumber { get; set; }
        public Attempt(int time, int attempt)
        {
            this.Time = time;
            this.AttemptNumber = attempt;
        }
    }
}
