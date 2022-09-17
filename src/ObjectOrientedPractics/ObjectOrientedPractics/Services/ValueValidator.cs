using System;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Статистический класс с методами для проверки входных параметров.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверка на длину стоки.
        /// </summary>
        /// <param name="value">Входная строка.</param>
        /// <param name="maxLength">Максимально допустимая длина строки.</param>
        /// <param name="propertyName">Название метода.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException(
                    $"{propertyName} не должно быть больше {maxLength} символов.");
            }
        }

        /// <summary>
        /// Проверка числа на вхождение в диапозон.
        /// </summary>
        /// <param name="value">Число.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        /// <param name="propertyName">Название метода.</param>
        /// <exception cref="ArgumentException"></exception>
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
