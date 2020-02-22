using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batrak_20._02.Hierarchy03
{
    class Employee
    {
        private int id;
        private string name;

        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public override string ToString()
        {
            return "Name: " + name + "Id: " + id;
        }
    }
}
