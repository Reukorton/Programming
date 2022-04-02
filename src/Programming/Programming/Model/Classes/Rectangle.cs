using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private static int _count = 0;
        private double _length;
        private double _width;
        private int _id;

        public string Color { get; set; }

        public Rectangle() { } 
        public Rectangle(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
            _count++;
            Id = _count;
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

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public override string ToString()
        {
            return $"Rectangle {_id}";
        }
    }
}
