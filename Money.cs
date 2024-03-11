using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Money
    {
        public int _whole;
        public int _cents; 

        public Money(int whole, int cents)
        {
            _whole = whole;
            _cents = cents;
        }

        public void Print()
        {
            Console.WriteLine($"{_whole} {_cents}");
        }

        public void SetWhole(int whole)
        {
            _whole = whole;
        }

        public void SetCents(int cents)
        {
            _cents = cents;
        }
    }

}
