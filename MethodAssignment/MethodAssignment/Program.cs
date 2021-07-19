using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class
            userInput userInput = new userInput();

            //Ask the user to input two numbers, one at a time
            Console.WriteLine("Enter a number to multiply ");
            int times = Convert.ToInt32(Console.ReadLine());
            //second number is optional. Let them know they need not enter anything for the second number
            Console.WriteLine("Enter another number to multiply (This is an optional number; will be 13 if no entry) ");
            string optional = Console.ReadLine();

            //Call the method in the class, passing in the one or two numbers entered
            if (optional == "")
            {
                Console.WriteLine(times + " *  13 = " + userInput.Method(times));
            }
            else
            {
                int multiply = Convert.ToInt32(optional);
                Console.WriteLine("{0} * {1} = {2}", times, multiply, userInput.Method(times, multiply));
            }

            Console.Read();

        }
    }
}
