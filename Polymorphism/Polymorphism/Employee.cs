using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee : Person, IQuittable
    {
        // this method is required by the interface we are inheriting from
        public void Quit()
        {
            throw new NotImplementedException();
        }

        // this method is required by our abstract class. the override keyword allows us to augment its implimentation
        public override void SayName()
        {
            Console.WriteLine($"{firstName} {lastName}");
        }
    }
}
