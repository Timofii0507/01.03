using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Trapezoid : Figure
    {
        private double _base1;
        private double _base2;
        private double _height;

        public Trapezoid(double base1, double base2, double height)
        {
            _base1 = base1;
            _base2 = base2;
            _height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * (_base1 + _base2) * _height;
        }
    }
}
