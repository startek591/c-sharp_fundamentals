namespace ConsoleApp4
{
    // When you inherit from another class you
    // recieve all of its fields and methods
    // You cannot inherit from multiple classes
    class Dog : Animal
    {
        // You can add additional properties
        // or fields
        public string Sound2 { get; set; } = "Grrrr";
        // You can overwrite methods by adding new

        // Add override so that the correct method
        // is called when a Dog is created as an
        // Animal type
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }

        // Create a constructor that has the base
        // constructor initialize everything except
        // Sound2
        public Dog(string name = "No Name", string sound = "No Sound", string sound2 = "No Sound 2") : base(name, sound)
        {
            Sound2 = sound2;
        }
    }
}