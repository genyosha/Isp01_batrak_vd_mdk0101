using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batrak_20._02
{
    class Teacher : Person
    {
        private List<string> disciplines;

        public List<string> Disciplines
        {
            get
            {
                return disciplines;
            }
            set
            {
                disciplines = value;
            }
        }

        public Teacher(int age, string name, List<string> disciplines) : base(age, name)
        {
            this.disciplines = disciplines;
        }

        public void AddDiscipline(string discipline)
        {
            disciplines.Add(discipline);
        }

        public void RemoveDiscipline(string discipline)
        {
            //if (Disciplines.Contains(discipline))
                disciplines.Remove(discipline);
        }

        public override void Print()
        {
                Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            string resDiscipline = "Предметы: ";
            foreach (string item in disciplines)
            {
                resDiscipline += item + " ";
            }
            return resDiscipline;
        }
            
    }
}
