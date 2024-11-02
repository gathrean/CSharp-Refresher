using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // For Loops
            // - Repeats some code a FINITE amount of times


            // NOTES:
            // - the i in the for loop parenthesis is short for 'index'
            // - the format here is (starting point; condition; counter)
            // - we use i++ instead of i += 1 because it's shorter

            for (int i = 1; i <= 10; i++)
            {
                // This counts 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
                Console.WriteLine(i);
            }

            Console.WriteLine();
            for (int i = 1; i <= 10; i += 2)
            {
                // This counts 1, 3, 5, 7, 9
                Console.WriteLine(i);
            }

            // Counting Down

            Console.WriteLine();
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("HAPPY NEW YEAR!!!!");

            Console.ReadKey();
        }
    }
}