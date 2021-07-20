using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate an Employee object with the firstName "Sample" and lastName "Student"
            Employee employee = new Employee()
            {
                firstName = "Sample",
                lastName = "Student"
            };
            // call the SayName() method on the object. 
            employee.SayName();
            Console.ReadLine();
        }
    }
}
