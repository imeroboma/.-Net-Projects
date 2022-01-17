using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    class PermanentEmployee : Employee
    {
        //added private data
        private decimal rrspPct;

        //constructor
        public PermanentEmployee(string n, decimal h, decimal r, decimal p)
            :base(n,h,r)
        {
            rrspPct = p;

        }
        //public methods
        //we can define new methods
    }
}
