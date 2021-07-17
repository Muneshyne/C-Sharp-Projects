using System;


namespace ExceptionHandling // to catch errors (try / catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number.");
                int numOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numThree = numOne / numTwo;
                Console.WriteLine(numOne + " divided by " + numTwo + " equals " + numThree);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine(); // a lot of the time you'll have a dB log here in the finally statement
            }
            
        }
    }
}
