using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating a new object of type MyClass
            MyClass myClass = new MyClass();

            // calling a method of the object myClass
            int result1 = myClass.MyMethod(5);
            Console.WriteLine(result1);

            // calling an overload method
            int result2 = myClass.MyMethod(5.54m);
            Console.WriteLine(result2);

            int result3 = myClass.MyMethod("10");
            Console.WriteLine(result3);

            Console.ReadLine();
        }
    }
}
