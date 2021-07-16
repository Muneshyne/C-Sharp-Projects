using System;


namespace LoopAssignment
{
    class Program
    {
        static void Main()
        {
            // set bool for getting out of while loop
            bool numPick = false;

            //While loop
            while (!numPick)
            {
                
            Console.WriteLine("\tPick a number between 1 and 10");
            int number = Convert.ToInt32(Console.ReadLine()); //sets entered to integar for switch/ case
         
                switch (number)
                {
                    case 1:
                        Console.WriteLine("1 is not correct! Try again.");
                        break;
                    case 2:
                        Console.WriteLine("2 is not right, sorry. Try again.");
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3 but not correct. Try again.");
                        break;
                    case 4:
                        Console.WriteLine("You guessed 4 but not correct. Try again.");
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5 but not correct. Try again.");
                        break;
                    case 6:
                        Console.WriteLine("You guessed 6 but not correct. Try again.");
                        break;
                    case 7:
                        Console.WriteLine("You guessed 7 but not correct. Try again.");
                        break;
                    case 8:
                        Console.WriteLine("You guessed 8. So close, but not correct. Try again.");
                        break;
                    case 9:
                        Console.WriteLine("You guessed 9! That is correct!!");
                        numPick = true;
                        break; //needed break to stop from infinite loop
                    case 10:
                        Console.WriteLine("You guessed 10, So close. Try again");
                        break;
                    default:
                        Console.WriteLine("\tThat's not between 1 and 10!");
                        break;
                }

            }

            Console.WriteLine("\n\tWant to try and pick my favorite number!");
            Console.WriteLine("\tGuess a number between 10 and 30?");
            int favNum = Convert.ToInt32(Console.ReadLine());
            bool myNum = favNum == 13;

            // execute a do while loop, this avoids the problem of the while loop not running at all. 
            do
            {
                
                if (favNum != 13) //if not 13
                {   
                    Console.WriteLine("\tNope! try again. ");
                    Console.WriteLine("\tGuess a number between 10 and 30?");
                    favNum = Convert.ToInt32(Console.ReadLine());
                }
                
                else
                {
                    Console.WriteLine("\t\n13! That is my favorite number!! Correct!"); //tab in an new line for correct answer
                    break;
                }
            }
            while (!myNum);
            Console.Read();




        }
    }
}
