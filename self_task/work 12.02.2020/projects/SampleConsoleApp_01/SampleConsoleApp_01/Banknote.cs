using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Banknote
    {
        public string SeriesAndNumber { get; set; }
        public int FaceValue { set; get; }
        public string FaceValueFill { get; set; }

        public Banknote(string seriesAndNumber, int faceValue, string faceValueFill)
        {
            SeriesAndNumber = seriesAndNumber;
            FaceValue = faceValue;
            FaceValueFill = faceValueFill;
        }

        public override string ToString()
        {
            return "Series and number: " + SeriesAndNumber + "Face value " + FaceValue + "Face value: "
                + FaceValueFill;
        }
    }
}