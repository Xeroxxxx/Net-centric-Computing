using System;

namespace NCIT_LAB_Suprem
{
    internal class Struct
    {
        // Define a structure for representing a Point in 2D space
        public struct Point
        {
            public int X;
            public int Y;

            // Constructor
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            // Method to display the point
            public void Display()
            {
                Console.WriteLine($"Point coordinates: ({X}, {Y})");
            }
        }

        static void Main(string[] args)
        {
            // Create an instance of the Point struct
            Point point = new Point(69, 79);

            // Display the point coordinates
            point.Display();

            // Additional information
            Console.WriteLine("\nLab No.: 8.a");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No.: 31");
        }
    }
}
