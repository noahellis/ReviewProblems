using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    public class Truck : Vehicle
    {

        public Truck(string Make, string Year, double Price, string Color) : base(Make, Year, Price, Color)
        {

        }
        public Truck()
        {

        }

        public void MakeCustomTruck()
        {
            make = ChooseMake();
            year = ChooseYear();
            color = ChooseColor();
            Price = SetSellingPrice();
        }

    }
}
