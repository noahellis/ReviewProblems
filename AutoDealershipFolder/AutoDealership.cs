using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    public class AutoDealership
    {
        List<Vehicle> vehicleList = new List<Vehicle>();
        Customer customer = new Customer();
        Car newCar = new Car();
        Truck newTruck = new Truck();
        Hybrid newHybrid = new Hybrid();
        SportUtility newSportUtility = new SportUtility();
        Vehicle vehicle;
        public int OrderVehicles()
        {
            Console.WriteLine("Please enter the type of vehicle you would like to purchase:");
            Console.WriteLine("1:SUV\n2:Hybrid\n3:Truck\n4:Car");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    newSportUtility.MakeCustomSportUtility();
                    MakeMultipleVehicle();
                    AskMakeNewVehicle();
                    break;
                case 2:
                    newHybrid.MakeCustomHybrid();
                    MakeMultipleVehicle();
                    AskMakeNewVehicle();
                    break;
                case 3:
                    newTruck.MakeCustomTruck();
                    MakeMultipleVehicle();
                    AskMakeNewVehicle();
                    break;
                case 4:
                    newCar.MakeCustomCar();
                    MakeMultipleVehicle();
                    AskMakeNewVehicle();
                    break;
                default:
                    Console.WriteLine("Invalid input, please try again");
                    return OrderVehicles();                
            }
            return choice;
        }
        public void MakeMultipleVehicle()
        {
            Console.WriteLine("How many of this vehicle would you like to make?");
            int choice = int.Parse(Console.ReadLine());
            for (int addMulitpleIndex = 0; addMulitpleIndex < choice; addMulitpleIndex++)
            {
                vehicleList.Add(newCar);
                TestVehicle();
            }
        }
        public int? AskMakeNewVehicle()
        {
            Console.WriteLine("Would you like to make another vehicle?");
            string choice = Console.ReadLine();
            if (choice.Equals("yes", StringComparison.OrdinalIgnoreCase)) 
            {
               return OrderVehicles();
            }
            else if (choice.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                //main menu
                return null;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again");
                return OrderVehicles();
            }
        }
        public void SellVehicles()
        {

        }

        public bool TestVehicle()
        {
            int testNumber;
            bool passTest;
            Random vehicleTest = new Random();
            Console.WriteLine("We will now test your vehicle. If it doesn't pass minimum testing requirements, it will be removed from your inventory");
            if ((testNumber = vehicleTest.Next(0,100))<=5)
            {
                Console.WriteLine("This vehicle didn't pass minimum testing requirements. It will be removed from your inventory");
                vehicleList.RemoveAt(vehicleList.Count);
                passTest = false;
            }
            else
            {
                passTest = true;
            }
            return passTest;
        }
        public void AdjustVehiclePrice()
        {

        }
        public void HaveSalesEvent()
        {
            //debuff sales event? 
        }


    }
}
