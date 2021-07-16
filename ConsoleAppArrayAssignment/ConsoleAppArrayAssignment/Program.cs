using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        // create a one dimensional Array of strings. 
        string[] stringArray = { "String", "Sting", "Thing", "Sing", "Ping" };
        //Ask the user to select an index of the Array and then display the string at that index on the screen.

        Console.WriteLine("Enter a string index from 0 to 4");
        int index = Convert.ToInt32(Console.ReadLine());
        //Add in a message that displays when the user selects an index that doesn’t exist.
        string result = (index <0 || index  > 4) ? "Index does not exist. " : stringArray[index];
        Console.WriteLine(result);

        // create a one dimensional Array of integers.
        int[] intArray = { 2, 13, 320, 4328, 10 };
        //Ask the user to select an index of the Array and then display the string at that index on the screen. 

        Console.WriteLine("Enter an integar index from 0 to 4");
        index = Convert.ToInt32(Console.ReadLine());

        result = (index < 0 || index > 4) ? "Index does not exist. " : Convert.ToString(intArray[index]);
        Console.WriteLine(result);

        // create a list of strings
        List<string> strList = new List<string>();
        strList.Add("This");
        strList.Add("Array");
        strList.Add("Is");
        strList.Add("A");
        strList.Add("String");

        Console.WriteLine("Enter an new string index from 0 to 4");
        index = Convert.ToInt32(Console.ReadLine());
        //Add in a message that displays when the user selects an index that doesn’t exist.
        result = (index < 0 || index > 4) ? "That index does not exist. " : strList[index];
        Console.WriteLine(result);
        Console.Read();
    }
}

