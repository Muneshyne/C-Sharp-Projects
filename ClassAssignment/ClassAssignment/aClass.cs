using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    // Create a class. 
    public class aClass
    {
        // constructor for Class1
        public aClass()
        {
            Answer = 0;
        }
        public int Answer { get; set; }

        //create a void method that outputs an integer. Have the method divide the data passed to it by 2.
        public void Divide(int number)
        {
            Answer = number / 2;
            return;
        }

        // create a method with output parameters. 
        public void intEquals(out int multiply, out int dividend, int number)
        {
            multiply = number * 5;
            dividend = number / 4;
            return;
        }

        //overload a method
        public void Divide(int number, int quotient)
        {
            Answer = number / quotient;
            return;
        }
    }
}
