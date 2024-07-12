using System;
using System.IO;

namespace NCIT_LAB_Suprem
{
    class InputFromKeyboard
    {
        static void Main(string[] args)
        {
            // Get the file path from the user
            Console.WriteLine("Enter the file path:");
            string filePath = Console.ReadLine();

            // Ask user for input
            Console.WriteLine("Enter text (type 'exit' to finish):");

            // Open or create the file for writing
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                string input;
                // Continue taking input until the user types 'exit'
                while ((input = Console.ReadLine()) != "exit")
                {
                    // Write the input to the file
                    writer.WriteLine(input);
                }
            }

            Console.WriteLine("Text has been written to the file.");

            // Additional information
            Console.WriteLine("\nLab No.: 12");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No./Section: 31");
        }
    }
}
