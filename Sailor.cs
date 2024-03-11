using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Sailor : Human
    {
        public string Rank { get; set; }
        public string ShipName { get; set; }

        public Sailor(string name, int age, string gender, string rank, string shipName) :
            base(name, age, gender)
        {
            Rank = rank;
            ShipName = shipName;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Звання: {Rank}");
            Console.WriteLine($"Назва корабля: {ShipName}");
        }
    }

}
