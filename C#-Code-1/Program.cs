
/*
    Import namespace called system that has many classes
    and useful functions (Without it we'd have to type System.Console.Write)
*/

using System;
using System.Globalization;
using System.Text;

// Defines our namespace is HelloWorld
namespace HelloWorld
{
    // Our class name is Program
    public class Program
    {
        // Execution begins in the main function
        // static means this function can run without
        // creating an object
        // void means that this function doesn't return a value
        // args represent data that can be passed to our program
        // from the command line as an array of strings
        static void Main(string[] args)
        {
            // Prints Hello World on the console
            Console.WriteLine("Hello World!");

            // ----- CONSOLE METHODS -----
            // Change the text color in the console
            Console.ForegroundColor = ConsoleColor.Black;

            // Change background color
            Console.BackgroundColor = ConsoleColor.White;

            // Set background for whole console
            Console.Clear();

            // Outputs text without a newline
            Console.Write("What is your name?");

            // Stores data entered by user in name
            string name = Console.ReadLine();

            // Outputs Hello + value stored in name
            Console.WriteLine($"Hello {name}");
        }
    }
}