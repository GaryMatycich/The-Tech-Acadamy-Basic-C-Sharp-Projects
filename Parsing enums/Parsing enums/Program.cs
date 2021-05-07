using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_enums
{
    class Program
    {
        // creating an enum
        enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saterday, Sunday}

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week:");
            string userInput = Console.ReadLine();
            try
            {
                // parsing user input to find a match in our enum
                Days dayValue = (Days)Enum.Parse(typeof(Days), userInput, true);
                // printing the corrisponding enum value to screen
                Console.WriteLine(dayValue);
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
    }
}
