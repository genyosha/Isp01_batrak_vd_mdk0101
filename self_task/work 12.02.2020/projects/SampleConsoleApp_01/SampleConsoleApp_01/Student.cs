using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        public string Name { get; set; }
        public int Course { get; set; }
        public readonly string Gender;

        public Student(string lastName, int lastCourse, string lastGender)
        {
            Name = lastName;
            Course = lastCourse;
            Gender = lastGender;
        }
        public override string ToString()
        {
            return "Name: " + Name + "Course: " + Course + "Gender: " + Gender;
        }
    }
}