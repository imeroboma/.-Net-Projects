using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee bob = new Employee("Bob", 40, 20);
                Console.WriteLine(bob);
            decimal bobPay = bob.CalculatePay();
            Employee empty = new Employee();
            Console.WriteLine(empty);
                Console.WriteLine("Bob makes" + bobPay.ToString("c"));
            PermanentEmployee ann = new PermanentEmployee("Ann", 35, 25.5m, 5);
            Console.WriteLine(ann);
        }
    }
}
