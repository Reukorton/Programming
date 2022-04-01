using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Flight
    {
        private int _flightTimeMinutes;

        public string Departure { get; set; }

        public string Destination { get; set; }

        public Flight(int flightTime, string departure, string destination)
        {
            FlightTimeInMinutes = flightTime;
            Departure = departure;
            Destination = destination;
        }

        public int FlightTimeInMinutes
        {
            get
            {
                return _flightTimeMinutes;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "Неверная длительность полета");
                }

                _flightTimeMinutes = value;
            }
        } 
    }
}
