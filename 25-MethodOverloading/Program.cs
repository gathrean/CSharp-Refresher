using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method Overloading
            // - Methods can share the same name, but different parameters
            //
            //    name + parameters = signature
            //
            // - Methods must have a unique signature

            double total1 = Multiply(2, 3);

            Console.WriteLine(total1);

            double total2 = Multiply(2, 3, 4);

            Console.WriteLine(total2);

            Console.ReadKey();
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}