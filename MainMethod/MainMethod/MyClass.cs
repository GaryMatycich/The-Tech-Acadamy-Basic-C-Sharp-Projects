using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class MyClass
    {
        public int MyMethod(int num)
        {
            int output = num + 10;
            return output;
        }

        public int MyMethod(decimal num)
        {
            // converting a decimal to a int
            decimal outputDecimal = 20 * num;
            int output = Convert.ToInt32(outputDecimal);
            return output;
        }

        public int MyMethod(string num)
        {
            // converting a string to a int
            int numInt = Convert.ToInt32(num);
            int output = 50 / numInt;
            return output;
        }
    }
}
