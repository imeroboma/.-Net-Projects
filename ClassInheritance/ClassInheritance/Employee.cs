using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    class Employee
    {
        //private data
        private string name;
        private decimal hours;
         private decimal rate;


        //constructor
        public Employee() { }
        public Employee(string n, decimal h, decimal r)
        {
            name = n;
            hours = h;
            rate = r;
        }

        //public methods
        public decimal CalculatePay()
        {
            const decimal FULL_WEEK = 37.5m;
             const decimal OT_RATE = 1.5m;
            if (hours <= FULL_WEEK)
                return hours * rate;
            else
                return FULL_WEEK * rate + (hours - FULL_WEEK) * rate * OT_RATE;



        }
        public override string ToString()
        {
            return name + ":" + hours + "," +rate.ToString("c");
        }
    }
}
