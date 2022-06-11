using System.Drawing;

namespace Programming.Model.Classes
{
    public static class AllColors
    {
        /// <summary>
        /// Цвет коректного значения.
        /// </summary>
        public static Color CorrectColor = Color.White;
        
        /// <summary>
        /// Цвет некоректного значения.
        /// </summary>
        public static Color ErrorColor = Color.LightPink;


        /// <summary>
        /// Цвет пересечения фигур.
        /// </summary>
        public static Color InContact = Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Цвет не пересекаемых фигур.
        /// </summary>
        public static Color UnContact = Color.FromArgb(127, 127, 255, 127);
    }
}
