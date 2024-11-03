using System;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interdace
            //      Defines a "contract" that all the classes inheriting from should follow

            //      An interface declares "what a class should have"
            //      An inheriting class defiens "how it should do it"

            //      Benefit = security + multiple inheritance + "plug-and-play"


            // Class that implements the IPrey interface
            Rabbit rabbit = new Rabbit();

            rabbit.Flee();


            // Class that implements the IPredator interface
            Hawk hawk = new Hawk();

            hawk.Hunt();


            // Class that implements both the IPrey and IPredator interface
            Fish fish = new Fish();

            fish.Flee();
            fish.Hunt();

            Console.ReadKey();
        }

        interface IPrey
        {
            void Flee();
        }

        interface IPredator
        {
            void Hunt();
        }

        class Rabbit : IPrey
        {
            public void Flee()
            {
                Console.WriteLine("The rabbit runs away!");
            }
        }

        class Hawk : IPredator
        {
            public void Hunt()
            {
                Console.WriteLine("The hawk is searching for food!");
            }
        }

        class Fish : IPrey, IPredator
        {
            public void Flee()
            {
                Console.WriteLine("The fish swims away!");
            }
            
            public void Hunt()
            {
                Console.WriteLine("The fish is searching for smaller fish!");
            }
        }
    }
}