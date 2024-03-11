using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Crocodile : Animal
    {
        public Crocodile(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Гр-р-р!");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Вид: Крокодил");
        }
    }
}
