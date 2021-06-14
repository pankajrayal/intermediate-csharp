using System;

namespace D02_ConstructionAndInheritance
{
    public class Car: Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car: Parameter less constructor called");
        }
        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized. {0}", registrationNumber);
        }

       
    }
}
