using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate an Employee object with type "string" as its generic parameter.
            Employee<string> employee = new Employee<string>();
            //Assign a list of strings as the property value of Things.
            employee.Strings = new List<string>() { "Str1", "Str2", "Str3" };
            // create a loop that prints all of the Things to the Console.
            foreach (string thing in employee.Strings)
            {
                Console.WriteLine(thing);
            }

            // instantiate an Employee object with type "int" as its generic parameter. 
            Employee<int> employee1 = new Employee<int>();
            // Assign a list of integers as the property value of Things.
            employee1.Strings = new List<int>() { 13, 21, 7 };
            foreach (int thing in employee1.Strings)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
