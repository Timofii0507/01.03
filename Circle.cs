using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Circle : Figure
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
