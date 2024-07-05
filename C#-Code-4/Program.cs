namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrrrrr"
            };

            // Demonstrate changing the protected
            // field sound
            grover.Sound = "Wooooof";

            whiskers.MakeSound();
            grover.MakeSound();

            // Define the AnimalIDInfo
            whiskers.SetAnimalIDInfo(122345, "Sally Smith");
            grover.SetAnimalIDInfo(12346, "Paul Brown");

            whiskers.GetAnimalIDInfo();

            // Test the inner class
            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();

            Console.WriteLine("Is my animal healthy : {0}", getHealth.HealthyWeight(11, 46));

            // You can define 2 Animal objects but have
            // one actually be a Dog type.
            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Eeeee"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Wooooof",
                Sound2 = "Geerrrr"
            };

            // the problem is that is you call a 
            // function in Animal it won't call
            // the overriden method in Dog unless
            // the method that might be overriden 
            // is maked virtual
            spot.MakeSound();
        }
    }
}