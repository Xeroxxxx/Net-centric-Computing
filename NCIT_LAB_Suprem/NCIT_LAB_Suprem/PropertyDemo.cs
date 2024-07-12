using System;

namespace NCIT_LAB_Suprem
{
    internal class PropertyDemo
    {
        // Auto-implemented property
        public int AutoProperty { get; set; }

        // Read-only property
        public int ReadOnlyProperty { get; }

        // Constructor
        public PropertyDemo(int value)
        {
            ReadOnlyProperty = value; // Initialize the read-only property
        }
        public static void Main(string[] args)
        {
            // Creating an object of PropertyDemo
            PropertyDemo obj = new PropertyDemo(10);

            // Assigning value to auto property
            obj.AutoProperty = 20;

            // Displaying values
            Console.WriteLine($"Auto Property Value: {obj.AutoProperty}");
            Console.WriteLine($"Read-Only Property Value: {obj.ReadOnlyProperty}");

            // Print additional information
            PrintAdditionalInformation();
        }

        // Additional information
        static void PrintAdditionalInformation()
        {
            Console.WriteLine("\nLab No.: 2");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No.: 31");
        }
    }
}
