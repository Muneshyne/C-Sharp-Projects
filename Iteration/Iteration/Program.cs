using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++) //give a value, how long will the for loop run, add 1 (i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}
        //Console.ReadLine();        

        //string[] names = { "Adalyn", "Dylan", "David", "Marcus" };

        //for (int i = 0; i< names.Length; i++)
        //{
        //    if (names[i] == "Adalyn")
        //    {
        //        Console.WriteLine(names[i]);
        //    }
        //}
        //Console.ReadLine();

        //Print to the console
        //string[] names = { "Adalyn", "Dylan", "David", "Marcus" };

        //for (int i = 0; i < names.Length; i++)
        //{
        //    Console.WriteLine(names[i]);
        //}
        //Console.ReadLine();

        //itteration for a list
        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);
        //// testScores is our list
        ////foreach loop 
        //foreach (int score in testScores) //scores represents the item in the list which we're at
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + score);
        //    }
        //}
        //Console.ReadLine();

        //List<string> names = new List<string>() { "Adalyn", "Dylan", "David", "Marcus" };

        //foreach (string name in names)
        //{
        //    if (name = "Adalyn")
        //    {
        //        Console.WriteLine(name);
        //    }
        //}
        //Console.ReadLine();

        List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
        List<int> passingScores = new List<int>();

        foreach (int score in testScores)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }

        Console.WriteLine(passingScores.Count);
        Console.ReadLine();
    }
}

