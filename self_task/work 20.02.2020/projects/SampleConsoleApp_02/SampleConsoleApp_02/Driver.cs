using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsoleApp_02
{
    class Driver : Worker
    {
        private int experience;
        private string category;
       
        public Driver(string name, int age, int salary, int experience, string category) : base(name, age, salary)
        {
            this.experience = experience;
            this.category = category;
        }

        public int getExperience()
        {
            return experience;
        }

        public void setExperience(int experience)
        {
            this.experience = experience;
        }

        public string getCategory()
        {
            return category;
        }

        public void setCategory(string category)
        {
            if (category == "A" || category == "B" || category == "C")
                this.category = category;
            else
                throw new IndexOutOfRangeException();
        }
    }
}
