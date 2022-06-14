using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryOfInstitutions.Service
{
    public static class Validator
    {

        public static void AssertStringMaxСharacters(string value, int count, string propertyName)
        {
            if (value.Length > count)
            {
                throw new ArgumentException(
                    $"Значение \"{propertyName}\" не может иметь длину больше {count} знаков.");
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
