using System;

namespace ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conditional Operator (?)
            //   - Used in conditional assignment if a condition is true/false

            // (condition) ? x : y

            double temperature = 20;
            String message;

            message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";

            Console.WriteLine(message);


            Console.WriteLine();

            // this is the if else way, which takes longer

            if (temperature >= 15)
            {
                message = "It's warm outside!";
            }
            else
            {
                message = "It's cold outside!";
            }
            Console.WriteLine(message);

            // or you could also do it all in one line (messy tho)

            Console.WriteLine();
            Console.WriteLine((temperature >= 15) ? "It's warm outside!" : "It's cold outside!");

            Console.ReadKey();
        }
    }
}