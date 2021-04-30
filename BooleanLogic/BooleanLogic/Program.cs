using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {   
            // gathering age from user and converting it from a string to byte
            Console.WriteLine("What is your age?");
            byte custAge = Convert.ToByte(Console.ReadLine());

            // gathering DUI history from user and converting it from a string to bool
            Console.WriteLine("Have you ever had a DUI?");
            bool custDUI = Convert.ToBoolean(Console.ReadLine());

            // gathering ticket history from user and converting it from a string to byte
            Console.WriteLine("How many speeding tickets do you have?");
            byte custTickets = Convert.ToByte(Console.ReadLine());

            // creating a variable called "qualified" of type bool and setting its value
            // based on a our gathered user data.
            bool qualified = custAge > 15 && custDUI == false && custTickets <= 3;
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified);
            Console.Read();

        }
    }
}
