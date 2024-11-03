using System;

namespace GeneticsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generics

            //      = "Not specific to a particular data type"
            //      = add <T> to: classes, methods, fields, etc.
            //      = allows for code reusability for different data types

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            String[] stringArray = { "1", "2", "3" };

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);


            Console.ReadKey();
        }

        public static void displayElements<Thing>(Thing[] array) // we can use <T> or <Thing> or anything, doesn't matter
        {
            foreach (Thing item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }


        // Sure, we could overload the displayElements method, but we can just use Generics

        //public static void displayElements(int[] array)
        //{
        //    foreach(int item in array)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();
        //}

        //public static void displayElements(double[] array)
        //{
        //    foreach (double item in array)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();
        //}

        //public static void displayElements(String[] array)
        //{
        //    foreach (String item in array)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();
        //}
    }
}