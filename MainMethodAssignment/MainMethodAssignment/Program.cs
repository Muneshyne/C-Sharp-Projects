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
            // instantiate the class and call the one method, passing in an integer
            MathClass math = new MathClass();
            Console.WriteLine(math.Operation(60));
            Console.ReadLine();

            // instantiate the class and call the second method, passing in a decimal
            MathClass math1 = new MathClass();
            decimal point = 143.75m;
            Console.WriteLine(math1.Operation(point));
            Console.ReadLine();

            // instantiate the class and call the third method, passing in a string that equates to an integer 
            MathClass math2 = new MathClass();
            string input = "256";
            Console.WriteLine(math2.Operation(input));
            Console.ReadLine();
        }
    }
}
