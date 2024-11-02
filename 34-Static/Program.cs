using System;

namespace StaticExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // static
            //      A modifier to declare a static member, which belongs to the class itself
            //      rather than to any specific object

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lambo");

            // Using 'static' keyword, these no longer work:
            //Console.WriteLine(car1.numberOfCars);
            //Console.WriteLine(car2.numberOfCars);

            // You have to call the Class instead
            Console.WriteLine(Car.numberOfCars);

            // If it wasn't static, it'd be like car1 and car2 have their own numberOfCars field
            // which would mean it'd print "1" for both of them

            // Making them static makes it so it's owned by the Class

            // Making a class static would mean you couldn't make objects with it
            // So this example it's not static

            Car.StartRace();

            Console.ReadKey();
        }
    }

    class Car
    {
        String model;
        public static int numberOfCars;

        public Car(String model)
        {
            this.model = model;
            numberOfCars++;
        }

        // We can also make a method 'static'
        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }
}