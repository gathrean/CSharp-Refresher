using System;
using System.ComponentModel.Design;

namespace ParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            // params Keyword
            //  - A method parameter that takes avariable number of arguments
            //  - The parameter type must be a single - dimensional array

            //  - params keyword allows us to have a single method accept a varying amount of arguments
            // So method overloading isn't always necessary

            double total = CheckOut(3.99, 5.75, 15, 1.00, 10.25);

            Console.WriteLine(total);

            Console.ReadKey();
        }

        static double CheckOut(params double[] prices)
        {
            double total = 0;

            foreach(double price in prices)
            {
                total += price;
            }

            return total;
        }
    }
}