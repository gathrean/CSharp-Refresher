using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // While Loops
            // - They repeat some code as long as some condition is true.

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            while (name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name + "!);

            Console.ReadKey();
        }
    }
}