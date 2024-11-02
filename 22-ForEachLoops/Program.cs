using System;

namespace ForEachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // foreach Loop
            // - A simpler way to iterate over an array
            // - but it's less flexible

            String[] cars = { "BMW", "Mustang", "Corvette" };

            // It's less flexible though
            // With for loops, we can customize the iteration, like i++, i+=2, or i--, etc.
            // foreach only goes forwards

            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}