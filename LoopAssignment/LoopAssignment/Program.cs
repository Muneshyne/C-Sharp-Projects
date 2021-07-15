using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();

            //while (!input.Equals(string.Empty))
            //{
            //    Console.WriteLine("Input is {0}.", input);
            //    input = Console.ReadLine();
            //}

            string input2 = string.Empty;
            do
            {

                input2 = Console.ReadLine();
                Console.WriteLine("Input is {0}.", input2); // blank input

            } while (!input2.Equals(string.Empty)); // logs input you enter
        }
    }
}
