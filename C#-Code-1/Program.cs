

namespace HelloWorld
{
    public class Program
    {
        // Execution begin with the main functions
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

            // Stores data entered by user in the name
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
            Console.WriteLine("DBL  : PI + bigNum = {0}", dblPiVal + dblBigNum);

            // FLOATS
            // Floats are 32-bits float types
            Console.WriteLine("Biggest Float : {0}", float.MaxValue.ToString("#"));

            // It is precise to 6 digits
            float fltPiVal = 3.141592F;
            float fltBigNum = 3.000002F;
            Console.WriteLine("FLT : PT + bigNum = {0}", fltPiVal + fltBigNum);
        }
    }
}
