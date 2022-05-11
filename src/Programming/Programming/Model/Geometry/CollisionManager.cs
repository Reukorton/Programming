using System;
using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    public class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            int dX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            int dY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            int dWidth = Math.Abs(rectangle1.Width - rectangle2.Width);
            int dLength = Math.Abs(rectangle1.Length - rectangle2.Length);

            return (dX < dWidth / 2) && (dY < dLength / 2);
        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            int dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            int dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double c = Math.Sqrt(dX * dX + dY * dY);

            return c < (ring1.OuterRadius + ring2.OuterRadius);
        }
    }
}
