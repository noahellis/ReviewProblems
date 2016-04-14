using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    class SportUtility : Vehicle
    {
        string make;
        string year;
        string color;
        double price
        {
            get;
            set;
        }

        public SportUtility(string Make,  string Year, double Price, string Color) : base(Make, Year, Price, Color)
        {
            Make = make;
            Year = year;
            Price = price;
            Color = color;
        }

        public SportUtility()
        {
        }

        public void MakeRandomSportUtility()
        {
        }

        public void MakeCustomSportUtility()
        {
        }

    }
}