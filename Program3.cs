using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            Animal tiger = new Tiger("Тигреня");
            tiger.MakeSound();
            tiger.PrintInfo();

            Console.WriteLine();

            Animal crocodile = new Crocodile("Крокозяка");
            crocodile.MakeSound();
            crocodile.PrintInfo();

            Console.WriteLine();

            Animal kangaroo = new Kangaroo("Кенгуруша");
            kangaroo.MakeSound();
            kangaroo.PrintInfo();
        }
    }
}
