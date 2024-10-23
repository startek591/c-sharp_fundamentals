using ConsoleApp2;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Reactangle
            Reactangle rect1;

            // Add values to it and run the Area method
            rect1.length = 200;
            rect1.width = 50;
            Console.WriteLine("Area of rect1 : {0}", rect1.Area());

            // Use a constructor to create a Reactangle
            Reactangle rect2 = new Reactangle(100, 40);

            // If you assign one Rectangle to another
            // you are setting the values and not
            // creating a reference
            rect2 = rect1;
            rect1.length = 33;

            Console.WriteLine("rect2.length : {0}", rect2.length);

            // ---- Object Oriented  programming
            // A class models real world objects by
            // defining their attributes (fields) and 
            // capabilities (methods)
            // Then unlike with structs you can
            // inherit from a class and create more
            // specific subclass types

            // Add a class Project -> Add Class

            // Create an Animal object
            // You could also assign values liike
            // fox.name = "Red"
            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raaaw"
            };

            Console.WriteLine("# of Animal {0}", Animal.GetNumAnimals());

            // You can also create static utility
            // classes Project -> Class
            Console.WriteLine("Area of Rectangle : {0}", ShapeMath.GetArea("rectangle", 5, 6));
        }
        // ---- STRUCTS 
        // A struct is a user defined type that 
        // contain multiple fields and methods
        struct Reactangle
        {
            public double length;
            public double width;

            // You can create a constructor method
            // that will set the values for fields
            public Reactangle(double l = 1, double w = 1)
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