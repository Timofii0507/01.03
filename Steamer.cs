using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Steamer : Device
    {
        public Steamer(string name) : base(name)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Гудіння пароплава...");
        }

        public override void Show()
        {
            Console.WriteLine("Назва: {0}", GetName());
        }

        public override void Desc()
        {
            Console.WriteLine("Опис: Водний транспорт для перевезення людей і вантажів.");
        }
    }

}
