using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsoleApp_02
{
    class Worker : User
    {
        private int salary;

        public Worker(string name, int age, int salary) : base(name, age)
        {
            this.salary = salary;
        }

        public int getSalary()
        {
            return salary;
        }

        public void setSalary(int salary)
        {
            this.salary = salary;
        }


    }
}
