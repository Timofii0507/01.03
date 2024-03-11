using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Посада: Інженер");
            Console.WriteLine("Відповідальність: Розробка та впровадження нових технологій");
        }
    }
}
