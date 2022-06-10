﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if ((value < 0) && (value > 700))
            {
                throw new ArgumentException(
                    $"{propertyName} не должно быть меньше 0, либо число слишком большое");
            }
        }

        public static void AssertOnPositiveValue(int value)
        {
            if ((value < 0) || (value > 700))
            {
                throw new Exception(
                   $"не должно быть меньше 0, либо число слишком большое");
            }
        }

        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException(
                    $"{propertyName} не должно быть меньше 0");
            }
        }

        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException(
                    $"{propertyName} должно быть в диапозоне от {min} до {max}");
            }

        }
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException(
                    $"{propertyName} должно быть в диапозоне от {min} до {max}");
            }
        }
    }
}
