using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Overloaded Constructors
            //      Technique to create multiple constructors,
            //      with a different set of parameters.
            //      
            //      name + parameters = signature

            Pizza pizza1 = new Pizza("stuffed crust");
            Pizza pizza2 = new Pizza("stuffed crust", "red sauce");
            Pizza pizza3 = new Pizza("stuffed crust", "red sauce", "mozzarella");
            Pizza pizza4 = new Pizza("stuffed crust", "red sauce", "mozzarella", "pepperoni");

            Console.ReadKey();
        }
    }

    class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping;

        public Pizza(String bread)
        {
            this.bread = bread;
        }

        public Pizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }

        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }

        public Pizza(String bread, String sauce, String cheese, String topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
    }
}