using System;

namespace ObjectsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object
            //      An instance of a class
            //      A class can be used as a blueprint to create objects (OOP)
            //      Objects can have fields & methods (Characteristics & actions)

            // Think of it as:
            //      Fields are what an Object has
            //      Methods are what an Object does

            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Rick";
            human1.age = 65;

            human1.name = "Morty";
            human1.age = 16;

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
        }
    }

    class Human
    {
        // Fields of a Class
        public String name;
        public int age;

        // Methods of a Class
        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
}