using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_doWhile
{
    class Program
    {
        static void Main()
        {
            // starts a while loop that increments variable i by 1 while i is less then 10
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadLine();

            //--------------------------

            // starts a do while loop that adds 5 to x while x is less then 50
            // this block executes before the condition is checked
            int x = 5;
            do
            {
                Console.WriteLine(x);
                x += 5;
            }
            while (x < 50);
            Console.ReadLine();
        }
    }
}
