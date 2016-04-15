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
        public double value;
        public Dimes(double Value, int StartingDimes) : base (Value, StartingDimes)
        {
            startingDimes = StartingDimes;
            value = Value;
        }
        public Dimes(double Value) : base(Value)
        {
            value = Value;
        }
    }
}
