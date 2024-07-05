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
            Console.WriteLine("Area of rect1 : {0}", rect1.Area());

            // Use a constructor to create a Rectangle
            Rectangle rect2 = new Rectangle(100, 40);

            // If you assign one Rectangle to another
            // you are setting the values and not
            // creating a reference
            rect2 = rect1;
            rect1.length = 33;
            Console.WriteLine("rect2.length : {0}", rect2.length);

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