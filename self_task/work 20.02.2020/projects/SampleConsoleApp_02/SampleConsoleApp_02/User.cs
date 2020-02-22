using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsoleApp_02
{
    class User
    {
        protected string name;
        protected int age;

        public User (string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public int getAge()
        {
            return age;
        }
    }
}
