using System;

namespace Movies.Service
{
    public static class Validator
    {

        public static void AssertStringMaxCharacters(int value, string propertyName)
        {
            if (value > 100)
            {
                throw new ArgumentException(
                    $"{propertyName} не должно быть больше 100");
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
