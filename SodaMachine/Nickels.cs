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
        public Nickels(double value, int StartingNickels) : base (value, StartingNickels)
        {
            startingNickels = StartingNickels;
        }
        public Nickels(double value) : base (value)
        {

        }
    }
}
