using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Gathering weight data from user. If variable "weight" is larger then 50
            // a message will be displayed and the application will exit.
            Console.WriteLine("Please enter the package weight:");
            ushort weight = Convert.ToUInt16(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.Read();
                Environment.Exit(0);
            }

            // creating a variable named width of type ushort from data the user enters.
            Console.WriteLine("Please enter the package width;");
            ushort width = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Please enter the package height;");
            ushort height = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            ushort length = Convert.ToUInt16(Console.ReadLine());

            // running our variables through a equation to find our outcome
            decimal outcome = (width * height * length) * weight / 100;
            // converting our decimal outcome to a string and formating it to display 2 digits to the right of the point
            string quote = outcome.ToString("F");

            // concatinating a response message that includes our newly created string "quote"
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote + "\nThank you!");
            Console.Read();
        }
    }
}
