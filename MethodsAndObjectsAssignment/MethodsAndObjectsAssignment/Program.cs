using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student”
            Employee employee = new Employee(); // from employee class
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName(); // from Person class
            // call the superclass method SayName() on the Employee object
            Console.ReadLine();
        }
    }
}
