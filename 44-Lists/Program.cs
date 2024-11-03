using System;
using System.Collections.Generic; // This is needed for Lists

namespace ListsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lists
            //      = data structure that represents a list of objects that can be accessed by index.
            //      = Similar to an Array, but can dynamically increase/decrease in size
            //      = using System.Collections.Generic;


            // Problem:
            // This is a String array.
            // It's fixed in size so we will have problems when trying to add food[3] and so forth

            String[] food = new string[3];

            food[0] = "pizza";
            food[1] = "hamburger";
            food[2] = "hotdog";

            foreach (String item in food)
            {
                Console.WriteLine(item);
            }

            // So we will use Lists

            List<String> foods = new List<String>();

            foods.Add("pizza");
            foods.Add("hamburger");
            foods.Add("hotdog");
            foods.Add("fries"); // then we can add more food

            Console.WriteLine();
            foreach (String item in foods)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(foods[0]); // accessing items in a List is same as you would in an Array


            // List's Remove() method

            foods.Remove("fries");

            Console.WriteLine();
            foreach (String item in foods)
            {
                Console.WriteLine(item);
            }

            // List's Insert() method

            foods.Insert(0, "sushi");

            Console.WriteLine();
            foreach (String item in foods)
            {
                Console.WriteLine(item);
            }

            // Other
            Console.WriteLine();
            Console.WriteLine(foods.Count);                 // How many are in the List
            Console.WriteLine(foods.IndexOf("pizza"));      // Find the index of pizza in list
            Console.WriteLine(foods.LastIndexOf("fries"));  // Find last index of given item
            Console.WriteLine(foods.Contains("pizza"));     // Returns "true" if List has pizza

            foods.Sort();               // Sorts foods list in alphabetical order
            foods.Reverse();            // Sorts foods list in reverse alphabetical order
            //foods.Clear();              // Clears list

            String[] foodArray = foods.ToArray();           // Converts foods List into a food Array

            Console.ReadKey();
        }
    }
}