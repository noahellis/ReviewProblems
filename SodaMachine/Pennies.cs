using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    class Pennies : Coins
    {
        public int startingPennies;
        public double value;
        public Pennies(double Value, int StartingPennies) : base (Value, StartingPennies)
        {

            startingPennies = StartingPennies;
            value = Value;
        }
        public Pennies(double Value) : base(Value)
        {
            value = Value;
        }
    }
}
