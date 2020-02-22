using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batrak_20._02.Hierarchy03
{
    class Contract_Employee : Employee
    {
        private float pay_per_hour;
        private string contract_period;

        public Contract_Employee(int id, string name, float pay_per_hour,
            string contract_period) : base(id, name)
        {
            this.pay_per_hour = pay_per_hour;
            this.contract_period = contract_period;
        }

        public float Pay_Per_Hour
        {
            get { return pay_per_hour; }
            set { pay_per_hour = value; }
        }

        public override string ToString()
        {
            return "Pay per hour: " + pay_per_hour + "Contract period: "
                + contract_period;
        }
    }
}
