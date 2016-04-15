using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    public class Customer
    {
        string name;
        string idNumber;
        double discountAmount;
        Vehicle possibleVehicle;
        public Customer (string Name, string IDNumber)
        {
            Name = name;
            IDNumber = idNumber;
        }
        public Customer()
        {

        }
        public void TestDriveVehicle()
        {
            //random number generator
            //if vehicle passed dealership test, 10% chance of something going wrong
            //if vehicle didn't pass test, 60% chance of something going wrong
        }
        public void HaggleOverPrice()
        {          
              
            Random haggleRandom = new Random();
            if (discountAmount <= (possibleVehicle.Price * .1))
            {
                if (haggleRandom.Next(0, 11) < 8)
                {
                    possibleVehicle.Price -= discountAmount;

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
                    possibleVehicle.Price -= discountAmount;
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
                    possibleVehicle.Price -= discountAmount;
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
                    possibleVehicle.Price -= discountAmount;
                }
                else
                {
                    Console.WriteLine("Sorry they didn't go for your haggling.");
                }
            }       
            
        }
    }
}
