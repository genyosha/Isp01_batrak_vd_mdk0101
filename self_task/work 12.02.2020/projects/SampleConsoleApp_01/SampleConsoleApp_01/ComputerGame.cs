using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ComputerGame
    {
        public string Name { get; set; }
        public string CompanyDeveloper { get; set; }
        public int YearEdition { get; set; }
        public string Genre { get; set; }
        public ComputerGame(string name, string companyDeveloper, int yearEdition, string genre)
        {
            Name = name;
            CompanyDeveloper = companyDeveloper;
            YearEdition = yearEdition;
            Genre = genre;
        }
        public override string ToString()
        {
            return "Name: " + Name + "Company developer: " + CompanyDeveloper + "Year edition: "
                + YearEdition + "Genre: " + Genre;
        }
    }
}

