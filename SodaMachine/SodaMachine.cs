using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    class SodaMachine
    {
        int startingPennies = 50;
        int startingNickels = 20;
        int startingDimes = 10;
        int startingQuarters = 20;
        int startingGrape = 30;
        int startingOrange = 20;
        int startingMeat = 20;
        int insertedQuarters;
        int insertedDimes;
        int insertedNickels;
        int insertedPennies;
        int choice;
        decimal changeAmount;
        decimal total;
        bool enoughChange;
        public List<Coins> inputtedCoins = new List<Coins>();
        private List<Coins> coinList = new List<Coins>();
        private List<Soda> grapeSodaList = new List<Soda>();
        private List<Soda> orangeSodaList = new List<Soda>();
        private List<Soda> meatSodaList = new List<Soda>();
        private List<Quarters> quarterList = new List<Quarters>();
        private List<Dimes> dimeList = new List<Dimes>();
        private List<Nickels> nickelList = new List<Nickels>();
        private List<Pennies> pennyList = new List<Pennies>();
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

        internal List<Soda> GrapeSodaList
        {
            get
            {
                return grapeSodaList;
            }

            set
            {
                grapeSodaList = value;
            }
        }

        internal List<Soda> OrangeSodaList
        {
            get
            {
                return orangeSodaList;
            }

            set
            {
                orangeSodaList = value;
            }
        }

        internal List<Soda> MeatSodaList
        {
            get
            {
                return meatSodaList;
            }

            set
            {
                meatSodaList = value;
            }
        }

        public int? PutInChange()
        {

            Console.WriteLine("Menu:\nGrape Soda ($.60)\nOrange Soda ($.35)\nMeat Soda ($.06)");
            Console.WriteLine("How many Quarters will you put in?");
            PutInQuarters();
            PutInDimes();
            PutInNickels();
            PutInPennies();
            total = ((insertedPennies * .01m) + (insertedNickels * .05m) + (insertedDimes * .1m) + (insertedQuarters * .25m));
            Console.WriteLine("You have inserted {0:C2}", total);
            AddInsertedCoinsToList();
            SelectSoda();
            return null;
        }
        public int? PutInQuarters()
        {
            try
            {
                insertedQuarters = int.Parse(Console.ReadLine());
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter a positive whole number");
                return PutInChange();
            }
        }
        
        public int? PutInDimes()
        {
            Console.WriteLine("How many Dimes will you put in?");
            try
            {
                insertedDimes = int.Parse(Console.ReadLine());
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter a positive whole number");
                return PutInDimes();
            }
        }
        public int? PutInNickels()
        {
            Console.WriteLine("How many Nickels will you put in?");
            try
            {
                insertedNickels = int.Parse(Console.ReadLine());
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter a positive whole number");
                return PutInNickels();
            }
        }
        public int? PutInPennies()
        {
            Console.WriteLine("How many Pennies will you put in?");
            try
            {
                insertedPennies = int.Parse(Console.ReadLine());
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter a positive whole number");
                return PutInPennies();
            }
        }        

        public int? SelectSoda()
        {
            Console.WriteLine("Select which soda you would like");
            Console.WriteLine("1:Grape($.60)\n2:Orange($..35)\n3:Meat($.06)");
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter a positive whole number");
                return SelectSoda();
            }
            switch (choice)
            {
                case 1:
                    BuyGrape();
                    return null;
                case 2:
                    BuyOrange();
                    return null;
                case 3:
                    BuyMeat();
                    return null;
                default:
                    Console.WriteLine("Incorrect Input, please try again");
                    return SelectSoda();
            }
        }
        public int? AskToBuyAnother()
        {
            Console.WriteLine("\nWould you like to buy another soda?\nEnter 1 for yes, 2 for no");
            try
            {
                choice = int.Parse(Console.ReadLine());
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter a positive whole number");
                return AskToBuyAnother();
            }
            switch (choice)
            {
                case 1:
                    PutInChange();
                    return null;
                case 2:
                    Environment.Exit(0);
                    return null;
                default:
                    Console.WriteLine("Incorrect input, please try again");
                    return AskToBuyAnother();
            }
        }

        public void BuyGrape()
        {
            if (grapeSodaList.Count > 0)
            {
                if (total < .60m)
                {
                    Console.WriteLine("Sorry you did not put enough money in to buy Grape Soda");
                    Console.WriteLine("Your coins are returned");
                    inputtedCoins.Clear();
                    AskToBuyAnother();

                }
                else if (total == .60m)
                {
                    Console.WriteLine("Grape Soda Dispensed!");
                    grapeSodaList.RemoveAt(0);
                    foreach (Coins coins in inputtedCoins)
                    {
                        if (coins.coinValue == .25)
                        {
                            quarterList.Add(new Quarters(.25));
                        }
                        else if (coins.coinValue == .1)
                        {
                            dimeList.Add(new Dimes(.1));
                        }
                        else if (coins.coinValue == .05)
                        {
                            nickelList.Add(new Nickels(.05));
                        }
                        else if (coins.coinValue == .01)
                        {
                            pennyList.Add(new Pennies(.01));
                        }
                    }
                    AskToBuyAnother();
                }
                else if (total > .60m)
                {
                    changeAmount = total - .6m;
                    CheckForAdequateChange();
                    if (enoughChange)
                    {
                        Console.WriteLine("Grape Soda Dispensed!");
                        grapeSodaList.RemoveAt(0);
                        foreach (Coins coins in inputtedCoins)
                        {
                            if (coins.coinValue == .25)
                            {
                                quarterList.Add(new Quarters(.25));
                            }
                            else if (coins.coinValue == .1)
                            {
                                dimeList.Add(new Dimes(.1));
                            }
                            else if (coins.coinValue == .05)
                            {
                                nickelList.Add(new Nickels(.05));
                            }
                            else if (coins.coinValue == .01)
                            {
                                pennyList.Add(new Pennies(.01));
                            }
                        }                        
                        GiveChange();
                        AskToBuyAnother();
                    }
                    else if (!enoughChange)
                    {
                        Console.WriteLine("Sorry, this machine is out of change. Please use exact change");
                        Console.WriteLine("Your coins have been returned");
                        inputtedCoins.Clear();
                        AskToBuyAnother();
                    }
                }
            }
            else
            {
                Console.WriteLine("Sorry this machine is out of Grape Soda");
                Console.WriteLine("Your coins are returned");
                inputtedCoins.Clear();
                AskToBuyAnother();
            }
        }

        public void BuyOrange()
        {
            if (orangeSodaList.Count > 0)
            {
                if (total < .35m)
                {
                    Console.WriteLine("Sorry you did not put enough money in to buy Orange Soda");
                    Console.WriteLine("Your coins are returned");
                    inputtedCoins.Clear();
                    AskToBuyAnother();
                }
                else if (total == .35m)
                {
                    Console.WriteLine("Orange Soda Dispensed!");
                    orangeSodaList.RemoveAt(0);
                    foreach (Coins coins in inputtedCoins)
                    {
                        if (coins.coinValue == .25)
                        {
                            quarterList.Add(new Quarters(.25));
                        }
                        else if (coins.coinValue == .1)
                        {
                            dimeList.Add(new Dimes(.1));
                        }
                        else if (coins.coinValue == .05)
                        {
                            nickelList.Add(new Nickels(.05));
                        }
                        else if (coins.coinValue == .01)
                        {
                            pennyList.Add(new Pennies(.01));
                        }
                    }
                    AskToBuyAnother();
                }
                else if (total > .35m)
                {
                    changeAmount = total - .35m;
                    CheckForAdequateChange();
                    if (enoughChange)
                    {
                        Console.WriteLine("Orange Soda Dispensed!");
                        orangeSodaList.RemoveAt(0);
                        foreach (Coins coins in inputtedCoins)
                        {
                            if (coins.coinValue == .25)
                            {
                                quarterList.Add(new Quarters(.25));
                            }
                            else if (coins.coinValue == .1)
                            {
                                dimeList.Add(new Dimes(.1));
                            }
                            else if (coins.coinValue == .05)
                            {
                                nickelList.Add(new Nickels(.05));
                            }
                            else if (coins.coinValue == .01)
                            {
                                pennyList.Add(new Pennies(.01));
                            }
                        }                        
                        GiveChange();
                        AskToBuyAnother();
                    }
                    else if (!enoughChange)
                    {
                        Console.WriteLine("Sorry, this machine is out of change. Please use exact change");
                        Console.WriteLine("Your coins have been returned");
                        inputtedCoins.Clear();
                        AskToBuyAnother();
                    }
                }
            }
            else
            {
                Console.WriteLine("Sorry this machine is out of Orange Soda");
                Console.WriteLine("Your coins are returned");
                inputtedCoins.Clear();
                AskToBuyAnother();
            }
        }

        public void BuyMeat()
        {
            if (meatSodaList.Count > 0)
            {
                if (total < .06m)
                {
                    Console.WriteLine("Sorry you did not put enough money in to buy Meat Soda");
                    Console.WriteLine("Your coins are returned");
                    inputtedCoins.Clear();
                    AskToBuyAnother();
                }
                else if (total == .06m)
                {
                    Console.WriteLine("Meat Soda Dispensed!");
                    meatSodaList.RemoveAt(0);
                    foreach (Coins coins in inputtedCoins)
                    {
                        if (coins.coinValue == .25)
                        {
                            quarterList.Add(new Quarters(.25));
                        }
                        else if (coins.coinValue == .1)
                        {
                            dimeList.Add(new Dimes(.1));
                        }
                        else if (coins.coinValue == .05)
                        {
                            nickelList.Add(new Nickels(.05));
                        }
                        else if (coins.coinValue == .01)
                        {
                            pennyList.Add(new Pennies(.01));
                        }
                    }
                    AskToBuyAnother();
                }
                else if (total > .06m)
                {
                    changeAmount = total - .06m;
                    CheckForAdequateChange();
                    if (enoughChange)
                    {
                        Console.WriteLine("Meat Soda Dispensed!");
                        meatSodaList.RemoveAt(0);
                        foreach (Coins coins in inputtedCoins)
                        {
                            if (coins.coinValue == .25)
                            {
                                quarterList.Add(new Quarters(.25));
                            }
                            else if (coins.coinValue == .1)
                            {
                                dimeList.Add(new Dimes(.1));
                            }
                            else if (coins.coinValue == .05)
                            {
                                nickelList.Add(new Nickels(.05));
                            }
                            else if (coins.coinValue == .01)
                            {
                                pennyList.Add(new Pennies(.01));
                            }
                        }                        
                        GiveChange();
                        AskToBuyAnother();
                    }
                    else if (!enoughChange)
                    {
                        Console.WriteLine("Sorry, this machine is out of change. Please use exact change");
                        Console.WriteLine("Your coins have been returned");
                        inputtedCoins.Clear();
                        AskToBuyAnother();
                    }
                }
            }
            else
            {
                Console.WriteLine("Sorry this machine is out of Meat Soda");
                Console.WriteLine("Your coins are returned");
                inputtedCoins.Clear();
                AskToBuyAnother();
            }
        }

        public bool CheckForAdequateChange()
        {
            if (changeAmount >50 && quarterList.Count < 2)
            {
                enoughChange = false;
                return enoughChange;
            }
            else if (changeAmount > .25m && quarterList.Count <= 0)
            {
                enoughChange = false;
                return enoughChange;
            }
            else if (changeAmount > .9m && dimeList.Count <= 0)
            {
                enoughChange = false;
                return enoughChange;
            }
            else if (changeAmount > .04m && nickelList.Count <= 0)
            {
                enoughChange = false;
                return enoughChange;
            }
            else if (changeAmount >= .01m && pennyList.Count <= 0)
            {
                enoughChange = false;
                return enoughChange;
            }
            else
            {
                enoughChange = true;
                return enoughChange;
            }
        }

        public void GiveChange()
        {
            while (changeAmount > 0)
            {
                if (changeAmount >= .25m && quarterList.Count > 0)
                {
                    Console.WriteLine("Quarter Dispensed");
                    changeAmount -= .25m;
                    quarterList.RemoveAt(0);
                    GiveChange();
                }
                else if (changeAmount >= .1m && dimeList.Count > 0)
                {
                    Console.Write("Dime Dispensed");
                    changeAmount -= .1m;
                    dimeList.RemoveAt(0);
                    GiveChange();
                }
                else if (changeAmount >= .05m && nickelList.Count > 0)
                {
                    Console.WriteLine("Nickel Dispensed");
                    changeAmount -= .05m;
                    nickelList.RemoveAt(0);
                    GiveChange();
                }
                else if (changeAmount >= .01m && pennyList.Count > 0)
                {
                    Console.WriteLine("Penny Dispensed");
                    changeAmount -= .01m;
                    pennyList.RemoveAt(0);
                    GiveChange();
                }
            }
        }

        public void AddQuartersToList()
        {
            for (int quarterInput = 0; quarterInput < insertedQuarters; quarterInput++)
            {
                inputtedCoins.Add(new Quarters(.25));
            }
        }

        public void AddDimesToList()
        {
            for (int dimeInput = 0; dimeInput < insertedDimes; dimeInput++)
            {
                inputtedCoins.Add(new Dimes(.1));
            }
        }

        public void AddNickelsToList()
        {
            for (int nickelInput = 0; nickelInput < insertedNickels; nickelInput++)
            {
                inputtedCoins.Add(new Nickels(.05));
            }
        }

        public void AddPenniesToList()
        {
            for (int pennyInput = 0; pennyInput < insertedPennies; pennyInput++)
            {
                inputtedCoins.Add(new Pennies(.01));
            }
        }

        public void AddInsertedCoinsToList()
        {
            AddQuartersToList();
            AddDimesToList();
            AddNickelsToList();
            AddPenniesToList();
        }

        public void AddStartingCoins()
        {
            inputtedCoins.Clear();
            AddStartingPennies();
            AddStartingNickels();
            AddStartingDimes();
            AddStartingQuarters();
        }

        public void AddStartingPennies()
        {
            for (int pennyIndex = 0; pennyIndex < startingPennies; pennyIndex++)
            {
                pennyList.Add(new Pennies(.01));
            }
        }

        public void AddStartingNickels()
        {
            for (int nickelIndex = 0; nickelIndex < startingNickels; nickelIndex++)
            {
                nickelList.Add(new Nickels(.05));
            }
        }

        public void AddStartingDimes()
        {
            for (int dimeIndex = 0; dimeIndex < startingDimes; dimeIndex++)
            {
                dimeList.Add(new Dimes(.1));
            }
        }

        public void AddStartingQuarters()
        {
            for (int quarterIndex = 0; quarterIndex < startingQuarters; quarterIndex++)
            {
                quarterList.Add(new Quarters(.25));
            }
        }

        public void AddStartingSodaStock()
        {
            AddStartingGrape();
            AddStartingOrange();
            AddStartingMeat();
        }

        public void AddStartingGrape()
        {
            for (int grapeSodaIndex = 0; grapeSodaIndex < startingGrape; grapeSodaIndex++)
            {
                grapeSodaList.Add(new GrapeSoda());
            }
        }

        public void AddStartingOrange()
        {
            for (int orangeSodaIndex = 0; orangeSodaIndex < startingOrange; orangeSodaIndex++)
            {
                orangeSodaList.Add(new OrangeSoda());
            }
        }

        public void AddStartingMeat()
        {
            for (int meatSodaIndex = 0; meatSodaIndex < startingMeat; meatSodaIndex++)
            {
                meatSodaList.Add(new MeatSoda());
            }
        }
    }
}