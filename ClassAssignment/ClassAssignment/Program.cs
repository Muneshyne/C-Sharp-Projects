using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class.
            aClass aclass = new aClass();
            // have the user enter a number.
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            // call the method on that number. Display the output to the screen.
            aclass.Divide(number);
            Console.WriteLine("{0} / 2 = {1}", number, aclass.Answer);


            // run function with 'out' parameters, declare variables inline
            aclass.intEquals(out int multiply, out int dividend, number);
            Console.WriteLine("{0} X 5 = {1}\n{0} / 4 = {2}", number, multiply, dividend);
            Console.Read();
        }
    }
}
