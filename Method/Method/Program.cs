using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            Console.WriteLine("Please enter a number:");
            int userNum1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a second number or leave this line blank:");
            string userString = Console.ReadLine();
            // giving userNum2 a default value
            int userNum2 = 0;

            // checking to see if the user entered a null value
            if (!string.IsNullOrEmpty(userString))
            {
                // if they entered a number we use there input as normal
                try
                {
                    int x = Convert.ToInt32(userString);
                    userNum2 = x;
                }
                // if they entered a word we catch the exception
                catch (Exception)
                {
                    Console.WriteLine("Please only enter a number or leave blank.");
                }
                finally
                {
                    Console.ReadLine();
                }
            }

            int result = myClass.MyMethod(userNum1, userNum2);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
