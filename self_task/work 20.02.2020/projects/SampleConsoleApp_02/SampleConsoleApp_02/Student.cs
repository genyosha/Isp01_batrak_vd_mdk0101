using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsoleApp_02
{
    class Student : User
    {
        private int scholarship;
        private int course;

        public Student(string name, int age, int scholarship, int course) : base(name,age)
        {
            this.scholarship = scholarship;
            this.course = course;
        }

        public int getSchoolarship()
        {
            return scholarship;
        }

        public void setSchoolarship(int scholarship)
        {
            this.scholarship = scholarship;
        }

        public int getCourse()
        {
            return course;
        }

        public void setCourse(int course)
        {
            this.course = course;
        }
    }
}
