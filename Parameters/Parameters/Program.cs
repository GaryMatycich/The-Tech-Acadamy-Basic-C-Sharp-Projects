using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>()
            {
                Things = new List<string>() { "one", "two", "three"}
            };
            
            Employee<int> employee2 = new Employee<int>()
            {
                Things = new List<int>() { 1, 234, 45251, 166}
            };

            foreach (string thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();

            foreach (int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
