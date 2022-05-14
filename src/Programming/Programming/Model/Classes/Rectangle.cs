﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Geometry;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private static int _allRectanglesCount;

        private readonly int _id;

        private int _height;

        private int _width;

        public string Color { get; set; }

        public Point2D Center { get; set; }

        public Rectangle() 
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public Rectangle(int height, int width, string color, Point2D center)
        {
            Height = height;
            Width = width;
            Color = color;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
            Center = center;
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Height));
                _height = value;
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
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        public int Id
        {
            get { return _id; }
        }

        public override string ToString()
        {
            return $"Rectangle {_id}";
        }

        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
        }
    }
}
