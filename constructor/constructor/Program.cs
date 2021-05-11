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
        }
    }
}
