using System;

namespace GettersAndSettersExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Getters & Setters
            //                  = Adds security to fields by encapsulation
            //                  = They're accessors found within properties

            //          - properties = combine aspects of both fields and methods (share name with a field)
            //          - get accessor = used to return the property value
            //          - set accessor = used to assign a new value
            //          - value keyword = defines the value being assigned by the set (parameter)

            Car car = new Car(400);

            car.Speed = 1000000000; // The set made it so anything above 500 will just make it 500

            Console.WriteLine(car.speed);

            Console.ReadKey();
        }
    }

    class Car
    {
        public int speed;

        public Car(int speed)
        {
            Speed = speed;
        }

        public int Speed
        {
            get { return speed; }   // Read
            set                     // Writeable
            {
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }
}