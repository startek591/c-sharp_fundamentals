
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

            // ----- VARIABLES -----
            // Used to store different types of data

            // Bools store true or false
            bool canIVote = true;

            // INTEGERS
            // Integers are 32-bit signed integers
            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);

            // LONGS
            // Longs are 64-bit signed integers
            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);

            // DECIMALS
            // Decimals store 128-bit precise decimal values
            // It is accurate to 28 digits
            decimal decPiVal = 3.141592653589792384626433832M;
            decimal decBigNum = 3.0000000000000000000000000011M;
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
            // Floats are 32-bits float types
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
            // unit : 32-bit unsigned int 0 to 4,294,967,295
            // ulong : 64-bit unsigned int 0 to 18,446,744,0743,709,551,615
            // ushort :  16-bit unsigned int 0 to 65,535

            // ------ DATA TYPE CONVERSION -------

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
            Console.WriteLine($"Integer : {(int)dblNum}");

            // Cast integer into long (Implicit Conversion)
            // smaller size type to a larger size
            int intNum = 10;
            long longNum = intNum;

            // ------ FORMATTING OUTPUT ------

            // Format output for currency
            Console.WriteLine("Currency : {0:c}", 23.455);

            // Pad with zeroes
            Console.WriteLine("Pad with 0s : {0:d4} ", 23);

            // Define decimals
            Console.WriteLine("3 Decimals : {0:f3}", 23.4555);

            // Add commas and decimals
            Console.WriteLine("Commas : {0:n4}", 2300);

            // ----- STRINGS -----
            // Strings store a series of characters
            string randString = "This is a string";

            // Get number of characters in string
            Console.WriteLine("String Length : {0}", randString.Length);

            // Check if string contains other string
            Console.WriteLine("String Contains is : {0}", randString.Contains("is"));

            // Index of string match
            Console.WriteLine("Remove string : {0}", randString.Remove(10, 6));

            // Add a string starting at an index
            Console.WriteLine("Insert String : {0}", randString.Insert(10, "short "));

            // Replace a string with another
            Console.WriteLine("Replace String : {0}", randString.Replace("string", "sentence"));

            // Compare strings and ignore case
            // < 0 : str1 preceeds str2
            // = : Zero 
            // > 0 : str2 preceeds str1
            Console.WriteLine("Compare A to B : {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));

            // Check if strings are equal
            Console.WriteLine("A = a : {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));

            // Add padding left
            Console.WriteLine("Pad Left : {0}", randString.PadLeft(20, '.'));

            // Add padding right
            Console.WriteLine("Pad Right : {0} Stuff", randString.PadRight(20, '.'));

            // Trim whitepace
            Console.WriteLine("Trim : {0}", randString.Trim());

            // Make uppercase
            Console.WriteLine("Uppercase : {0}", randString.ToUpper());

            // Make lowercase
            Console.WriteLine("Lowercase : {0}", randString.ToLower());

            // Use Format to create strings
            string newString = String.Format("{0} saw a {1} {2} in the {3}", "Paul", "rabbit", "eating", "field");

            // You can add newlines with \n and join strings with +
            Console.Write(newString + "\n");

            // Other escape characters
            // \' \" \\ \t \a

            // Verbatim strings ignore escape characters
            Console.WriteLine(@"Exactly What I Typed\n");

            // ------- ARRAYS ------
            // Arrays are just boxes inside of a bigger box
            // that can contain many values of the same
            // data type
            // Each item is assigned a key starting at 0
            // and incrementing up from there

            // Define an array which holds 3 values
            // Arrays have fixed sizes
            int[] favNums = new int[3];

            // Add a value to the array
            favNums[0] = 23;

            // Retrieve a value
            Console.WriteLine("favNum 0 : {0}", favNums[0]);

            // Create and fill array
            string[] customers = { "Bob", "Sally", "Sue" };

            // You can use var to create arrays, but the
            // values must be of the same type
            var employees = new[] { "Mike", "Paul", "Rick" };

            // Create an array of base objects which is the
            // base type of all other types
            object[] randomArray = { "Paul", 45, 1.234 };

            // GetType knows its true type
            Console.WriteLine("randomArray 0 : {0}", randomArray[0].GetType());

            // Use for loop to cycle through the array
            for (int j = 0; j < randomArray.Length; j++)
            {
                Console.WriteLine("Array {0} : Value {1}", j, randomArray[j]);
            }

            // Multidimensional arrays
            // When you define an array like arrName[5] you
            // are saying you want to create boxes stacked
            // vertically

            // If you define arrName[2,2] you are saying
            // you want to have 2 high and 2 across
            string[,] custNames = new string[2, 2] { { "Bob", "Smith" }, { "Sally", "Smith" } };

            // Get value in MD array
            Console.WriteLine("MD Value: {0}", custNames.GetValue(1, 1));

            // Cycle through the mutlidimensional array
            // Get length of multidimensional array column
            for (int j = 0; j < custNames.GetLength(0); j++)
            {
                // Get length of multidimensional array row
                for (int k = 0; k < custNames.GetLength(1); k++)
                {
                    Console.Write("{0} ", custNames[j, k]);
                }
                Console.WriteLine();
            }
        }
    }
}