namespace Inheritance
{
    // Base class
    public class Animal
    {
        public string Name { get; set; }

        // Constructor
        public Animal(string name)
        {
            Name = name;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }

        //Derived class
        public class Dog : Animal
        {
            public Dog(string name) : base(name)
            {
            }
            public override void MakeSound()
            {
                Console.WriteLine($"{Name} barks.");
            }
        }
        public class Cat : Animal
        {
            public Cat(string name) : base(name)
            {
            }
            public override void MakeSound()
            {
                Console.WriteLine($"{Name} meows.");
            }
        }
    }

    // Main method
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myDog = new Animal.Dog("Truce");
            Animal myCat = new Animal.Cat("Lucky");
            myDog.MakeSound(); // Output: Truce barks.
            myCat.MakeSound(); // Output: Lucky meows.
        }
    }
}
