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
        public Pennies(double value, int StartingPennies) : base (value, StartingPennies)
        {

            startingPennies = StartingPennies;
        }
        public Pennies(double value) : base(value)
        {

        }
    }
}
