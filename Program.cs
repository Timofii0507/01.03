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
            Console.WriteLine("Введіть ім'я:");
            string name = Console.ReadLine();

            Console.WriteLine("Введіть вік:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть стать:");
            string gender = Console.ReadLine();


            Console.WriteLine("Оберіть професію:");
            Console.WriteLine("1. Будівельник");
            Console.WriteLine("2. Моряк");
            Console.WriteLine("3. Пілот");

            int choice = int.Parse(Console.ReadLine());

            Human human;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введіть спеціалізацію:");
                    string specialization = Console.ReadLine();

                    Console.WriteLine("Введіть досвід роботи (років):");
                    int experienceYears = int.Parse(Console.ReadLine());

                    human = new Builder(name, age, gender, specialization, experienceYears);
                    break;

                case 2:
                    Console.WriteLine("Введіть звання:");
                    string rank = Console.ReadLine();

                    Console.WriteLine("Введіть назву корабля:");
                    string shipName = Console.ReadLine();

                    human = new Sailor(name, age, gender, rank, shipName);
                    break;

                case 3:
                    Console.WriteLine("Введіть тип ліцензії:");
                    string licenseType = Console.ReadLine();

                    Console.WriteLine("Введіть наліт годин:");
                    int flightHours = int.Parse(Console.ReadLine());

                    human = new Pilot(name, age, gender, licenseType, flightHours);
                    break;

                default:
                    Console.WriteLine("Невідома професія!");
                    return;
            }

            human.PrintInfo();
        }
    }

}
