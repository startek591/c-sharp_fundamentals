// Import namespace calleds system that has many classes
// useful functions (Without it we'd have to type
// System.Console.Write)

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

            // ---- CONSOLE METHODS
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

            // ---- Variables
            // Used to store different types of data

            // Bools store true or false
            bool canIVote = true;

            // INTEGERS
            // Integers are 32-bit signed integers
            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer: {0}", int.MinValue);

            // LONGS
            // Longs are 64-bits signed integers
            Console.WriteLine("Biggest Integer : {0}", long.MaxValue);
            Console.WriteLine("Smallest Long : {0}", long.MinValue);

            // DECIMALS
            // Decimals store 128-bit precise decimal values
            // It is accurate to 28 digits
            decimal decPiVal = 3.1415926535897932384626433832M;
            decimal decBigNum = 3.00000000000000000000000000011M;
            Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);

            Console.WriteLine("Biggest Decimal : {0}", decimal.MaxValue);

            // DOUBLES
            // Doubles are 64-bit float types
            Console.WriteLine("Biggest Double : {0}", double.MaxValue);

            // It is precise to 14 digits
            double dblPiVal = 3.14159265358979;
            double dblBigNum = 3.00000000000002;
            Console.WriteLine("DBL : PI + bigNum = {0}", dblPiVal + dblBigNum);

            // FLOATS
            // Floats are 32-bit float types
            Console.WriteLine("Biggest Float : {0}", float.MaxValue.ToString("#"));

            // It is precise to 6 digits
            float fltPiVal = 3.141592F;
            float fltBigNum = 3.000002F;
            Console.WriteLine("FLT : PI + bigNum = {0}", fltPiVal + fltBigNum);

            // Other Data Types
            // byte : 8-bit unsigned int 0 to 255
            // char : 16-bit unicode character
            // sbyte : 8-bit signed int 128 to 127
            // short : 16-bit signed int -32,768 to 32,767
            // uint : 32-bit unsigned int 0 to 4,294,967,295
            // ulong : 64-bit unsigned int 0 to 18,446,744,073,709,551,615
            // ushort : 16-bit unsigned int 0 to 65,535

            // ---- DATA TYPE CONVERSION
            // You can convert from string to other types with Parse
            bool boolFromStr = bool.Parse("True");
            int intFromStr = int.Parse("100");
            double dblFromStr = double.Parse("1.234");

            // Convert double into a string
            string strVal = dblFromStr.ToString();

            // Get the new data type
            Console.WriteLine($"Data type : {strVal.GetType()}");

            // Cast double into integer (Explicit Conversion) 
            // Put the data type to convert into between ()
            double dblNum = 12.345;
            Console.WriteLine($"Ingeter : {(int)dblNum}");

            // Cast integer into long (Implicit Conversion)
            // smaller size type to a larger size
            int intNum = 10;
            long longNum = intNum;
        }
    }
}

