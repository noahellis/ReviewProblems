using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    class Quarters : Coins
    {
        public int startingQuarters;
        public Quarters(double value, int StartingQuarters) : base(value, StartingQuarters)
        {
            startingQuarters = StartingQuarters;
        }
        public Quarters(double value) : base (value)
        {

        }
    }
}
