using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Builder : Human
    {
        public string Specialization { get; set; }
        public int ExperienceYears { get; set; }

        public Builder(string name, int age, string gender, string specialization, int experienceYears) :
            base(name, age, gender)
        {
            Specialization = specialization;
            ExperienceYears = experienceYears;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Спеціалізація: {Specialization}");
            Console.WriteLine($"Досвід роботи: {ExperienceYears} років");
        }
    }

}
