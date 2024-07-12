using System;

namespace NCIT_LAB_Suprem
{
    internal class ActionDelegate
    {
        // Method to display a message
        public static void DisplayMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        // Method to display a number
        public static void DisplayNumber(int number)
        {
            Console.WriteLine("Number: " + number);
        }

        // Main method
        public static void Main(string[] args)
        {
            // Action delegate declaration (takes a string parameter)
            Action<string> messageAction;

            // Assign the DisplayMessage method to the delegate
            messageAction = DisplayMessage;

            // Call the delegate with a message
            messageAction("Hello, World!");

            // Action delegate declaration (takes an int parameter)
            Action<int> numberAction;

            // Assign the DisplayNumber method to the delegate
            numberAction = DisplayNumber;

            // Call the delegate with a number
            numberAction(69);

            // Additional information
            Console.WriteLine("\nLab No.: 9.d");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No./Section: 31");
        }
    }
}
