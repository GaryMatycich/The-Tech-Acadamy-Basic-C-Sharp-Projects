using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    // Employee inherits from Person
    public class Employee : Person
    {
        // this method is required by our abstract class. the override keyword allows us to augment its implimentation
        public override void SayName()
        {
            Console.WriteLine($"{firstName} {lastName}");
        }
    }
}
