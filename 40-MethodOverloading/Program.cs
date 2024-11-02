using System;

namespace MethodOverloadingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method Overriding
            //      Provides a new version of a method inherited from a parent class
            //      inherited method must be:
            //          abstract, virtual, or already overriden
            //
            //      Used with ToString()
            //      Polymorphism

            Dog dog = new Dog();
            Cat cat = new Cat();

            // Before overriding
            //dog.Speak(); // "The animal goes *brrr*"
            //cat.Speak(); // "The animal goes *brrr*"

            // After overriding
            dog.Speak();
            cat.Speak();


            Console.ReadKey();
        }
    }
    class Animal
    {
        // Needs 'virtual' keyword for it to be overridable
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brrr*");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *woof*");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat goes *meow*");
        }
    }
}