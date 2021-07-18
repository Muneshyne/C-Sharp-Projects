using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class MathClass
    {
          // create a method that will take an integer, perform a math operation, and the return as an integer. 
        public int Operation(int number)
        {
            number *= 20;
            return number;
        }

        // add a second method to the class with teh same name that will take in a decimal, create a different math
        // operation for it, then return the answer as an integer.
        public int Operation(decimal number)
        {
            int answer = (int)number / 15;
            return answer;
        }

        // add a third method to this class, with the same name, that will take a string, convert it to an integer
        // if possible, do a different math operation to it, then return the answer as an integer. 
        public int Operation(string input)
        {
            int number = Convert.ToInt32(input);
            int answer = number * 500;
            return answer;
        }
    }
}
