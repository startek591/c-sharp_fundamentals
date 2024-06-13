
using ConsoleApp2;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Rectangle
            Rectangle rect1;

            // Add values to it and run the Area method
            rect1.length = 200;
            rect1.width = 50;
            Console.WriteLine("Area of rect1: {0}", rect1.Area());

        }

        // Structs
        // A struct is a user defined type that
        // contains multiple fields and methods
        struct Rectangle
        {
            public double length;

            public double width;

            // You can create a constructor method 
            // that will set the values for fields
            public Rectangle(double l = 1, double w = 1)
            {
                length = l;
                width = w;
            }

            public double Area()
            {
                return length * width;
            }
        }
    }
}