using System;

namespace Programming.Model
{
    /// <summary>
    /// Методы для проверки входных данных.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверка числа на неотрицательность.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="propertyName">Название метода.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException(
                    $"{propertyName} не должно быть меньше 0, либо число слишком большое");
            }
        }

        /// <summary>
        /// Проверка числа на неотрицательность.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="propertyName">Название метода.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException(
                    $"{propertyName} не должно быть меньше 0");
            }
        }

        /// <summary>
        /// Проверка на то, что число находится в определённом диапазоне.
        /// </summary>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <param name="min">Левая граница диапазона (минимальное значение).</param>
        /// <param name="max">Правая граница диапазона (максимальное значение).</param>
        /// <exception cref="ArgumentException">Выбрасывается, если число находится вне диапазона.</exception>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException(
                    $"{propertyName} должно быть в диапозоне от {min} до {max}");
            }

        }

        /// <summary>
        /// Проверка на то, что число находится в определённом диапазоне.
        /// </summary>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <param name="min">Левая граница диапазона (минимальное значение).</param>
        /// <param name="max">Правая граница диапазона (максимальное значение).</param>
        /// <exception cref="ArgumentException">Выбрасывается, если число находится вне диапазона.</exception>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException(
                    $"{propertyName} должно быть в диапозоне от {min} до {max}");
            }
        }


        /// <summary>
        /// Проверка строки на то, что она состоит только из букв английского алфавита.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если строка состоит не только из букв англиского алфавита.</exception>
        public static void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            foreach (var i in value)
            {
                if (!char.IsLetter(i))
                {
                    throw new ArgumentException(
                        $"{propertyName} должно состоять только из букв английского алфавита");
                }
            }
        }

        /// <summary>
        /// Проверка номера телефона на правильность.
        /// </summary>
        /// <param name="value">Номер телефона.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается если норме телефона состоит не из 11 символов
        /// или он состоит не только из чисел.</exception>
        public static void AssertStringNumberIsCorrect(string value, string propertyName)
        {
            if (propertyName.Length != 11)
            {
                throw new ArgumentException(
                    "Неверная длина номера");
            }
            if (!int.TryParse(propertyName, out int newValue))
            {
                throw new ArgumentException(
                    "Неверные символы номера");
            }
        }
    }
}
