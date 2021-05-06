using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating our employee object
            Employee employee = new Employee()
            {
                firstName = "Gary",
                lastName = "Matycich"
            };
            // utilizing our inherited method
            employee.SayName();
            Console.ReadLine();
        }
    }
}
