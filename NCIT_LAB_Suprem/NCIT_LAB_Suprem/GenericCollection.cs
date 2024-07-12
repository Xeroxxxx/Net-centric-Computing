using System;
using System.Collections.Generic;

namespace NCIT_LAB_Suprem
{
    internal class GenericCollection
    {
        static void Main(string[] args)
        {
            // Create a generic List collection of integers
            List<int> numbers = new List<int>();

            // Add elements to the collection
            numbers.Add(69);
            numbers.Add(79);
            numbers.Add(89);

            // Display elements in the collection
            Console.WriteLine("Elements in the List:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Additional information
            Console.WriteLine("\nLab No.: 10.b");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No./Section: 31");
        }
    }
}
