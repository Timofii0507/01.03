using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class RightTriangle : Figure
    {
        private double _base;
        private double _height;

        public RightTriangle(double @base, double height)
        {
            _base = @base;
            _height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * _base * _height;
        }
    }

}
