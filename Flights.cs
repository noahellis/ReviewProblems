using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    class Flights
    {
        public string destinationCity;
        public string airline;
        public string flightNumber;
        public string departureTime;
        public string gateNumber;
        public Flights(string destinationCity, string airline, string flightNumber, string departureTime, string gateNumber)
        {
            this.destinationCity = destinationCity;
            this.airline = airline;
            this.flightNumber = flightNumber;
            this.departureTime = departureTime;
            this.gateNumber = gateNumber;
        }
        public Flights()
        {

        }
    }
}
