using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape 
    {
        public abstract double calculateArea();
        public abstract double calculatePerimeter();
    }

    class Rectangle : Shape
    {
        public double length { get; set; }
        public double width { get; set; }

        public override double calculateArea()
        {
            return length * width;
        }
        public override double calculatePerimeter()
        {
            return 2 * (length + width);
        }
    }
    class Circle : Shape
    {
        static readonly double PI = 3.14;
        public double radius { get; set; }

        public override double calculateArea()
        {
            return PI * radius * radius;
        }
        public override double calculatePerimeter()
        {
            return 2 * PI * radius;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Circle c1 = new Circle();
            r1.length = 10;
            r1.width = 2;
            Console.WriteLine("Perimeterof the rectangle: " + r1.calculatePerimeter());
            Console.WriteLine("Areaof the rectangle: " + r1.calculateArea());
            c1.radius = 10;
            Console.WriteLine("Perimeter of the circle: " + c1.calculatePerimeter());
            Console.WriteLine("Area of the circle: " + c1.calculateArea());
            Console.ReadKey(); 
        }
    }
}
