using System;

namespace SampleConsoleApp_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker01 = new Worker("Иван", 25, 1000);
            Worker worker02 = new Worker("Вася", 26, 2000);
    
            Console.WriteLine($"Зарплата Васи и Ивана: {worker01.getSalary() + worker02.getSalary()}");
        }
    }
}
