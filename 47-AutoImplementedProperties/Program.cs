using System;

namespace AutoImplementedProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Auto-Implemented Properties

            //      = Shortcut when no additional logic is required in the property
            //      = You do not have to define a field for a property,
            //        you only have to write 'get' and/or 'set'; inside the proeprty

            Car car = new Car("Porsche");

            Console.WriteLine(car.Model);
            Console.ReadKey();
        }
    }

    class Car
    {
        public String Model { get; set; } // This works as the below example

        // This is the long way of setting up getters and setters (if this is all you're doing)

        //String model;

        //public String Model
        //{
        //    get { return model;  }
        //    set { model = value; }
        //}

        public Car(String model)
        {
            this.Model = model;
        }
    }
}