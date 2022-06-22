﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryOfInstitutions.Service
{
    /// <summary>
    /// Статический класс с набором методов для проверки значений.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверка на количество символов в строке.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="count">Максимальное количество символов.</param>
        /// <param name="propertyName"></param>
        /// <exception cref="ArgumentException">Выбрасывается, если value.Length больше count.</exception>
        public static void AssertStringMaxСharacters(string value, int count, string propertyName)
        {
            if (value.Length > count)
            {
                throw new ArgumentException(
                    $"Значение \"{propertyName}\" не может иметь длину больше {count} знаков.");
            }
        }

        /// <summary>
        /// Проверка значения на вхождения в диапозон.
        /// </summary>
        /// <param name="value">Число.</param>
        /// <param name="min">Нижняя граница.</param>
        /// <param name="max">Верхняя матрица.</param>
        /// <param name="propertyName"></param>
        /// <exception cref="ArgumentException">Выбрасывается, если value не входит в диапозон.</exception>
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