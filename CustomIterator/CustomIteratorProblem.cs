using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    class CustomIteratorProblem : IEnumerable
    {
        List<Flights> flightList;
        Flights getFlights; 
        string flightDestination = "Los Angeles";
        public CustomIteratorProblem()
        {
            flightList = new List<Flights>();
            getFlights = new Flights();
            MakeFlightList();
        }


        public List<Flights> FlightList
        {
            get
            {
                return flightList;
            }

            set
            {
                flightList = value;
            }
        }

        public void MakeFlightList()
        {
            Flights newYorkLGA = new Flights("New York-LGA", "Southwest", "1275", "11:20", "C21");
            Flights denver = new Flights("Denver", "Southwest", "1787", "11:20", "C22");
            Flights chiOhare = new Flights("Chicago-Ohare", "United", "5121", "11:23", "E61");
            Flights stLouis = new Flights("St. Louis", "Southwest", "512", "11:40", "C23");
            Flights philly = new Flights("Philadelphia", "American", "4077", "11:45", "D52");
            Flights minneapolis = new Flights("Minneapolis", "Delta", "4542", "11:48", "D46");
            Flights atlanta = new Flights("Atlanta", "Southwest", "449", "11:50", "C19");
            Flights washDCA = new Flights("Washington DC", "Southwest", "3456", "12:35", "C22");
            Flights detroit = new Flights("Detroit", "Delta", "671", "12:38", "D45");
            Flights unitedDenver = new Flights("Denver", "United", "5165", "12:44", "E61");
            Flights deltaAtlanta = new Flights("Atlanta", "Delta", "2117", "13:00", "D48");
            Flights afternoonPhilly = new Flights("Philadelphia", "American", "3796", "13:20", "D52");
            Flights boston = new Flights("Boston", "Southwest", "1292", "13:30", "C21");
            Flights orlando = new Flights("Orlando", "Southwest", "102", "13:45", "C19");
            Flights dallas = new Flights("Dallas", "American", "1534", "13:50", "D54");
            Flights phoenix = new Flights("Phoenix", "Southwest", "2078", "14:10", "C22");
            Flights ftmeyers = new Flights("Ft. Meyers", "Southwest", "1783", "15:00", "C21");
            Flights losAngeles = new Flights("Los Angeles", "Southwest", "3259", "15:10", "C23");
            Flights sanFran = new Flights("San Francisco", "Southwest", "679", "15:50", "C22");
            Flights seattle = new Flights("Seattle", "Alaska", "3423", "16:00", "D51");
            Flights houston = new Flights("Houston", "United", "4052", "16:27", "E62");
            Flights kansasCity = new Flights("Kansas City", "Southwest", "3537", "17:10", "C22");
            flightList.Add(newYorkLGA);
            flightList.Add(denver);
            flightList.Add(chiOhare);
            flightList.Add(stLouis);
            flightList.Add(philly);
            flightList.Add(minneapolis);
            flightList.Add(atlanta);
            flightList.Add(washDCA);
            flightList.Add(detroit);
            flightList.Add(unitedDenver);
            flightList.Add(deltaAtlanta);
            flightList.Add(afternoonPhilly);
            flightList.Add(boston);
            flightList.Add(orlando);
            flightList.Add(dallas);
            flightList.Add(phoenix);
            flightList.Add(ftmeyers);
            flightList.Add(losAngeles);
            flightList.Add(sanFran);
            flightList.Add(seattle);
            flightList.Add(houston);
            flightList.Add(kansasCity);
            
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Flights flights in FlightList)
            {
                
                if (flights.destinationCity.Equals(flightDestination))
                {                     
                    yield return "Your next flight to ";
                    yield return flights.destinationCity;
                    yield return " departs at ";
                    yield return flights.departureTime;
                    yield return ". The flight number is ";
                    yield return flights.flightNumber;
                    yield return " and it departs from gate ";
                    yield return flights.gateNumber;
                    yield return ".";
                }                
            }
            
        }
    }

}
