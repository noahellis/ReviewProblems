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
                    Console.WriteLine("How many of this vehicle would you like to make?");
                    choice = int.Parse(Console.ReadLine());
                    for(int addMulitpleIndex = 0; addMulitpleIndex < choice; addMulitpleIndex++)
                    {
                        vehicleList.Add(newSportUtility);
                    }
                    AskMakeNewVehicle();
                    break;
                case 2:
                    newHybrid.MakeCustomHybrid();
                    Console.WriteLine("How many of this vehicle would you like to make?");
                    choice = int.Parse(Console.ReadLine());
                    for (int addMulitpleIndex = 0; addMulitpleIndex < choice; addMulitpleIndex++)
                    {
                        vehicleList.Add(newHybrid);
                    }                    
                    AskMakeNewVehicle();
                    break;
                case 3:
                    newTruck.MakeCustomTruck();
                    Console.WriteLine("How many of this vehicle would you like to make?");
                    choice = int.Parse(Console.ReadLine());
                    for (int addMulitpleIndex = 0; addMulitpleIndex < choice; addMulitpleIndex++)
                    {
                        vehicleList.Add(newTruck);
                    }
                    AskMakeNewVehicle();
                    break;
                case 4:
                    newCar.MakeCustomCar();
                    Console.WriteLine("How many of this vehicle would you like to make?");
                    choice = int.Parse(Console.ReadLine());
                    for (int addMulitpleIndex = 0; addMulitpleIndex < choice; addMulitpleIndex++)
                    {
                        vehicleList.Add(newCar);
                    }
                    AskMakeNewVehicle();
                    break;
                default:
                    Console.WriteLine("Invalid input, please try again");
                    return OrderVehicles();                
            }
            return choice;
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

        public void TestVehicle()
        {

        }
        public void AdjustVehiclePrice()
        {

        }
        public void HaveSalesEvent()
        {
            //debuff sales event?
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
