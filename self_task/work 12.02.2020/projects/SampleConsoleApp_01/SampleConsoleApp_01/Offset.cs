using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Offset
    {
        public string NameOfTestSubject { set; get; }
        public string NameOfExaminer { get; set; }
        public string Date { get; set; }
        public int Rating { get; set; }
        public Offset(string nameOfTestSubject, string nameOfExaminer, string date, int rating)
        {
            NameOfTestSubject = nameOfTestSubject;
            NameOfExaminer = nameOfExaminer;
            Date = date;
            Rating = rating;
        }
        public override string ToString()
        {
            return "Name of test subject: " + NameOfTestSubject + "Name of examiner: "
                + NameOfExaminer + "Date: " + Date + "Rating:" + Rating;
        }
    }
}