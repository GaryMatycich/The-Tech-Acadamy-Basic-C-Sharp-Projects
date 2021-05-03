using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_assignment
{
    class Program
    {
        static void Main()
        {
            // creating a string array and then gathering user input.
            string[] original6 = { "Red Wings", "Bruins", "Rangers", "Leafs", "Canadians", "Black Hawks" };
            Console.WriteLine("Picks a number between 0-4");
            int hockeyPick = Convert.ToInt32(Console.ReadLine());
            // using a try/catch block to attempt using the users input as an index value
            try
            {
                Console.WriteLine(original6[hockeyPick]);
            }
            catch
            {
                Console.WriteLine("The number you picked was outside the avalable range");
            }

            // -----------------------------------------------------------------

            int[] numbers = { 4, 53, 633, 62234 };
            Console.WriteLine("Picks a number between 0-3");
            int numberPick = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(numbers[numberPick]);
            }
            catch
            {
                Console.WriteLine("The number you picked was outside the avalable range");
            }

            // -----------------------------------------------------------------

            // creating a list of strings, adding values into the list.
            List<string> states = new List<string>();
            states.Add("Michigan");
            states.Add("Maine");
            states.Add("Vermont");
            states.Add("New York");
            // getting input from the user and using that data to grab the string in its index
            Console.WriteLine("Picks a number between 0-3");
            int statePick = Convert.ToInt32(Console.ReadLine());
            // using a try/catch block to avoid errors
            try
            {
                Console.WriteLine(states[statePick]);
            }
            catch
            {
                Console.WriteLine("The number you picked was outside the avalable range");
            }
            Console.ReadLine();
        }
    }
}
