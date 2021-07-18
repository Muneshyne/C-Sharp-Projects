using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMetohdsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user what number they want to do the math operations on. 
            Console.WriteLine("Enter a number to perform math operations on: ");
            int number = Convert.ToInt32(Console.ReadLine());
            // Call each method in turn, passing the user input to the method 
            // Display the returned integer to the screen
            Console.WriteLine(number + " - 10 = " + Math.Subtract10(number));
            Console.WriteLine(number + " x 50 = " + Math.Multiply50(number));
            Console.WriteLine(number + " / 50 = " + Math.DivideBy20(number));
            // keep the window open  
            Console.ReadLine();
        }
    }
}
