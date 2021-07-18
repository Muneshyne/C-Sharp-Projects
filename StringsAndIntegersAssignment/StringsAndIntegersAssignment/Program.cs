using System;
using System.Collections.Generic;


namespace StringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Create a list of integers
            List<int> numList = new List<int> { 6, 84, 45, 7624, 528, 122 };
            
            
                try
                {
                    //Ask the user for a number to divide each number in the list by
                    Console.WriteLine("\tEnter a number you wish to divide by in the list. ");

                    int quotient = Convert.ToInt32(Console.ReadLine());
                    // Write a loop that takes each integer in the list,
                    // divides it by the number the user entered, and displays the result to the screen
                    foreach (int num in numList)
                    {
                        Console.WriteLine(num / quotient);
                    }
                }
                catch (DivideByZeroException ex) //no dividing by 0
                {
                    Console.WriteLine("\tPlease do not divide by ZERO.");
                    
                }
                // to catch non integar entered. Input string was not in a correct format.
                catch (FormatException ex)
                {
                    Console.WriteLine("\tPlease enter a whole number.");
                    
                }
                catch (Exception ex) //a general error message if any wrong data type entered.
                {
                    Console.WriteLine(ex.Message);
                    
                }
                finally
                {
                   
                    Console.ReadLine();
                }
            // to display after try catch block has executed.
            Console.WriteLine("\t\nThe program emerged from try/catch block.");
            Console.Read();

        }
    }
}
