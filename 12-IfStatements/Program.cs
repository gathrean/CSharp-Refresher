using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // If Statements = a basic form of decision making


            // Example 1

            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 100)
            {
                Console.WriteLine("You are way too old to sign up.");
            } 
            else if (age >= 18)
            {
                Console.WriteLine("You are now signed up!");
            }
            else if (age < 0)
            {
                Console.WriteLine("You haven't been born yet...");
            }
            else
            {
                Console.WriteLine("You must be 18+ to sign up!");
            }

            // Example 2

            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();

            if (name != "") // we use == and != here to compare, not assign name with ""
            {
                Console.WriteLine("Hello " + name);
            }
            else
            {
                Console.WriteLine("You did not enter your name!");
            }



            Console.ReadKey();
        }
    }
}