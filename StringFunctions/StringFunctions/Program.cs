using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jeremy";
            //// escape character \ , \n = new line , \t = tab in line
            //string quote = "The man said, \"Hello\", Jeremy \n Hello on a new line \n \t Hello on a tab.";
            //string fileName = @"C:\Users\Jeremy"; // double backslach \\ is an escape for backslashes, usful for file paths
            //// use the @ sign to show that everything inside has no escape sequences

            //bool trueOrFalse = name.Contains("r");

            //int length = name.Length;

            //Console.WriteLine(length);
            //Console.ReadLine();

            // strings are immutable
            //string name = "Jeremy";
            //name = "Joe";
            // this doesn't change the string just makes a new string

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jeremy");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
