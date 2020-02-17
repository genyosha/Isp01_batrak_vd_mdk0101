using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class StudyGroup
    {
        public string Cipher { get; set; }
        public int AmountStudents { get; set; }
        public int YearFormation { get; set; }
        public string Specialty { get; set; }
        public StudyGroup(string cipher, int amountStudents, int yearInformation, string specialty)
        {
            Cipher = cipher;
            AmountStudents = amountStudents;
            YearFormation = yearInformation;
            Specialty = specialty;
        }
        public override string ToString()
        {
            return "Cipher: " + Cipher + "Amount students " + AmountStudents + "Year information: "
                + YearFormation + "Specialty: " + Specialty;
        }
    }
}