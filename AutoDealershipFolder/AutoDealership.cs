using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    class AutoDealership
    {
        List<Vehicle> vehicleList = new List<Vehicle>();
        Customer customer = new Customer();
        Vehicle vehicle;
        public void OrderVehicles()
        {
            Console.WriteLine("Please enter the type of vehicle you would like to purchase:");
            Console.WriteLine("1:SUV\n2:Hybrid\n3:Truck\n4:Car");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    //make SUV
                    break;
                case 2:
                    //make hybrid
                    break;
                case 3:
                    //make truck
                    break;
                case 4:
                    //make car
                    break;
                default:
                    OrderVehicles();
                    break;
            }
        }
        public void SellVehicles()
        {

        }

        public void TestVehicle()
        {

        }
        public void AdjustVehiclePrice()
        {

        }
        public void HaveSalesEvent()
        {

        }
        public void GenerateRandomVehicles()
        {
            Random vehicleGenerator = new Random();
            int generatedVehicleNumber = int.Parse(Console.ReadLine());
            for (int generatedIndex = 0; generatedIndex < generatedVehicleNumber; generatedIndex++)
            {
                if (vehicleGenerator.Next(0, 5) == 1)
                {
                    
                }
            }
        }

    }
}
