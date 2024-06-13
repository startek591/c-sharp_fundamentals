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
        // objects of Animal type
        static int numOfAnimals = 0;

        // A constructor sets default value for
        // filds when a object is created
        // This is the default constructor if no
        // parameters are sent
        public Animal()
        {
            name = "No Name";
            sound = "No Sound";
            numOfAnimals++;
        }

        // You can create additional constructors
        // but since we are defining defaults you
        // don't have to
        public Animal(string name = "No Name")
        {
            // This refers to this objects name
            // instead of the name passed into
            // the constructor
            this.name = name;
            this.sound = "No Sound";
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