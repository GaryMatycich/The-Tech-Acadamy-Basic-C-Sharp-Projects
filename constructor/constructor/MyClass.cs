using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class MyClass
    {
        // This is an alternate constructor used when we dont have arguments to pass or want default settings
        public MyClass() : this(5, "aWord")
        {
        }

        public MyClass(int num1, string word)
        {
        }
    }
}
