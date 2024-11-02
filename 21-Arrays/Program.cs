using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            // - A variable that can store multiple values.
            // - Fixed size.

            String[] cars = { "BMW", "Mustang", "Corvette" };

            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            // Console.WriteLine(cars[3]); // System.IndexOutOfRangeException

            Console.WriteLine();

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            // Arrays are fixed size.
            // If you want to add later, you have to declare how big the array is, leaving
            // extra space for you to later add more to it.

            String[] otherCars = new string[4];

            otherCars[0] = "Tesla";
            otherCars[1] = "Rivian";
            otherCars[2] = "Toyota";
            otherCars[3] = "Honda";

            Console.WriteLine();

            for (int i = 0; i < otherCars.Length; i++)
            {
                Console.WriteLine(otherCars[i]);
            }

            Console.ReadKey();
        }
    }
}