using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Program
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            Worker[] workers = new Worker[] {
            new President(),
            new Security(),
            new Manager(),
            new Engineer()
        };

            foreach (Worker worker in workers)
            {
                worker.Print();
                Console.WriteLine();
            }
        }
    }
}
