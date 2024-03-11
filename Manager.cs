using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Посада: Менеджер");
            Console.WriteLine("Відповідальність: Управління командою, контроль за виконанням завдань");
        }
    }
}
