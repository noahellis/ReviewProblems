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
        public double value;
        public Quarters(double Value, int StartingQuarters) : base(Value, StartingQuarters)
        {
            startingQuarters = StartingQuarters;
            value = Value;
        }
        public Quarters(double Value) : base (Value)
        {
            value = Value;
        }
    }
}
