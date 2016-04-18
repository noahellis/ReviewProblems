using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    class Nickels : Coins
    {
        public int startingNickels;
        public double value;
        public Nickels(double Value) : base (Value)
        {
            value = Value;
        }
    }
}
