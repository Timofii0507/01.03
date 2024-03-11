using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Microwave : Device
    {
        public Microwave(string name) : base(name)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Дзижчання мікрохвильовки...");
        }

        public override void Show()
        {
            Console.WriteLine("Назва: {0}", GetName());
        }

        public override void Desc()
        {
            Console.WriteLine("Опис: Пристрій для розігріву їжі.");
        }
    }
}
