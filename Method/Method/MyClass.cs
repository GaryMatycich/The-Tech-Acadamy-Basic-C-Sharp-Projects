using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    public class MyClass
    {
        public int MyMethod(int num1, int num2 = 0)
        {
            int output = num1 + num2 + 25;
            return output;
        }
    }
}
