using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Kangaroo : Animal
    {
        public Kangaroo(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Квок-квок!");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Вид: Кенгуру");
        }
    }
}
