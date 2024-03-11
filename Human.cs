using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Human(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Ім'я: {Name}");
            Console.WriteLine($"Вік: {Age}");
            Console.WriteLine($"Стать: {Gender}");
        }
    }
}
