using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            Console.WriteLine("Please enter a number:");
            int userNum1 = Convert.ToInt32(Console.ReadLine());

            myClass.MyMethod(userNum1);
            Console.ReadLine();
        }
    }
}
