using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    public class Car : Vehicle
    {        
        public Car(string Make, string Year, double Price, string Color) : base(Make, Year, Price, Color)
        {

        }
        public Car()
        {

        }
        public void MakeRandomCar()
        {

        }
        public void MakeCustomCar()
        {

            make = ChooseMake();
            year = ChooseYear();
            color = ChooseColor();
            Price = SetSellingPrice();            
        }
    }
}
