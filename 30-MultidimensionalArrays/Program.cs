using System;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multidimensional Arrays
            //      An array of arrays

            String[] ford = { "Mustang", "F-150", "Explorer" };
            String[] chevy = { "Corvette", "Camaro", "Silverado"};
            String[] toyota = { "Corolla", "Camry", "Rav4" };

            String[,] parkingLot = {    { "Mustang", "F-150", "Explorer" },
                                        { "Corvette", "Camaro", "Silverado"},
                                        { "Corolla", "Camry", "Rav4" }
                                    };

            parkingLot[0, 2] = "Fusion";  // Changing the Explorer into Fusion
            parkingLot[2, 0] = "Tacoma"; // Changes the Corolla to Tacoma

            //foreach(String car in parkingLot)
            //{
            //    Console.WriteLine(car);
            //}


            // Shows as a grid
            for(int i = 0; i< parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i, j] + "   ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}