using System;

namespace MovableObjectsApp
{
    public interface IMovable
    {
        void Move();
    }

    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfaces");

            Car myCar = new Car();
            Console.Write("My car: ");
            myCar.Move();

            Bicycle myBicycle = new Bicycle();
            Console.Write("My bicycle: ");
            myBicycle.Move();

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}