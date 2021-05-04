using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    public class MyClass
    {
        // creating a new public method that takes in an int and returns an int
        public int MyAdd(int num)
        {
            int result = num + 5;
            return result;
        }

        public int MySubtract(int num)
        {
            int result = num - 2;
            return result;
        }

        public int MyMultiply(int num)
        {
            int result = num * 10;
            return result;
        }
    }
}
