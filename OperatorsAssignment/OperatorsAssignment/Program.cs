using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create two employee objects to test overload. 
            Employee person1 = new Employee() { Id = 002 };
            Employee person2 = new Employee() { Id = 003 };
            Console.WriteLine(person1 == person2);
            Console.WriteLine(person1 != person2);
            Console.ReadLine();
        }
    }
}
