using System;

namespace AnimalSoundsApp
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Demonstrating Method Overriding ---");

            Animal genericAnimal = new Animal();
            Console.Write("Generic Animal says: ");
            genericAnimal.MakeSound();

            Dog myDog = new Dog();
            Console.Write("My Dog says: ");
            myDog.MakeSound();

            Cat myCat = new Cat();
            Console.Write("My Cat says: ");
            myCat.MakeSound();

            Console.WriteLine("\n--- Demonstrating Polymorphism ---");
            Animal polymorphicDog = new Dog();
            Console.Write("Polymorphic Dog says: ");
            polymorphicDog.MakeSound();

            Animal polymorphicCat = new Cat();
            Console.Write("Polymorphic Cat says: ");
            polymorphicCat.MakeSound();

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}