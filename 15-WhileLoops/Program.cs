using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // While Loops
            // - They repeat some code INFINITE amount of times, as long as some condition is true.

            string name = "";

            while (name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name + "!");

            Console.ReadKey();
        }
    }
}