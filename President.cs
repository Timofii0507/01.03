using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Посада: Президент");
            Console.WriteLine("Відповідальність: Керівництво компанією, прийняття стратегічних рішень");
        }
    }
}
