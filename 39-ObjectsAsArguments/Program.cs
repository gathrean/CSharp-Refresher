using System;

namespace ObjectsAsArgumentsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mustang", "red");

            Console.WriteLine("Original Car:" + car1.color + " " + car1.model);


            // Using the ChangeColor() method to change a field of a Car object

            ChangeColor(car1, "silver");

            Console.WriteLine("After changing color:" + car1.color + " " + car1.model);



            // Using the Copy() method to copy an existing car's fields to another

            Car car2 = Copy(car1);

            Console.WriteLine("The copied car:" + car2.color + " " + car2.model);

            Console.ReadKey();
        }

        // Here we are passing an Object as an argument in this method
        public static void ChangeColor(Car car, String color)
        {
            car.color = color;
        }

        // Another 
        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }
    }

    class Car
    {
        public String model;
        public String color;

        public Car(String model, String color)
        {
            this.model = model;
            this.color = color;
        }
    }
}