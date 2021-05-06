using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Employee : Person
    {
        public int id { get; set; }
        // this method is required by our abstract class. the override keyword allows us to augment its implimentation
        public override void SayName()
        {
            Console.WriteLine($"{firstName} {lastName}");
        }

        // creates an overloaded == operator to perform a comparison in a specific way
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            bool result = employee1.id == employee2.id;
            return result;
        }

        // this opposite comparison operator must also be overloaded
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            bool result = employee1.id != employee2.id;
            return result;
        }
    }
}
