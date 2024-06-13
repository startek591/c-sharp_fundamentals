
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

            // Use a constructor to create a Rectangle
            Rectangle rect2 = new Rectangle(100, 40);

            // If you assign one Reactangle to another
            // you are setting the values and not
            // creating a reference
            rect2 = rect1;
            rect1.length = 33;

            Console.WriteLine("rect2.length: {0}", rect2.length);

            // Object Oriented programming
            // A class models real world objects by
            // definining their attributes (fields) and 
            // capabilities (methods)
            // Then unlike with structs you can
            // inherit from a class and create more
            // specific subclass types

            // Add a class Project -> Add Class

            // Create an Animal object
            // You could also assign values like
            // fox.name = "Red"
            Animal fox = new Animal()
            {
                name = "Read",
                sound = "Raaaw"
            };

            // Call the static method
            Console.WriteLine("# of Animals {0}", Animal.GetNumAnimals());

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