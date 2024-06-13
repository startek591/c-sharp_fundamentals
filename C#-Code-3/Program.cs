using System;

// We cover public, private, protected, constants
// read-only fields, constructors, setters, getters
// properties and more on static

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();

            // Cal the setter
            cat.SetName("Whiskers");

            // Set the property
            cat.Sound = "Meow";

            Console.WriteLine("This cat is named {0} and says {1}", cat.GetName(), cat.Sound);

            Console.ReadLine();

        }
    }
}