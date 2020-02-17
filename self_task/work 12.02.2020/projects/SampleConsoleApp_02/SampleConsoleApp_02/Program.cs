using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp_1batrak
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector01 = new Vector(3, 4.5, 2);
            Vector vector02 = new Vector(2, 1.2, 6);
            Vector vectorXYZ = new Vector(1, 2, 3);
            Console.WriteLine(vector01.ToString());
            Console.WriteLine(vector02.ToString());

            Console.WriteLine("Длины векторов: ");
            Console.WriteLine(vector01.Length());
            Console.WriteLine(vector02.Length());

            Console.WriteLine("Скалярное произведение векторов:");
            Console.WriteLine(vector01.ScalarProduct(vectorXYZ));
            Console.WriteLine(vector02.ScalarProduct(vectorXYZ));

            Console.WriteLine("Векторное произведение векторов:");
            Console.WriteLine(vector01.Product(vectorXYZ));
            Console.WriteLine(vector02.Product(vectorXYZ));
            Console.ReadKey();
        }

    }
}