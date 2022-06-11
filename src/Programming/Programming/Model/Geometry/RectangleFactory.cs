using Programming.Model.Enums;
using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Методы для создания прямоугольников.
    /// </summary>
    public static class RectangleFactory
    {
        /// <summary>
        /// Отступ от границы панеле.
        /// </summary>
        private const int Margin = 15;

        /// <summary>
        /// Генерация случайных значений.
        /// </summary>
        private static Random _random;

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="RectangleFactory"/>.
        /// </summary>
        static RectangleFactory()
        {
            _random = new Random();
        }

        /// <summary>
        /// Создает прямоугольник со случайными значениями, который принимает класс <see cref="Rectangle"/>.
        /// </summary>
        /// <returns>Объект Rectangle</returns>
        public static Rectangle Randomize()
        {
            var colors = Enum.GetValues(typeof(Colors));
            Rectangle rectangle = new Rectangle();

            rectangle.Width = _random.Next(30, 101);
            rectangle.Height = _random.Next(30, 101);
            rectangle.Center = new Point2D(_random.Next(1, 300), _random.Next(1, 300));
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();

            return rectangle;
        }

        /// <summary>
        /// Создает прямоугольник со случайными значениями относительно панели.>.
        /// </summary>
        /// <returns>Объект Rectangle</returns>
        public static Rectangle Randomize(int widthCanvas, int heightCanvas)
        {
            var colors = Enum.GetValues(typeof(Colors));
            Rectangle rectangle = new Rectangle();
            rectangle.Width = _random.Next(30, 101);
            rectangle.Height = _random.Next(30, 101);
            rectangle.Center = new Point2D(_random.Next(Margin, widthCanvas - rectangle.Width - Margin),
                                           _random.Next(Margin, heightCanvas - rectangle.Height - Margin));
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            return rectangle;
        }
    }
}
