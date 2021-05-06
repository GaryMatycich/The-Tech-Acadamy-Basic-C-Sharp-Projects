using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class MyClass
    {
        // void method outputing integer
        public void MyMethod(int num)
        {
            int output = num / 2;
            Console.WriteLine(output);
        }
        // this is a overload of MyMethod
        public void MyMethod(int num, int num2)
        {
            int output = num / 2 + 5;
            Console.WriteLine(output);
        }
        // this method has a output parameter
        public void MyOutput(out int num2)
        {
            num2 = 50;
        }
    }
}
