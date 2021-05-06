using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_and_objects
{
    public class Person
    {
        // creating propertys of the person class
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // creating a method that will be used as a superclass method
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

    
}
