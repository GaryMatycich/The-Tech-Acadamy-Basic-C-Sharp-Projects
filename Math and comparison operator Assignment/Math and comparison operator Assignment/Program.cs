using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_and_comparison_operator_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Comparison Program" + "\n");

            // creating a variable of type byte and giving it a value converted from user input string
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            byte rateP1 = Convert.ToByte(Console.ReadLine());

            // creating a variable of type byte and giving it a value converted from user input string
            Console.WriteLine("Hours worked per week?");
            byte hoursP1 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            byte rateP2 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            byte hoursP2 = Convert.ToByte(Console.ReadLine());

            // creating a variable of type decimal and giving it a value of rateP1 times rateP2 times 52 weeks
            Console.WriteLine("Annual salary of Person 1");
            decimal totalP1 = rateP1 * hoursP1 * 52;
            Console.WriteLine(totalP1);

            Console.WriteLine("Annual salary of Person 2");
            decimal totalP2 = rateP2 * hoursP2 * 52;
            Console.WriteLine(totalP2);

            // comparing our two total variables and outputing a bool variable called compareP1ToP2
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool compareP1ToP2 = totalP1 > totalP2;
            Console.WriteLine(compareP1ToP2);
            Console.Read();
        }
    }
}
