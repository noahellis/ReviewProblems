using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    public class UI
    {
        AutoDealership autoDealerShip = new AutoDealership();
        public int? StartUI()
        {
            
            Console.WriteLine("Welcome to the Car Dealership System. Please enter the following numbers for what you would like to do:");
            Console.WriteLine("Be sure to add vehicles to your inventory before you try to sell them to customers");
            Console.WriteLine("1: Add Vehicles to Dealership Inventory\n2: Check Dealership Inventory\n3: Attempt to sell vehicle to customer\n4: Discount All vehicles for a sales event");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    autoDealerShip.OrderVehicles();
                    return null;
                case 2:
                    autoDealerShip.PrintVehicles();
                    return null;
                case 3:
                    autoDealerShip.SellVehiclesInfo();
                    return null;
                case 4:
                    autoDealerShip.HaveSalesEvent();
                    return null;
                default:
                    return StartUI();
                    
            }
        }
    }
}
