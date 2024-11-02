using System;

namespace ToStringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToString()
            //      Converts an object to its String representation so that it is suitable for display

            Car car = new Car("Chevy", "Corvette", 2022, "blue");

            Console.WriteLine(car.ToString());

            Console.ReadKey();
        }
    }

    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        // overriding ToString method
        public override String ToString()
        {
            return "This is a " + make + " " + model;
        }
    }
}