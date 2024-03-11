﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Rectangle : Figure
    {
        private double _width;
        private double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public override double CalculateArea()
        {
            return _width * _height;
        }
    }
}
