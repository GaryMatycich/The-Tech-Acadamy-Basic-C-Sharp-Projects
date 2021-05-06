using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates a employee object of type IQuittable
            IQuittable employee = new Employee();

            employee.Quit();
        }
    }
}
