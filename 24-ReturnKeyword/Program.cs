using System;

namespace ReturnKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            // Return
            // - returns data back to the place where a method is invoked

            double x;
            double y;
            double result;

            Console.Write("Enter in number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter in number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);

            Console.Write("Result: " + result);

            Console.ReadKey();
        }

        static double Multiply(double x, double y)
        {
            double z = x * y;
            return z;
        }
    }
}