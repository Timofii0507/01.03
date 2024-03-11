using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Cello : MusicalInstrument
    {
        public Cello() : base("Віолончель", "Глибокий звук", "Струнний смичковий інструмент", "Історія віолончелі сягає 16 століття")
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Віолончель співає!");
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
