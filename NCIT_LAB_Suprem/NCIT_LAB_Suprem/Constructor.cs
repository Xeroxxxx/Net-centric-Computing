using System;

namespace NCIT_LAB_Suprem
{
    internal class Constructor
    {
        // Fields
        private int id;
        private string name;

        // Default Constructor
        public Constructor()
        {
            Console.WriteLine("Default Constructor is called.");
        }

        // Parameterized Constructor
        public Constructor(int id, string name)
        {
            this.id = id;
            this.name = name;
            Console.WriteLine($"Parameterized Constructor is called. ID: {id}, Name: {name}");
        }

        // Copy Constructor
        public Constructor(Constructor original)
        {
            this.id = original.id;
            this.name = original.name;
            Console.WriteLine($"Copy Constructor is called. ID: {id}, Name: {name}");
        }

        // Private Constructor
        private Constructor(string message)
        {
            Console.WriteLine(message);
        }

        // Main method - entry point of the program
        public static void Main(string[] args)
        {
            // Create an object using the Default Constructor
            Constructor defaultObj = new Constructor();

            // Create an object using the Parameterized Constructor
            Constructor paramObj = new Constructor(1, "Shigaraki");

            // Create an object using the Copy Constructor
            Constructor originalObj = new Constructor(2, "Rimuru");
            Constructor copyObj = new Constructor(originalObj);

            // Static Constructor is called automatically before any instance member is accessed
            // So no need to create an object to call it
            StaticConstructor();

            // Create an object using the Private Constructor
            Constructor privateObj = new Constructor("Private Constructor is called.");
        }

        // Additional information
        static void StaticConstructor()
        {
            Console.WriteLine("Static Constructor is called.");
            Console.WriteLine("\nLab No.: 1");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No: 31");
        }
    }
}
