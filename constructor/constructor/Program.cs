using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // const keyword used to keep this variable from being altered
            const int birthYear = 1988;

            // var keyword used to implicitly define a type
            var ID = new Guid();

            // creating a new class using a alternate constructor with default parameters
            MyClass myClass1 = new MyClass();
            Console.WriteLine($"{myClass1.favoritNumber} {myClass1.randomWord}");

            // creating a new class with a constructor that requires parameters manually entered
            MyClass myClass2 = new MyClass(25, "Banana");
            Console.WriteLine($"{myClass2.favoritNumber} {myClass2.randomWord}");
            Console.ReadLine();
        }
    }
}
