using System;

namespace NCIT_LAB_Suprem
{
    // Delegate declaration
    public delegate void MyDelegate(string message);

    // Class to demonstrate delegates
    public class Delegate
    {
        // Method to be assigned to the delegate
        public static void DisplayMessage(string message)
        {
            Console.WriteLine("Message from the delegate: " + message);
        }

        // Main method
        public static void Main(string[] args)
        {
            // Create an instance of the delegate
            MyDelegate delegateInstance = new MyDelegate(DisplayMessage);

            // Call the delegate
            delegateInstance("Hello, World!");

            // Additional information
            Console.WriteLine("\nLab No.: 9.a");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No.: 31");
        }
    }
}
