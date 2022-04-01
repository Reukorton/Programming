using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _length;
        private double _width;

        public string Color { get; set; }
        
        public Rectangle(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "Длина не может быть меньше нуля");
                }

                _length = value;
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "Ширина не может быть меньше нуля");
                }

                _width = value;
            }
        }
    }
}
