using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batrak_20._02
{
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public virtual void Print()
        {
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Name: " + name);
        }
        
        public override string ToString()
        {
            return "Age: " + age + "Name" + name;
        }

    }

}
