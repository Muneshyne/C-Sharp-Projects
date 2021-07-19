using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Void
    {
        // create a void method that takes two integers as parameters
        public void method(int num1, int num2)
        {
            // have the method do a math operation on the first integer and display the second integer to the screen.
            num1 += num1;
            Console.WriteLine(num2);
        }
    }
}
