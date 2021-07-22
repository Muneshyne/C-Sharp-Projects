using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints the current date and time to the console
            Console.WriteLine(DateTime.Now);

            // Asks the user for a number 
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Prints to the console the exact time it will be in X hours (num)
            Console.WriteLine(DateTime.Now.AddHours(num));
            Console.ReadLine();
        }
    }
}
