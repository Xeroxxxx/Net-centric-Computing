using System;
using System.Collections.Generic;
using System.Linq;

namespace NCIT_LAB_Suprem
{
    internal class LambdaAndLinq
    {
        static void Main(string[] args)
        {
            // Part (a): Lambda Expression
            Console.WriteLine("Part (a): Lambda Expression");

            // Example 1: Square of a number using Lambda Expression
            Func<int, int> square = x => x * x;
            Console.WriteLine("Square of 9: " + square(9));

            // Example 2: Addition of two numbers using Lambda Expression
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine("Addition of 69 and 4: " + add(69, 4));

            Console.WriteLine();

            // Part (b): LINQ with Lambda Expression
            Console.WriteLine("Part (b): LINQ with Lambda Expression");

            // Sample list of numbers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // LINQ query using Lambda Expression to filter even numbers
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            // Displaying even numbers using LINQ with Lambda Expression
            Console.WriteLine("Even numbers using LINQ with Lambda Expression:");
            foreach (var num in evenNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Additional information
            Console.WriteLine("\nLab No.: 14");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No./Section: 31");
        }
    }
}
