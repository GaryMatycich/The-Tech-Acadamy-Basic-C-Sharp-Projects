using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a list of numbers
            List<int> numbers = new List<int>
            {
                25,
                9,
                40,
                82,
                16
            };
            // getting user input
            Console.WriteLine("Enter a number to see some math.");

            try
            {
                // using a try block to check user input format
                int userNum = Convert.ToInt32(Console.ReadLine());
                // running a foreach loop to divide each number in the list
                foreach (int number in numbers)
                {
                    int output = number / userNum;
                    Console.WriteLine($"{number} divided by {userNum} equals {output}.");
                }
            }
            // checking if the user entered 0
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please enter a number larger then 0");
            }
            // checking if the user entered a string
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number");
            }
            // checking for any exceptions I had not accounted for
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            // using the "finally" keyword to force this instruction to fire off no matter what.
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
