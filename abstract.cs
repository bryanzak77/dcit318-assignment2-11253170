using System;
using System.Reflection.Metadata.Ecma335;

namespace ShapeCalculatorApp
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Circle : Shape
    {
        public double Radius { get ; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Classes and Methods");

            Circle circle = new Circle(5);
            Console.WriteLine($"Area of Circle with radius {circle.Radius} : {circle.GetArea():F2}");

            Rectangle rectangle = new Rectangle(4, 6);
            Console.WriteLine($"Area of a rectangle with width {rectangle.Width} and height {rectangle.Height}: {rectangle.GetArea():F2}");

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}