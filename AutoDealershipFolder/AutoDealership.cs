using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    public class AutoDealership
    {
        private List<Customer> customerList = new List<Customer>();
        private List<Vehicle> vehicleList = new List<Vehicle>();
        bool populatedVehicleList;
        double discountPrice;
        double discountRate;
        double dealershipBank;
        Customer customerInfo = new Customer();
        Car newCar = new Car();
        Truck newTruck = new Truck();
        Hybrid newHybrid = new Hybrid();
        SportUtility newSportUtility = new SportUtility();
        Vehicle vehicleInfo;
        
        public AutoDealership()
        {
            MakeGenericCustomerList();
        }
        public List<Vehicle> VehicleList
        {
            get
            {
                return vehicleList;
            }

            set
            {
                vehicleList = value;
            }
        }

        public List<Customer> CustomerList
        {
            get
            {
                return customerList;
            }

            set
            {
                customerList = value;
            }
        }
        public void MakeGenericCustomerList()
        {
            CustomerList.Add(new Customer("BillyBob", "111111"));
            CustomerList.Add(new Customer("Bobby Sue", "111112"));
            CustomerList.Add(new Customer("joe", "111113"));
            CustomerList.Add(new Customer("noah", "111114"));
            CustomerList.Add(new Customer("ben", "111115"));
            CustomerList.Add(new Customer("mike", "112111"));
            CustomerList.Add(new Customer("adam", "119193"));
            CustomerList.Add(new Customer("andrew", "113445"));
            CustomerList.Add(new Customer("dave", "121291"));

        }
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
            Console.WriteLine("We will now test each vehicle. If it doesn't pass minimum testing requirements, you will be informed. If you receive no notification, it passed inspection");
            for (int addMulitpleIndex = 0; addMulitpleIndex < choice; addMulitpleIndex++)
            {
                VehicleList.Add(newCar);
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
                vehicleInfo.ui.StartUI();
                return null;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again");
                return OrderVehicles();
            }
        }
        public void SellVehiclesInfo()
        {
            DetermineListPopulated();
            if (!populatedVehicleList)
            {
                Console.WriteLine("There are no vehicles in your list. Make some vehicles before you try to sell them");
                //restart interface
            }
            else if (populatedVehicleList)
            {
                Console.Clear();
                PrintVehicles();
                PrintCustomers();
                SellVehicle();
            }
        }
        public void PrintVehicles()
        {
            DetermineListPopulated();
            if (populatedVehicleList)
            {
                int carNumber = 1;
                Console.WriteLine("Available Vehicles:");
                foreach (Vehicle vehicle in VehicleList)
                {
                    Console.WriteLine("{0}: Make: {1} Type: {2} Year {3} Color: {4} Price: {5}", carNumber, vehicle.make, VehicleList.GetType(), vehicle.year, vehicle.color, vehicle.Price);
                    carNumber++;
                }
            }
            else if (!populatedVehicleList)
            {
                Console.WriteLine("Sorry, there aren't any vehicles in your list yet. Add some to your inventory!");
                vehicleInfo.ui.StartUI();
            }
         
        }
        public void PrintCustomers()
        {
            int customerNumber = 1;
            Console.WriteLine("Customers looking to buy:");
            foreach (Customer customer in CustomerList)
            {
                Console.WriteLine("{0}: Name: {1} Customer Number: {2}", customerNumber, customer.name, customer.idNumber);
                customerNumber++;
            }
        }
        public void SellVehicle()
        {
            Console.WriteLine("Enter the number to the left of the vehicle that the customer would like to test drive");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number to the left of the person that bought the vehicle");
            int choice1 = int.Parse(Console.ReadLine());
            customerInfo.Price = VehicleList[choice - 1].Price;
            customerInfo.TestDriveVehicle();
            AskToHaggle();
            dealershipBank += VehicleList[choice - 1].Price;
            CustomerList.Add(new Customer(CustomerList[choice1 - 1].name, CustomerList[choice1 - 1].idNumber, VehicleList[choice - 1].make, VehicleList[choice - 1].year, VehicleList[choice - 1].Price, VehicleList[choice - 1].color));
            VehicleList.RemoveAt(choice - 1);
        }
        public void AskToHaggle()
        {
            Console.WriteLine("Is the customer trying to haggle?");
            Console.WriteLine("Enter 1 for yes, 2 for no");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    customerInfo.HaggleOverPrice();
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Incorrect Input, please try again");
                    AskToHaggle();
                    break;
            }
        }

        public bool TestVehicle()
        {
            int testNumber;
            bool passTest;
            Random vehicleTest = new Random();
            
            if ((testNumber = vehicleTest.Next(0,100))<=5)
            {
                Console.WriteLine("This vehicle didn't pass minimum testing requirements. It will be removed from your inventory");
                VehicleList.RemoveAt(VehicleList.Count);
                passTest = false;
            }
            else
            {
                passTest = true;
            }
            return passTest;
        }
        public void AdjustVehiclePriceForEvent()
        {
            foreach (Vehicle vehicle in VehicleList)
            {
                vehicle.Price = (vehicle.Price-(vehicle.Price * discountRate));
            }
        }
        public void RemoveVehiclePriceForEvent()
        {
            foreach(Vehicle vehicle in VehicleList)
            {
                vehicle.Price = (vehicle.Price + (vehicle.Price * discountRate));
            }
        }
        public double DetermineDiscountAmount()
        {
            Console.WriteLine("What percent would you like to discount your fleet?");
            double choice = double.Parse(Console.ReadLine());
            if (choice > 20)
            {
                Console.WriteLine("The home office won't let you discount more than 20%. Try again.");
                return DetermineDiscountAmount();
            }
            if (choice <= 0)
            {
                Console.WriteLine("You can't apply a negative % discount, or a 0% discount. Try again");
                return DetermineDiscountAmount();
            }
            else
            {
                discountRate = (choice / 100);
            }
            return discountRate;
            
        }
        public void HaveSalesEvent()
        {
            DetermineListPopulated();
            if (!populatedVehicleList)
            {
                Console.WriteLine("There are no vehicles in your list. Buy some vehicles before you discount them");
                vehicleInfo.ui.StartUI();
            }
            else if (populatedVehicleList)
            {
                DetermineDiscountAmount();
            }

        }
        public bool DetermineListPopulated()
        {
            
            if (VehicleList.Count <= 0)
            {
                populatedVehicleList = false;
            }
            else
            {
                populatedVehicleList = true;
            }

            return populatedVehicleList;
        }


    }
}
