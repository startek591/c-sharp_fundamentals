﻿// We found an Generic Collections, Generic Methods, 
// Generic Structs and more on Delegates

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generic collections are type safe
            // and provide performance benefits

            // You define the data type when defining
            // the generic. This is a dynamically
            // resizing collection.
            List<Animal> animalList = new List<Animal>();

            // You can also create a list of standard
            // types like int
            List<int> numList = new List<int>();

            // Add a int
            numList.Add(24);

            // Add Animals
            animalList.Add(new Animal() { Name = "Doug" });
            animalList.Add(new Animal() { Name = "Paul" });
            animalList.Add(new Animal() { Name = "Sally" });

            // Insert in index 1
            animalList.Insert(1, new Animal() { Name = "Steve" });

            // Get numbrer of Animals
            Console.WriteLine("Num of Animals : {0}", animalList.Count());

            // Cycle through Animals
            foreach (Animal a in animalList)
            {
                Console.WriteLine(a.Name);
            }

            // You can also use Stack<T>, Queue<T>,
            // Dictionary<TKey, TValue> like I covered
            // previously

            // Generic methods
            // you can use the parameter <int>
            // if it can be inferred from the parameters
            // passed (Can't do this if there are no parameters)

            int x = 5, y = 4;
            Animal.GetSum<int>(ref x, ref y);

            // It works for strings as well
            string strX = "5", strY = "4";
            Animal.GetSum(ref strX, ref strY);

            // Use the generic struct
            Rectangle<int> rect1 = new Rectangle<int>(20, 50);
            Console.WriteLine(rect1.GetArea());

            // Delegates allow you to reference methods
            // inside a deleage object. The delegate 
            // object can then be passed to other 
            // methods that can call the methods assigned
            // to the delegate. It can also stack methods
            // that are called in the specified order

            // Create delegate objects
            Arithemtic add, sub, addSub;

            // Assign just the Add method
            add = new Arithemtic(Add);

            // Assign just the Subtract method
            sub = new Arithemtic(Subtract);

            // Assign Add and Sub
            addSub = add + sub;

            // Print out results
            Console.WriteLine($"Add {6} & {10}");
            add(6, 10);

            // Call both methods
            Console.WriteLine($"Add & Substract {10} & {4}");
            addSub(10, 4);
        }

        // You can also create generic structs
        // and classes in the same way
        public struct Rectangle<T>
        {
            // Generic fields
            private T width;
            private T length;

            public T Width
            {
                get { return width; }
                set { width = value; }
            }
            public T Length
            {
                get { return length; }
                set { length = value; }
            }

            public Rectangle(T w, T l)
            {
                width = w;
                length = l;
            }

            public string GetArea()
            {
                double dblWidth = Convert.ToDouble(Width);
                double dblLength = Convert.ToDouble(Length);
                return string.Format($"{Width} * {Length} = {dblWidth * dblLength}");
            }
        }

        // Declare a delegate type that performs
        // arithmetic. It defines the return type
        // and the types for attributes
        public delegate void Arithemtic(double num1, double num2);

        // Methods that will be assigned to the delegate
        public static void Add(double num1, double num2)
        {
            Console.WriteLine($"{num1} +  {num2} = {num1 + num2}");
        }

        public static void Subtract(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }
    }
}
