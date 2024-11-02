using System;

namespace AbstractClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract Classes
            //      "abstract" is a keyword 
            //      it is a modifier that indicates missing components or incomplete implementation.
            //
            //      you can't make an instance or instatiate an abstract class

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            //Vehicle vehicle = new Vehicle();

            Console.ReadKey();
        }
    }

    abstract class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }

    class Car : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 500;
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 100;
    }
}