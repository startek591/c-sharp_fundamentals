using System;
using System.Text;
using System.Globalization;


namespace HelloWorld
{
    public class Program
    {
        // Execution begins with the main function
        // static means this function can run without
        // creating an object
        // void means that this function doesn't return a value
        // args represent data that can be passed to our program
        // from the command line as an array of strings
        static void Main(string[] args)
        {
            // Prints Hello World on the console
            Console.WriteLine("Hello World");

            // Console Methods
            // Change the text color in the console
            Console.ForegroundColor = ConsoleColor.Black;

            // Change the background color
            Console.BackgroundColor = ConsoleColor.White;

            // Set background for whole console
            Console.Clear();

            // Outputs text without a newline
            Console.Write("What is your name?");

            // Stores data entered by user in name
            string name = Console.ReadLine();

            // Outputs Hello + value stored in name
            Console.WriteLine($"Hello {name}");

            // Variables
            // Used to store different types of data
            // Bools store true or false
            bool canIVote = true;

            // INTEGERS
            // Integers are 32-bits signed integers
            Console.WriteLine("Biggest Integer: {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer: {0}", int.MinValue);

            // LONGS
            // Longs are 64-bit signed integers
            Console.WriteLine("Biggest Long: {0}", long.MaxValue);
            Console.WriteLine("Smallest Long: {0}", long.MinValue);

            // DECIMALS
            // Decimals store 128-bit decimal values
            // It is accurate to 28 digits
            decimal decPiVal = 3.1415926535897932384626433832M;
            decimal decBigNum = 3.00000000000000000000000000011M;
            Console.WriteLine("DEC: PI + bigNum = {0}", decPiVal + decBigNum);

            // DOUBLES
            // Doubles are 64-bit float types
            Console.WriteLine("Biggest Double: {0}", double.MaxValue);

            // It is precise to 14 digits
            double dblPiVal = 3.14159265358979;
            double dblBigNum = 3.00000000000002;
            Console.WriteLine("DBL: PI + bigNum = {0}", dblPiVal + dblBigNum);

            // FLOATS
            // Floats are 32-bit float types
            Console.WriteLine("Biggest Float: {0}", float.MaxValue.ToString("#"));

            // It is precise to 6 digits
            float fltPiVal = 3.141592F;
            float fltBigNum = 3.000002F;
            Console.WriteLine("FLT: PT + bigNum = {0}", fltPiVal + fltBigNum);


            // Data Type Conversion
            // You can convert from string to other types with Parse
            bool boolFromStr = bool.Parse("True");
            int intFromStr = int.Parse("100");
            double dblFromStr = double.Parse("1.234");

            // Convert double into a string
            string strVal = dblFromStr.ToString();

            // Get the new data type
            Console.WriteLine($"Data type: {strVal.GetType()}");

            // Cast integer into long (Implicit Conversion)
            // smaller size type to a larger size
            int intNum = 10;
            long longNum = intNum;

            // Format output for currency
            Console.WriteLine("Currency: {0:c}", 23.455);

            // Pad with zeroes
            Console.WriteLine("Pad with 0s: {0:d4}", 23);

            // Define decimals
            Console.WriteLine("3 Decimals: {0:f3}", 23.4555);

            // Add commas and decimals
            Console.WriteLine("Commas: {0:n4}", 2300);

            // Strings
            // Strings store a series of characters
            string randString = "This is a string";

            // Get number of characters in string
            Console.WriteLine("String Length: {0}", randString.Length);

            // Check if string contains other string
            Console.WriteLine("String Contains is: {0}", randString.IndexOf("is"));

            // Remove number of characters starting at an index
            Console.WriteLine("Insert String: {0}", randString.Replace("string", "sentence"));

            // Compare strings and ignore case
            // < 0 : str1 preceeds str2
            // = : Zero
            // > 0 : str2 preceeds str1
            Console.WriteLine("Compare A to B: {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));

            // Check if strings are equal
            Console.WriteLine("A = a: {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));

            // Add padding left
            Console.WriteLine("Pad Left: {0}", randString.PadLeft(20, '.'));

            // Add padding right
            Console.WriteLine("Pad Right: {0}", randString.PadRight(20, '.'));

            // Trim whitespace
            Console.WriteLine("Trim: {0}", randString.Trim());

            // Make uppercase
            Console.WriteLine("Uppercase: {0}", randString.ToUpper());

            // Make lowercase
            Console.WriteLine("Lowercase: {0}", randString.ToLower());

            // Use Format to create strings
            string newString = String.Format("{0} saw a {1} {2} in the {3}", "Paul", "rabbit", "eating", "field");

            // You can add newlines with \n and join strings with +
            Console.Write(newString + "\n");

            // Other escape characters
            // \' \" \\ \t \a

            // Verbatim strings ignore escape characters
            Console.WriteLine(@"Exactly What I Typed\n");






        }
    }

}