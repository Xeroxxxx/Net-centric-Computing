using System;

namespace NCIT_LAB_Suprem
{
    internal class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[5][] {
                new int[] { 69, 41, 96, 78, 88, 99, 66 },
                new int[] { 2, 5, 6, 7, 98, 5, 87 },
                new int[] { 2, 5, 6, 7, 98},
                new int[] { 2, 5 },
                new int[] { 2 }
            };

            // Traverse array elements
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Additional information
            Console.WriteLine("\nLab No.: 3");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No.: 31");
        }
    }
}
