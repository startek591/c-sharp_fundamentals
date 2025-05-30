using System;

namespace ConsoleApp2
{
    class Animal
    {
        // Attributes (fields) that all Animals have
        // public means can be directly changed
        // after an object has been created
        public string name;
        public string sound;

        // static fields and methods belong to the class
        // A static field has the same value for all
        // objects of the Animal type
        static int numOfAnimals = 0;

        // A constructor sets default values for
        // fields when an object is created
        // This is the default constructor if no 
        // parameters are sent
        public Animal()
        {
            // This refers to this objects name
            // instead of the name passed into
            // the constructor
            name = "No Name";
            sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(string name = "No Name", string sound = "No Sound")
        {
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        // Capabilities (methods) that all Animals have
        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }

        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }
    }
}