using System;
using System.Text;
using System.Globalization;


namespace HelloWorld
{
    public class Program
    {
        // ------ FUNCTIONS -------
        static void PrintArray(int[] intArray, string mess)
        {
            foreach (int k in intArray)
            {
                Console.WriteLine("{0} : {1} ", mess, k);
            }
        }
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

            // Arrays
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
            Console.WriteLine("favNum 0: {0}", favNums[0]);

            // Create an fill array
            string[] customers = { "Bob", "Sally", "Sue" };

            // You can use var to create arrays, but the
            // values must be of the same type
            var employees = new[] { "Mike", "Paul", "Rick" };

            // Create an array of base objects which is the
            // base type of all other types
            object[] randomArray = { "Paul", 45, 1.234 };

            // GetType knows its true type
            Console.WriteLine("randomArray 0: {0}", randomArray[0].GetType());

            // Get number of items in array
            Console.WriteLine("Array Size: {0}", randomArray.Length);

            // Use for loop to cycle through the array
            for (int j = 0; j < randomArray.Length; j++)
            {
                Console.WriteLine("Array {0}: Value: {1}", j, randomArray[j]);
            }

            // Multidimensional arrays
            // When you define an array like arrName[5] you
            // are saying you want to create boxes stacked
            // vertically
            string[,] custNames = new string[2, 2] { { "Bob", "Smith", }, { "Sally", "Smith" } };

            // Get value in MD array
            Console.WriteLine("MD Value: {0}", custNames.GetValue(1, 1));

            // Cycle through the multidimensional array
            // Get length of multidimensional array column
            for (int j = 0; j < custNames.GetLength(0); j++)
            {
                // Get length of multidimensional array column
                for (int k = 0; k < custNames.GetLength(1); k++)
                {
                    Console.Write("{0} ", custNames[j, k]);
                }
                Console.WriteLine();
            }

            // An array like arrName[2,2,3] would be like a
            // stack of 3 spread sheets with 2 rows and 2 columns
            // columns worth of data on each page

            // foreach can be used to cycle through an array
            int[] randNums = { 1, 4, 9, 2 };

            // You can pass an array to a function
            PrintArray(randNums, "ForEach");

            // Sort array
            Array.Sort(randNums);

            // Reverse array
            Array.Reverse(randNums);

            // Get index of match or return -1
            Console.WriteLine("1 at index: {0}", Array.IndexOf(randNums, 1));

            // Change value at index 1 to 0
            randNums.SetValue(0, 1);

            // Copy part of an array to another
            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int startInd = 0;
            int length = 2;

            Array.Copy(srcArray, startInd, destArray, startInd, length);

            PrintArray(destArray, "Copy");

            // Create an array with CreateInstance
            Array anotherArray = Array.CreateInstance(typeof(int), 10);

            // Copy values in srcArray to destArray starting
            // at index 5 in destination
            srcArray.CopyTo(anotherArray, 5);

            foreach (int m in anotherArray)
            {
                Console.WriteLine("CopyTo: {0}", m);
            }

            // IF / ELSE
            // Releational Operators : > < >= <= == !=
            // Logical Operators: && || !

            int age = 17;

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elementary school");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school");
            }
            else if ((age > 13) && (age < 19))
            {
                Console.WriteLine("Go to high school");
            }
            else
            {
                Console.WriteLine("Go to college");
            }

            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("You shouldn't work");
            }

            Console.WriteLine("! true = " + (!true));

            // Ternary Operator
            // Assigns the 1st value if true and otherwise
            // the 2nd
            bool canDrive = age >= 16 ? true : false;

            // Switch is used when you have limited options
            // The only way to use ranges is to stack
            // the possible values
            switch (age)
            {
                case 1:
                case 2:
                    Console.WriteLine("Go to Day Care");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Go to Preschool");
                    break;
                case 5:
                    Console.WriteLine("Go to Kindergarden");
                    break;
                default:
                    Console.WriteLine("Go to another school");
                    goto OtherSchool;
            }
        OtherSchool:
            Console.WriteLine("Elementary, Middle, High School");

            // To compare strings use Equals
            string name2 = "Derek";
            string name3 = "Derek";

            if (name2.Equals(name3, StringComparison.Ordinal))
            {
                Console.WriteLine("Names are Equal");
            }

            // While Loop
            // You use the while loop when you want to execute
            // as long as a condition is true

            // This while loop will print odd numbers between
            // 1 and 10
            int i = 1;
            while (i <= 10)
            {
                // % (Modulus) returns the remainder of a
                // division. If it returns 0 that means the
                // value is even
                if (i % 2 == 0)
                {
                    i++;

                    // Continue skips the rest of the code and
                    // starts execution back at the top of the
                    // while
                    continue;
                }

                // Breaks jumps completely out of the loop
                if (i == 9) break;
                Console.WriteLine(i);
                i++;
            }

            // Do While Loop
            // at least once

            // Generate a random number
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11);
            int numberGuessed = 0;
            Console.WriteLine("Random Num: ", secretNumber);

            do
            {
                Console.Write("Enter a number between 1 & 10: ");

                // Use Convert to switch the string into an int
                // Other Convert options: ToBoolean, ToByte,
                // ToChar, ToDecimal, ToDouble, ToInt64
                // ToString, and they can convert from any
                // type to any other type
                numberGuessed = Convert.ToInt32(Console.ReadLine());
            } while (secretNumber != numberGuessed);

            Console.WriteLine("You guessed it was {0}", secretNumber);
        }
    }

}