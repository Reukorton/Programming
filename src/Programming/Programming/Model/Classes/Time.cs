﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;
        
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException(
                        "Неверное значение времени в часах");
                }

                _hours = value;
            }
        }

        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException(
                        "Неверное значение времени в минутах");
                }

                _minutes = value;
            }
        }

        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException(
                        "Неверное значение времени в секундах");
                }

                _seconds = value;
            }
        }
    }
}
