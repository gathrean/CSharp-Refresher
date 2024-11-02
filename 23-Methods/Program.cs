using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method
            // - Performs a section of code, whenever it's called "invoked"
            // - The benefit: Lets us reuse code without writing it multiple times

            String name = "Ean";
            int age = 23;

            // ARGUMENTS are passed into methods
            // Methods cannot access variables in other methods
            //   unless it is passed into it.

            singHappyBirthday(name, age);
            singHappyBirthday(name, age);
            singHappyBirthday(name, age);

            // We need a matching set of ARGUMENTS and PARAMETERS

            // Arguments and Parameters don't need to have the same name!

            Console.ReadKey();
        }

        static void singHappyBirthday(String birthdayBoy, int yearsOld)
        {
            // PARAMETERS are what a method needs to receive to be invoked

            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear " + birthdayBoy);
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("You are " + yearsOld + " years old!");
            Console.WriteLine();
        }
    }
}