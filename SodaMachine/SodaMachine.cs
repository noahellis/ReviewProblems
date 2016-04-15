using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    class SodaMachine
    {
        private List<Coins> coinList = new List<Coins>();
        private List<Soda> sodaList = new List<Soda>();
        Coins sodaMachineCoins;
        Soda sodaMachineSodas = new Soda();
        public SodaMachine()
        {
            AddStartingCoins();
            AddStartingSodaStock();
        }

        public List<Coins> CoinList
        {
            get
            {
                return coinList;
            }

            set
            {
                coinList = value;
            }
        }

        public List<Soda> SodaList
        {
            get
            {
                return sodaList;
            }

            set
            {
                sodaList = value;
            }
        }
        public void PutInChange()
        {
            int choiceQuarters;
            int choiceDimes;
            int choiceNickels;
            int choicePennies;
            Console.WriteLine("How many Quarters will you put in?");
            choiceQuarters = int.Parse(Console.ReadLine());
            Console.WriteLine("How many Dimes will you put in?");
            choiceDimes = int.Parse(Console.ReadLine());
            Console.WriteLine("How many Nickels will you put in?");
            choiceNickels = int.Parse(Console.ReadLine());
            Console.WriteLine("How many Pennies will you put in?");
            choicePennies = int.Parse(Console.ReadLine());
            double total = ((choicePennies * .01) + (choiceNickels * .05) + (choiceDimes * .1) + (choiceQuarters * .25));
            Console.WriteLine("You have inserted {0:C2}", total);

        }

        public void AddStartingCoins()
        {
            Pennies addStartingPennies = new Pennies(.01, 50);
            for(int pennyIndex = 0; pennyIndex < addStartingPennies.startingPennies; pennyIndex++)
            {
                coinList.Add(new Pennies(.01));
            }
            Nickels addStartingNickels = new Nickels(.05, 20);
            for (int nickelIndex = 0; nickelIndex < addStartingNickels.startingNickels; nickelIndex++)
            {
                coinList.Add(new Nickels(.05));
            }
            Dimes addStartingDimes = new Dimes(.1, 10);
            for (int dimeIndex = 0; dimeIndex < addStartingDimes.startingDimes; dimeIndex++)
            {
                coinList.Add(new Dimes(.1));
            }
            Quarters addStartingQuarters = new Quarters(.25, 20);
            for (int quarterIndex = 0; quarterIndex < addStartingQuarters.startingQuarters; quarterIndex++)
            {
                coinList.Add(new Quarters(.25));
            }

        }
        public void AddStartingSodaStock()
        {
            sodaList.Add(new GrapeSoda(.6, 30));
            for (int grapeSodaIndex = 0; grapeSodaIndex < AddStartingSodaStock.)
            sodaList.Add(new OrangeSoda(.35, 20));
            sodaList.Add(new MeatSoda(.06, 20));
        }
    }
}
