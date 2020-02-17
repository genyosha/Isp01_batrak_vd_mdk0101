using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int WorkExp { get; set; }

        public Employee(string lastName, string lastProfession, int lastWorkExp)
        {
            Name = lastName;
            Profession = lastProfession;
            WorkExp = lastWorkExp;
        }
        public override string ToString()
        {
            return "Name: " + Name + "Profession: " + Profession + "Work Experience " + WorkExp;
        }
    }
}