using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    public abstract class Coins
    {
        public double coinValue;
        public int startingCoins;
        public Coins(double CoinValue, int StartingCoins)
        {
            coinValue = CoinValue;
            startingCoins = StartingCoins;
        }
        public Coins(double CoinValue)
        {
            coinValue = CoinValue;
        }

        public void AddToList()
        {
            
        }
    }
}
