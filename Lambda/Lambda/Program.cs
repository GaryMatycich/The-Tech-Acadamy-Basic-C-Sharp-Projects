using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates a list of Employees
            var employees = new List<Employee>()
            {
              new Employee(){ FirstName="Joe", LastName="Smith", Id=124},
              new Employee(){ FirstName="Gary", LastName="Matycich", Id=735},
              new Employee(){ FirstName="Eric", LastName="Raymon", Id=537},
              new Employee(){ FirstName="Kate", LastName="Matycich", Id=935},
              new Employee(){ FirstName="John", LastName="Connor", Id=358},
              new Employee(){ FirstName="Sarah", LastName="Something", Id=383},
              new Employee(){ FirstName="Joe", LastName="Blah", Id=174},
              new Employee(){ FirstName="Conan", LastName="Barb", Id=823},
              new Employee(){ FirstName="Luke", LastName="Skywalker", Id=191},
              new Employee(){ FirstName="Ripley", LastName="Matycich", Id=796},
            };

            //--------------------------------------------------------------------------

            // foreach loop that creates a new list of Employees with the first name "Joe" from our previous list
            var joeList = new List<Employee>();
            foreach (Employee joe in employees)
            {
                if (joe.FirstName == "Joe")
                {
                    joeList.Add(joe);
                }
            }

            //---------------------------------------------------------------------------
            // lambda expression that creates a new list of joes from our original Employee list
            List<Employee> newJoeList = employees.Where(x => x.FirstName == "Joe").ToList();

            //---------------------------------------------------------------------------

            // lambda expression that creates a new list of employees with and ID greater then 5
            List<Employee> anotherJoeList = employees.Where(x => x.Id > 5).ToList();

            //---------------------------------------------------------------------------

            Console.ReadLine();

        }
    }
}
