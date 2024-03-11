using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Ukulele : MusicalInstrument
    {
        public Ukulele() : base("Укулеле", "Щипковий звук", "Струнний щипковий інструмент", "Історія укулеле сягає 19 століття")
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Укулеле бренькає!");
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
