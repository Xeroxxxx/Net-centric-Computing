using System;

namespace NCIT_LAB_Suprem
{
    internal class Enumeration
    {
        // Define an enumeration for representing days of the week
        public enum DayOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {
            // Display the days of the week using the enumeration
            Console.WriteLine("Days of the week:");
            foreach (var day in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.WriteLine(day);
            }

            // Additional information
            Console.WriteLine("\nLab No.: 8.b");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No.: 31");
        }
    }
}
