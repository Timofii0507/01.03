using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Trombone : MusicalInstrument
    {
        public Trombone() : base("Тромбон", "Духовий звук", "Духовий мідний інструмент", "Історія тромбона сягає 15 століття")
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Тромбон гуде!");
        }

        public override void Show()
        {
            Console.WriteLine("Назва інструменту: " + _name);
        }

        public override void Desc()
        {
            Console.WriteLine(_description);
        }

        public override void History()
        {
            Console.WriteLine(_history);
        }
    }

}
