using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMetohdsAssignment
{
    class Math
    {
        //create three methods, each of which will take one integer parameter in and return an integer 
        public static int Subtract10(int number)
        {
            number -= 10;
            return number;
        }
        public static int Multiply50(int number)
        {
            number *= 50;
            return number;
        }
        public static int DivideBy20(int number)
        {
            number /= 20;
            return number;
        }
    }
}