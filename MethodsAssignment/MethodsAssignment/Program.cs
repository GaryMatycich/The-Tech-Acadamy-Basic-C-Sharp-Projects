using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating a new object of type MyClass
            MyClass myClass = new MyClass();

            Console.WriteLine("Please enter a number.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // calling the methods of MyClass to act on the user input
            int output1 = myClass.MyAdd(userInput);
            Console.WriteLine(output1);
            int output2 = myClass.MySubtract(userInput);
            Console.WriteLine(output2);
            int output3 = myClass.MyMultiply(userInput);
            Console.WriteLine(output3);

            Console.ReadLine();
        }
    }
}
