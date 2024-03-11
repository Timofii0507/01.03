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
            Figure[] figures = new Figure[]
            {
            new Rectangle(5, 4),
            new Circle(3),
            new RightTriangle(6, 8),
            new Trapezoid(4, 7, 5)
            };

            foreach (var figure in figures)
            {
                Console.WriteLine($"Площа {figure.GetType().Name}: {figure.CalculateArea()}");
            }
        }
    }
}
