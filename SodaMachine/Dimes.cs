using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    class Dimes : Coins
    {
        public int startingDimes;
        public Dimes(double value, int StartingDimes) : base (value, StartingDimes)
        {
            startingDimes = StartingDimes;
        }
        public Dimes(double value) : base(value)
        {

        }
    }
}
