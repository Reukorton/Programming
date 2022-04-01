﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Flight
    {
        private string _flightTimeMinutes;

        public string Departure { get; set; }

        public string Destination { get; set; }

        public string FlightTimeInMinutes
        {
            get
            {
                return _flightTimeMinutes;
            }
            set
            {
                if (!int.TryParse(value, out int result))
                {
                    throw new ArgumentException(
                        "Неверные символы во времени полета");
                }

                _flightTimeMinutes = value;
            }
        } 
    }
}
