using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    public class SportUtility : Vehicle
    {


        public SportUtility(string Make,  string Year, double Price, string Color) : base(Make, Year, Price, Color)
        {
        }

        public SportUtility()
        {

        }

        public void MakeCustomSportUtility()
        {
            make = ChooseMake();
            year = ChooseYear();
            color = ChooseColor();
            Price = SetSellingPrice();
        }

    }
}