using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of data type Number and assign an amount to it.
            Number number = new Number() { Amount = 145 };

            //Print this amount to the console. 
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
