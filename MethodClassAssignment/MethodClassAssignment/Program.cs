using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class.
            Void class1 = new Void();
            // call the method in the class, passing in two numbers. 
            class1.method(34, 248);
            // call the method in the class, specifying the parameters by name. 
            class1.method(num1: 23, num2: 13);
            Console.ReadLine();
        }
    }
}
