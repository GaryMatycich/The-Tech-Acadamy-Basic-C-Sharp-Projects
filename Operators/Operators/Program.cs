using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee()
            {
                id = 115
            };
            Employee employee2 = new Employee()
            {
                id = 115
            };

            // running a comparison using a overloaded == operator
            bool outcome = employee1 == employee2;

            Console.WriteLine(outcome);
            Console.ReadLine();
        }
    }
}
