using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{

    public abstract class Vehicle
    {
        public UI ui = new UI();
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
                
        public Vehicle(string Make, string Year, double Price, string Color)
        {
            make = Make;
            year = Year;
            price = Price;
            color = Color;
        }
        public Vehicle()
        {

        }
        public string ChooseColor()
        {
            Console.WriteLine("Enter the number for the color you would like:");
            Console.WriteLine("1:Red\n2:Blue\n3:Green\n4:White\n5:Black\n6:Pink");            
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    color = "red";
                    break;
                case 2:
                    color = "blue";
                    break;
                case 3:
                    color = "green";
                    break;
                case 4:
                    color = "White";
                    break;
                case 5:
                    color = "Black";
                    break;
                case 6:
                    color = "Pink";
                    break;
                default:
                    Console.WriteLine("Incorrect input, please try again");
                    return ChooseColor();
            }
            return color;
        }
        public string ChooseMake()
        {
            Console.WriteLine("Please enter the Make of vehicle you would like");
            Console.WriteLine("1:Toyota\n2:Mazda\n3:Subaru\n4:Ford");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    make = "Toyota";
                    break;
                case 2:
                    make = "Mazda";
                    break;
                case 3:
                    make = "Subaru";
                    break;
                case 4:
                    make = "Ford";
                    break;
                default:
                    Console.WriteLine("Incorrect input, please try again");
                    return ChooseMake();
            }

            return make;
        }
        public string ChooseYear()
        {
            Console.WriteLine("Please choose from the available model years:");
            Console.WriteLine("1:2017\n2:2016\n3:2015\n4:2014\n5:2013");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    year = "2017";
                    break;
                case 2:
                    year = "2016";
                    break;
                case 3:
                    year = "2015";
                    break;
                case 4:
                    year = "2014";
                    break;
                case 5:
                    year = "2013";
                    break;
                default:
                    Console.WriteLine("Incorrect input, please try again");
                    return ChooseYear();
            }
            return year;
        }
        public double SetSellingPrice()
        {
            Console.WriteLine("Please enter the selling price for this vehicle");
            price = double.Parse(Console.ReadLine());
            return price;
            //add confirmation and try catch
        }
    }
}
