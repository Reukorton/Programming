using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryOfInstitutions.Service
{
    public static class Validator
    {

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

        public static void AssertStringMaxiCharacters(string value, int max, string propertyName)
        {
            if (value.Length > max)
            {
                throw new ArgumentException(
                    $"{propertyName} должно быть не больше {max}");
            }
        }
    }
}
