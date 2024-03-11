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
            Visa visa1 = new Visa("Україна", DateTime.Now.AddDays(30), DateTime.Now.AddYears(1));
            Visa visa2 = new Visa("ЄС", DateTime.Now.AddDays(60), DateTime.Now.AddYears(2));

            ForeignPassport passport = new ForeignPassport("Іван", "Петренко", "Україна", "AB123456", DateTime.Now.AddYears(-5), DateTime.Now.AddYears(5), "FG789012");
            passport.AddVisa(visa1);
            passport.AddVisa(visa2);

            Console.WriteLine(passport.ToString());
        }
    }
}
