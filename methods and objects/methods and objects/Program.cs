using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // istantiating a new employee object and initializing it with a name propertys
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            // calling the superclass method "SayName"
            employee.SayName();
            Console.ReadLine();
        }
    }
}
