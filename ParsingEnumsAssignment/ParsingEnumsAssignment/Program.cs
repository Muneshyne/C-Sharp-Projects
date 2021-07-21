using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the current day of the week.
            Console.WriteLine("Enter the current day of the week: ");

            // Assign the value to a variable of that enum data type you just created. 
            string input = Console.ReadLine().ToLower();
            try
            {
                // Converts input into an enum (if it corresponds with an element in enum)
                Enum.Parse(typeof(DaysOfTheWeek), input);
                Console.WriteLine("Successful!");
            }

            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week. ");
            }

            Console.ReadLine();

        }
        // Created an enum for days of the week. 
        public enum DaysOfTheWeek
        {
            sunday,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday
            
        }
    }
}
