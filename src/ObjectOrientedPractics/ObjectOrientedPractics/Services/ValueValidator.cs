using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс валидации значений
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверка, что строка не длинее maxLength
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="maxLength">Максимальная длина</param>
        /// <param name="propertyName">Название метода из которого вызывается</param>
        /// <exception cref="ArgumentException">Ошибка превышения длины строки</exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException(
                    $"Строка превышает максимальную длину({maxLength}) в поле {propertyName}");
            }
        }

        /// <summary>
        /// Проверка, что число входит в диапозон от min до max
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="min">Минимальное значение</param>
        /// <param name="max">Максимальное значение</param>
        /// <param name="propertyName">Название метода из которого вызывается</param>
        /// <exception cref="ArgumentException">Ошибка выхода из диапозона</exception>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min | value > max)
            {
                throw new ArgumentException($"Выход за диапозон цена в поле {propertyName}");
            }
        }

        /// <summary>
        /// Проверка, что поле не пустое
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="propertyName">Название метода из которого вызывается</param>
        /// <exception cref="ArgumentException">Ошибка пустого поля</exception>
        public static void AssertEmptyValue(string value, string propertyName)
        {
            if (value == "")
            {
                throw new ArgumentException($"Пустая строка в {propertyName}");
            }
        }
    }
}
