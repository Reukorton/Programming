using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Статистическая обработка двух фигур.
    /// </summary>
    public class CollisionManager
    {
        /// <summary>
        /// Проверка пересечения двух прямоугольников.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник.</param>
        /// <param name="rectangle2">Второй прямоугольник.</param>
        /// <returns></returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            int dX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            int dY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            return rectangle1.Center.X < rectangle2.Center.X + rectangle2.Width &&
                   rectangle1.Center.X + rectangle1.Width > rectangle2.Center.X &&
                   rectangle1.Center.Y < rectangle2.Center.Y + rectangle2.Height &&
                   rectangle1.Height + rectangle1.Center.Y > rectangle2.Center.Y;
        }

        /// <summary>
        /// Проверка ресечения двух колец.
        /// </summary>
        /// <param name="ring1">Первое кольцо.</param>
        /// <param name="ring2">Второе кольцо.</param>
        /// <returns></returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            int dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            int dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double c = Math.Sqrt(dX * dX + dY * dY);

            return c < (ring1.OuterRadius + ring2.OuterRadius);
        }
    }
}
