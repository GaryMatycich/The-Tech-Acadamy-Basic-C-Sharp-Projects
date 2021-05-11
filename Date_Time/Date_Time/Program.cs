using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates a DateTime object that holds the current time as a value
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            Console.ReadLine();

            Console.WriteLine("please pick a number under 10:");
            int userNum = Convert.ToInt32(Console.ReadLine());

            // adds 2 hours onto the DateTime.Now object
            Console.WriteLine(dateTime.AddHours(userNum));
            Console.ReadLine();
        }
    }
}
