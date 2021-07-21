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
            Employee person1 = new Employee() { Id = 002 };
            Employee person2 = new Employee() { Id = 003 };
            Console.WriteLine(person1 == person2); //checks if two Employee objects are equal by comparing their Id property
            Console.WriteLine(person1 != person2);
            Console.ReadLine();
        }
    }
}
