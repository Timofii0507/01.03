using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Kettle : Device
    {
        public Kettle(string name) : base(name)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Шум кип'ятіння води...");
        }

        public override void Show()
        {
            Console.WriteLine("Назва: {0}", GetName());
        }

        public override void Desc()
        {
            Console.WriteLine("Опис: Пристрій для кип'ятіння води.");
        }
    }

}
