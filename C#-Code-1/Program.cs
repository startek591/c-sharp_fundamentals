/*
    Import namespace called system that has many classes
    and useful functions (Without it we'd have to type
    System.Console.Write)
*/
using System;
using System.Globalization;
using System.Text;

// Change interface size: Tools -> Options ->
// Environment -> Fonts and Colors -> Environment

// Defines our namespace in HelloWorld
namespace HelloWorld
{
    // Our class name is Program
    public class Program
    {
        // ---- FUNCTIONS ----
        static void PrintArray(int[] intArray, string mess)
        {
            foreach (int k in intArray)
            {
                Console.WriteLine("{0} : {1} ", mess, k);
            }
        }

        private static bool GT10(int val)
        {
            return val > 10;
        }

        static double DoDivison(double x, double y)
        {
            if (y == 0)
            {
                // We are throwing an exception because
                // you can't divide by zero
                throw new System.DivideByZeroException();
            }
            return x / y;
        }

        private static void SayHello()
        {
            // Defines a variable that will store a string
            // of characters
            string? name = "";

            Console.Write("What is your name : ");

            // Save the input the user provides
            name = Console.ReadLine();

            Console.WriteLine("Hello {0}", name);
        }

        // If you assign a value then it is optional to 
        // pass
        static double GetSum(double x = 1, double y = 1)
        {
            double temp = x;
            x = y;
            y = temp;
            return x + y;
        }

        // ---- OUT PARAMETER ----
        // A parameter marked with out must be assigned
        // a value in the method
        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        // ---- PASS BY REFERENCE ----
        // If a variable is passed by reference changes
        // to its value in the method effect it outside
        // of the method
        public static void Swap(ref int num3, ref int num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }

        // ---- PARAMS ----
        // The params array must be the last parameter
        // int the list
        static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return sum;
        }

        // ---- NAMED PARAMETERS ---
        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}", name, zipCode);
        }

        // ---- METHOD OVERLOADING ----
        static double GetSum2(double x = 1, double y = 1)
        {
            return x + y;
        }

        static void PaintColor(CarColor cc)
        {
            Console.WriteLine("The car was painted {0} with the code {1}", cc, (int)cc);
        }

        // ---- END OF FUNCTIONS ----

        // ---- ENUMS ----
        // An enum is a custom data type with
        // key value pairs. They allow you to 
        // The first number is 0 by default unless
        // you change it
        // You can define the underyling type
        // or leave it as int as default

        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Red,
            Yellow
        }

        // Execution begins in the main function
        // static means this function can run without
        // creating an object
        // void means that this function doesn't return a value
        // args represent data the can be passed to our program
        // from the command line as a an array of strings
        static void Main(string[] args)
        {
            // Print Hello World on the console
            Console.WriteLine("Hello World!");

            // ---- CONSOLE METHODS ----
            // Change the text color in the console
            Console.ForegroundColor = ConsoleColor.Black;

            // Change background color
            Console.BackgroundColor = ConsoleColor.White;

            // Set background for whole console
            Console.Clear();

            // Outputs text without a newline
            Console.Write("What is your name?");

            // Stores data entered by user in name
            string? name = Console.ReadLine();

            // Outputs Hello + values stored in name
            Console.WriteLine($"Hello {name}");

            // ---- VARIABLES ----
            // Used to store different types of data

            // Bools store true or false
            bool canIVote = true;

            // INTEGERS
            // Integers are 32-bit signed integers
            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);

            // LONGS
            // Longs are 64-bit signed integers
            Console.WriteLine("Biggest Integer : {0}", long.MaxValue);
            Console.WriteLine("Smallest Long : {0}", long.MinValue);

            // DECIMALS
            // Decimals store 128-bit precise decimal value
            // It is accurate to 28 digits
            decimal decPiVal = 3.1415926535897932384626433832M;
            decimal decBigNum = 3.00000000000000000000000000011M;
            Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);

            Console.WriteLine("Biggest Decimal : {0}", Decimal.MaxValue);

            // DOUBLES
            // Doubles are 64-type float types
            Console.WriteLine("Biggest Double : {0}", Double.MaxValue);

            // It is precise to 14 digits
            double dblPiVal = 3.14159265358979;
            double dblBigNum = 3.00000000000002;
            Console.WriteLine("DBL : PI + bigNum = {0}", dblPiVal + dblBigNum);

            // FLOATS
            // Floats are 32-bit float types
            Console.WriteLine("Biggest Float : {0}", float.MaxValue.ToString("#"));

            // It is precise to 6 digits
            float fltPiVal = 3.141592F;
            float fltBigNum = 3.0000002f;
            Console.WriteLine("FLT : PI + bigNum = {0}", fltPiVal + fltBigNum);

        }

    }
}