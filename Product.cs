using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Product : Money
    {
        private string _name;

        public Product(string name, int whole, int cents) : base(whole, cents)
        {
            _name = name;
        }

        public void DecreasePrice(int discount)
        {
            int newWhole = _whole - discount / 100;
            int newCents = _cents - discount % 100;

            if (newCents < 0)
            {
                newCents += 100;
                newWhole--;
            }

            SetWhole(newWhole);
            SetCents(newCents);
        }

        public void Print()
        {
            Console.WriteLine($"{_name}: ");
            base.Print();
        }
    }

}
