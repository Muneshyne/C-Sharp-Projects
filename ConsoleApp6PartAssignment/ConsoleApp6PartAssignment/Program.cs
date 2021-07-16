using System;
using System.Collections.Generic;




class Program
{
    static void Main(string[] args)
    {
        // -------- part 1 --------
        // A one-dimensional array of strings.
        string[] stringArray = { "This ", "is ", "my ", "6 part ", "C# assignment. " };
        // Ask the user to input some text
        Console.WriteLine("Input text here: ");
        string text = Convert.ToString(Console.ReadLine());

        // A loop that iterates through each string in the array and adds the user's text input to the end of each string 
        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] += text;
        }

        // loop prints off each string in the array on a separate line. 
        foreach (string str in stringArray)
        {
            Console.WriteLine(str);
        }
        Console.ReadLine();


        // -------- part 2 --------
        // an infinite loop
        bool loopBool = true;
        int num = 0;
        while (loopBool)
        {
            Console.WriteLine(num);
            num++;
            if (num > 13) // makes the loop not infinite
            {
                loopBool = false;
            }
        }
        Console.ReadLine();


        // -------- part 3 --------
        // used to determine whether to continue iterating the loop is a “<”
        int number = 0;
        while (number < 7)
        {
            Console.WriteLine(number);
            number++;
        }
        Console.ReadLine();


        
        // used to determine whether to continue iterating the loop is a “<”
        number = 0;
        while (number <= 9)
        {
            Console.WriteLine(number);
            number++;
        }
        Console.ReadLine();


        // -------- part 4 --------
        // A list of strings where each item in the list is unique.
        List<string> beverages = new List<string>() { "water", "coffee", "tea", "soda", "juice" };
        //Console.WriteLine("Type coffee, water, soda, tea, or juice: ");
        // Ask the user to input text to search for in the list.
        Console.WriteLine("Enter a beverage type to search through the list: ");
        string input = Console.ReadLine().ToLower();
        // checks if the user put in text that isn't on the list, 
        if (beverages.Contains(input))
        {
            // A loop that iterates through the list and then displays the index of the list that contains matching text
            for (int i = 0; i < beverages.Count; i++)
            {
                if (beverages[i] == input)
                {
                    Console.WriteLine(input + " is at index " + i + " on the list. ");
                    // Added code to the loop that stops it from executing once a match has been found. 
                    break;
                }
            }
        }
        // Added code to the loop to check if the user put in text that isn't on the list
        else
        {
            Console.WriteLine("Input not on this list. ");
        }
        Console.ReadLine();


        // -------- part 5 --------
        // A list of strings that has at least two identical strings in the list 
        List<string> pets = new List<string> { "puppy", "turtle", "kitten", "puppy", "bird", "snake", "bird" };
        // Ask the user to select text to search for in the list 
        Console.WriteLine("Type turtle, bird, puppy, snake, or kitten: ");
        string pet = Console.ReadLine();
        string output = pet + " is found at indexes: ";
        // A loop that iterates through the list and then displays the indices of the items matching the user-selected text
        if (pets.Contains(pet))
        {
            for (int i = 0; i < pets.Count; i++)
            {
                if (pets[i] == pet)
                {
                    output += i + " ";
                }
            }
            Console.WriteLine(output);
        }
        else
        {
            Console.WriteLine("The item entered is not on this list.");
        }
        Console.ReadLine();


        // -------- part 6 --------
        // A list of strings that has at least two identical strings in the list
        List<string> cars = new List<string>() { "corvette", "tesla", "viper", "corvette", "maserati", "genesis", "maserati" };
        List<string> addCars = new List<string>();
        // Create a foreach loop that evaluates each item in the list,
        // and displays a message showing the string and 
        // whether or not is has already appeared in the list. 
        foreach (string fast in cars)
        {
            Console.WriteLine(fast + ":" + addCars.Contains(fast));
            addCars.Add(fast);
        }
        Console.ReadLine();

    }
}

