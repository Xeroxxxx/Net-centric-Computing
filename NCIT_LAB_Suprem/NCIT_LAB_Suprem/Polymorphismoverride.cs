using System;

namespace NCIT_LAB_Suprem
{
    // Base class
    class Animal
    {
        // Method to be overridden
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    // Derived class
    class Dog : Animal
    {
        // Method overriding
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    // Program class with the Main method
    class PolymorphismOverride
    {
        static void Main(string[] args)
        {
            // Create an object of the base class
            Animal animal = new Animal();

            // Call the method of the base class
            animal.MakeSound(); // Output: Animal makes a sound

            // Create an object of the derived class
            Dog dog = new Dog();

            // Call the method of the derived class
            dog.MakeSound(); // Output: Dog barks

            // Additional information
            Console.WriteLine("\nLab No.: 6.b");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No.: 31");
        }
    }
}
