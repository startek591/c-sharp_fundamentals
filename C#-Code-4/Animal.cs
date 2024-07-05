

namespace ConsoleApp4
{
    class Animal
    {
        private string name = string.Empty;

        // A protected field can be changed by
        // a subclass directly
        protected string sound = string.Empty;

        // Inhertiance has a "is-a" relationship
        // while an aggregation or delegate
        // represent a "Has-a" relationship
        // like we have here with the AnimalIDInfo
        // object
        protected AnimalIDInfo animalIDInfo = new AnimalIDInfo();

        public void SetAnimalIDInfo(int idNum, string owner)
        {
            animalIDInfo.IDNum = idNum;
            animalIDInfo.Owner = owner;
        }

        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} has the ID of {animalIDInfo.IDNum} and is owned by {animalIDInfo.Owner}");
        }

        // Added virtual so that this method can
        // be overriden by subclasses
        // You must add override to the method in
        // the subclass
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        public Animal() : this("No Name", "No Sound") { }

        public Animal(string name) : this("No Name", "No Sound") { }

        public Animal(string name, string sound)
        {

        }

        public string Name
        {
            get { return name; }
            set
            {
                if (name.Any(char.IsDigit))
                {
                    name = "No Name";
                }
                else
                {
                    name = value;
                }
            }
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                }
                sound = value;
            }
        }

        // You can create inner classes that are
        // normally helper classes for the outer
        // class because it can access private
        // members of the outer class
        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;

                if ((calc >= .18) && (calc <= .27))
                {
                    return true;
                }
                else return false;
            }
        }


    }
}