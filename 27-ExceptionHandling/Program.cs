using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exceptions

            // - An exception is an error that occurs during excution

            //      try       = try some code that is considered "dangerous"
            //      catch     = catches and handles exceptions when they occur
            //      finally   = always executes regardless if exception is caught or not

            double x;
            double y;
            double result;

            try
            {
                Console.Write("Enter number 1: ");
                x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                y = Convert.ToDouble(Console.ReadLine());

                result = x / y;

                Console.Write("Result: " + result);

            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter ONLY numbers PLEASE!!!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by zero!");
            }
            catch (Exception e) // this is really bad practice by itself, user won't know what exactly went wrong
            {
                Console.WriteLine("Something went wrong!");
            }
            finally // This will run regardless if there's an error caught or not (success)
            {
                Console.WriteLine("Thanks for visiting!");
            }

            Console.ReadKey();
        }
    }
}