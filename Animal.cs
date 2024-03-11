using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public abstract class Animal
    {
        protected string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public abstract void MakeSound();

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Ім'я: {name}");
        }
    }
}
