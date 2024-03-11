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
            Money money = new Money(10, 50);
            money.Print(); 

            Product product = new Product("Товар", 20, 75);
            product.Print(); 

            product.DecreasePrice(10);
            product.Print(); 
        }
    }
}
