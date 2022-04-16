﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private static int _count = 0;

        private int _length;

        private int _width;

        private int _id;

        public string Color { get; set; }

        public Rectangle() {
            _count++;
            Id = _count;
        } 

        public Rectangle(int length, int width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
            _count++;
            Id = _count;
        }

        public int Length
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

        public int Width
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
