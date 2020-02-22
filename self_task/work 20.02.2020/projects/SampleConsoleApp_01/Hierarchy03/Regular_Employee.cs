using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batrak_20._02.Hierarchy03
{
    class Regular_Employee : Employee
    {
        private float salary;
        private int bonus;

        public Regular_Employee(int id, string name, float salary,
            int bonus) : base(id, name)
        {
            this.salary = salary;
            this.bonus = bonus;
        }

        public float Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        
        public int Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }
        
        public override string ToString()
        {
            return "Salary: " + salary + "Bonus: " + bonus;
        }
    }
}
