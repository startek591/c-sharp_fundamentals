
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
        }
    }
}