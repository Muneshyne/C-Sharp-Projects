using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
        //Create a class. In that class, create a method that takes two integers as parameters.
        class userInput
        {
            //Have the method do a math operation and return an integer result
            public int Method(int times, int multiply = 13)
            {
                int product = times * multiply;
                return product;
            }
        }
}
