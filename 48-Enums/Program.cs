using System;
using System.Reflection.Metadata;

namespace EnumsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enums

            //          - Special "class" that contains a set of named integer constants.
            //          - Use enums when you have values that you know will not change,
            //          - To get the integer value from an item, you must explicitly convert to an int

            //          name = integer

            Console.WriteLine(Planets.Pluto + " is a planet");                          // Pluto is a planet, kinda works like ToString() here
            Console.WriteLine(Planets.Mercury + " is planet #" + (int)Planets.Mercury); // Mercury is plant #0
            Console.WriteLine(Planets.Pluto + " is planet #" + (int)Planets.Pluto);     // Pluto is planet #9

            Console.WriteLine();

            String name = PlanetRadius.Earth.ToString();
            int radius = (int)PlanetRadius.Earth;
            double volume = Volume(PlanetRadius.Earth);

            Console.WriteLine("planet: " + name);
            Console.WriteLine("radius: " + radius + " km");
            Console.WriteLine("volume: " + volume + " km^3");

            Console.ReadKey();
        }

        public static double Volume(PlanetRadius radius)
        {
            double volume = (4.0 / 3) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }
    }

    enum Planets
    {
        Mercury = 1,    // 0 index, if not specified
        Venus = 2,      // 1
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Nepture = 8,
        Pluto = 9
    }

    enum PlanetRadius // in km
    {
        Mercury = 2439, // variable constants
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Nepture = 24622,
        Pluto = 1188
    }
}