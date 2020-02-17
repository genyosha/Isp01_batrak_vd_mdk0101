using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class WorkShop
    {
        public int StringCipher { get; set; }
        public int AmountWorkers { get; set; }

        public WorkShop(int stringCipher, int amountWorkers)
        {
            StringCipher = stringCipher;
            AmountWorkers = amountWorkers;
        }
        public override string ToString()
        {
            return "String Sipher: " + StringCipher + "Amount Workers: " + AmountWorkers;
        }
    }
}
