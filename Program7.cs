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
            MusicalInstrument[] instruments = new MusicalInstrument[]
            {
            new Violin(),
            new Trombone(),
            new Ukulele(),
            new Cello()
            };

            foreach (var instrument in instruments)
            {
                instrument.Show();
                instrument.Sound();
                instrument.Desc();
                instrument.History();
                Console.WriteLine();
            }
        }
    }
}
