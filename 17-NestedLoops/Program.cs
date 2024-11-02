﻿namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nested Loops
            // - A loop inside another loop
            // - The uses vary
            // - they are used a lot in sorting algorithms

            // Example - Drawing Rectangle

            Console.Write("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("What symbol: ");
            String symbol = Console.ReadLine();

            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}