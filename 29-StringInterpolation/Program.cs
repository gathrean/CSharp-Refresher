using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Interpolation
            //      Allows us to insert variables into a String literal
            //      Precede a string literal with $
            //      {} are placeholders

            String firstName = "John";
            String lastName = "Doe";
            int age = 21;

            // Concatenation way:
            Console.WriteLine("Hello " + firstName + " " + lastName + ".");
            Console.WriteLine("You are " + age + " years old.");

            // This is String Interpolation:
            Console.WriteLine($"Hello {firstName} {lastName}.");
            Console.WriteLine($"You are {age} years old");

            // This one allocates space
            Console.WriteLine($"You are {age, 10} years old");


            Console.ReadKey();
        }
    }
}