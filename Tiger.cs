using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Tiger : Animal
    {
        public Tiger(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Р-р-р!");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Вид: Тигр");
        }
    }

}
