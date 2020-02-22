using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batrak_20._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person01 = new Person[4] { new Student(16, "Vanya", 1, "Isp"),
            new Teacher(54, "Valeriy", new List<string> { "OS", "MDK"} ),
             new Student(16, "Vasya", 1, "Isp"),
             new Teacher(35, "Viktor", new List<string> { "Math", "MDK" })
            };

            foreach (var item in person01)
            {
                item.Print();
            }

            Console.ReadKey();
        }
    }
}
