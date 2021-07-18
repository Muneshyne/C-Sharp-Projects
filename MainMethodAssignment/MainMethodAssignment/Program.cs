using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class and call the one method, passing in an integer, display to screen.
            MathClass maths = new MathClass();
            Console.WriteLine(maths.Operation(60));
            Console.ReadLine();

            // instantiate the class and call the second method, passing in a decimal
            MathClass timesDec = new MathClass();
            decimal point = 143.75m;
            Console.WriteLine(timesDec.Operation(point));
            Console.ReadLine();

            // instantiate the class and call the third method, passing in a string that equates to an integer 
            MathClass quotient = new MathClass();
            string input = "256";
            Console.WriteLine(quotient.Operation(input));
            Console.ReadLine();

        }
    }
}
