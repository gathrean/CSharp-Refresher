using System;

namespace PolymorhismExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism
            //      It's a greek that means "to have many forms"
            //      Objects can be identified by more than one type
            //      Ex. a Dog is also: Canine, Animal, Organism

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            //Car[] vehilces = { car, bicycle, boat }; 
            // This wouldn't work because the array can only contain Car objects

            // We solve this by using Polymorphism!
            // We start by looking at what they all have in common
            // - Well, they all identify as Vehicle because they all inherit from the Vehicle class

 
            Vehicle[] vehicles = { car, bicycle, boat };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }

            Console.ReadKey();
        }
    }

    class Vehicle
    {
        public virtual void Go()
        {
            
        }
    }

    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving!");
        }
    }

    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving!");
        }
    }

    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving!");
        }
    }
}