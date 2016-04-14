using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    public class Hybrid : Vehicle
    {

        public Hybrid(string Make, string Year, double Price, string Color) : base(Make, Year, Price, Color)
        {

        }
        public Hybrid()
        {

        }
        public void MakeRandomHybrid()
        {

        }
        public void MakeCustomHybrid()
        {

            make = ChooseMake();
            year = ChooseYear();
            color = ChooseColor();
            Price = SetSellingPrice();

        }
    }
}
