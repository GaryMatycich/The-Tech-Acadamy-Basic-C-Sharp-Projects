using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            // calling MyMethod and passing in two parameters
            myClass.MyMethod(4, 6);
            
            // calling MyMethod and specifying parameters by name
            myClass.MyMethod(num1: 4, num2: 8);
        }
    }
}
