using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    // creates a abstract class
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        // creates a abstract method
        public abstract void SayName();
    }
}
