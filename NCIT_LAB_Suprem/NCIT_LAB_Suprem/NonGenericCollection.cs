using System;
using System.Collections;

namespace NCIT_LAB_Suprem
{
    internal class NonGenericCollection
    {
        static void Main(string[] args)
        {
            // Create a non-generic ArrayList collection
            ArrayList list = new ArrayList();

            // Add elements to the collection
            list.Add(69);
            list.Add("Hello boi");
            list.Add(3.14);

            // Display elements in the collection
            Console.WriteLine("Elements in the ArrayList:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // Additional information
            Console.WriteLine("\nLab No.: 10.a");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No./Section: 31");
        }
    }
}
