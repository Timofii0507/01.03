using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Pilot : Human
    {
        public string LicenseType { get; set; }
        public int FlightHours { get; set; }

        public Pilot(string name, int age, string gender, string licenseType, int flightHours) :
            base(name, age, gender)
        {
            LicenseType = licenseType;
            FlightHours = flightHours;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Тип ліцензії: {LicenseType}");
            Console.WriteLine($"Наліт годин: {FlightHours}");
        }
    }
}
