using System;

namespace ConstructorsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructor
            //      A special method in a Class
            //      Same name as the Class
            //      Can be used to assign arguments to fields when creating an Object

            Car car1 = new Car("Ford", "Mustang", 2022, "red");
            Car car2 = new Car("Chevy", "Corvette", 2021, "blue");

            car1.Drive();
            car2.Drive();

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

        public void Drive()
        {
            Console.WriteLine("You drive the " + color + " " + year + " " + make + " " + model);
        }
    }
}