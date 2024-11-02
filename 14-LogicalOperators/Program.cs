using System;
using System.Threading.Channels;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Logical Operators
            // && (AND)
            // || (OR)
            // ! (NOT)
            //
            // - They can be used to check if more than 1 condition is true / false.

            Console.WriteLine("What's the temperature outside: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if(temp >= 10 && temp <= 25) // Both of these conditions must be true to execute this if statement.
            {
                Console.WriteLine("It's warm outside!");
            }
            else if (temp <= -50 || temp >= 50) // Only of these conditions must be true.
            {
                Console.WriteLine("DO NOT GO OUTSIDE!!!!");
            }

            Console.ReadKey();
        }
    }
}