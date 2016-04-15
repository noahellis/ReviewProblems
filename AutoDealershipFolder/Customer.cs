using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    public class Customer
    {
        public string name;
        public string idNumber;
        public bool buyVehicle;
        double discountAmount;
        public string make;
        public string year;
        public string color;
        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        Vehicle possibleVehicle;
        public Customer (string Name, string IDNumber)
        {
            name = Name;
            idNumber = IDNumber;
        }
        public Customer(string Name, string IDNumber, string Make, string Year, double Price, string Color)
        {
            name = Name;
            idNumber = IDNumber;
            make = Make;
            year = Year;
            price = Price;
            color = Color;
        }
        public Customer()
        {

        }
        public bool TestDriveVehicle()
        {
            Random testDriveRandom = new Random();
            
            if (testDriveRandom.Next(0, 10) < 9)
            {
                buyVehicle = true;
                Console.WriteLine("Customer liked the vehicle, and will buy it");
            }
            else if (testDriveRandom.Next(0, 10) > 8)
            {
                buyVehicle = false;
                Console.WriteLine("Customer did not like the vehicle, and will not buy it");
                //return to menu
            }
            return buyVehicle;
            
        }
        public void HaggleOverPrice()
        {
            Console.WriteLine("How much (in $) would the customer like to try to get off the price of the vehicle?");  
            Random haggleRandom = new Random();
            if (discountAmount <= (possibleVehicle.Price * .1))
            {
                if (haggleRandom.Next(0, 11) < 8)
                {
                    price = possibleVehicle.Price;
                    possibleVehicle.Price -= discountAmount;
                    Console.WriteLine("New Price: {0:C2}", possibleVehicle.Price);

                }
                else
                {
                    Console.WriteLine("Sorry they didn't go for your haggling.");

                }
            }
            else if (discountAmount <= (possibleVehicle.Price * .2))
            {
                if (haggleRandom.Next(0, 11) < 6)
                {
                    price = possibleVehicle.Price;
                    possibleVehicle.Price -= discountAmount;
                    Console.WriteLine("New Price: {0:C2}", possibleVehicle.Price);
                }
                else
                {
                    Console.WriteLine("Sorry they didn't go for your haggling.");
                }
            }
            if (discountAmount <= (possibleVehicle.Price * .4))
            {
                if(haggleRandom.Next(0,11) < 4)
                {
                    price = possibleVehicle.Price;
                    possibleVehicle.Price -= discountAmount;
                    Console.WriteLine("New Price: {0:C2}", possibleVehicle.Price);
                }
                else
                {
                    Console.WriteLine("Sorry they didn't go for your haggling.");
                }
            }
            if (discountAmount <= (possibleVehicle.Price * .41))
            {
                if (haggleRandom.Next(0, 11) < 1)
                {
                    price = possibleVehicle.Price;
                    possibleVehicle.Price -= discountAmount;
                    Console.WriteLine("New Price: {0:C2}", possibleVehicle.Price);
                }
                else
                {
                    Console.WriteLine("Sorry they didn't go for your haggling.");
                }
            }       
            
        }
    }
}
