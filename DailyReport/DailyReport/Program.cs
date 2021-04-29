using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            // displaying a string greeting followed by a newline command
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report." + "\n");

            // creates a new string variable called "studentName" and gives it a value = to what the user typed
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();

            // creates a new ushort variable called "currentPage" and gives it a value resulting from the conversion of the string the user typed
            Console.WriteLine("What page number?");
            ushort currentPage = Convert.ToUInt16(Console.ReadLine());

            // creates a new bool variable called "needHelp" and gives it a value resulting from the conversion of the string the user typed
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            // creates a new byte variable called "hoursStudied" and gives it a value resulting from the conversion of the string the user typed
            Console.WriteLine("How many hours did you study today?");
            byte hoursStudied = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Thank you for your answer. An Instructor will respond to this shortly. Have a great day!");

        }
    }
}
