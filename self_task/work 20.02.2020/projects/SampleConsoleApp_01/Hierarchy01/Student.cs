using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batrak_20._02
{
    class Student : Person
    {
        private int course;
        private string group;

        public int Course
        {
            get
            {
                return course;
            }
            set
            {
                course = value;
            }
        }

        public string Group
        {
            get
            {
                return group;
            }
            set
            {
                group = value;
            }
        }

        public Student(int age, string name, int course, string group) : base(age, name)
        {
            this.course = course;
            this.group = group;
        }

        public int NextCourse()
        {
            int nextCourse = course++;
            return nextCourse;
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return "Course: " + course + "Group: "+ group;
        }
    }

}
