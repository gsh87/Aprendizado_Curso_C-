using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Entities
{
    class OutSourcedEmployees: Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSourcedEmployees()
        {

        }

        public OutSourcedEmployees(string name, int hours, double valuePerHour, double additionalCharge): base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double payment()
        {
            return base.payment()+1.1* AdditionalCharge;
        }
    }
}
