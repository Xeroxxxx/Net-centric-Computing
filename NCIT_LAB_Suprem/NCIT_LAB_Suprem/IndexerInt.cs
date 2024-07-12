using System;

namespace NCIT_LAB_Suprem
{
    internal class IndexerInt
    {
        private int[] data = new int[5];

        // Indexer when index is of int type
        public int this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        static void Main(string[] args)
        {
            IndexerInt demo = new IndexerInt();

            // Using indexers with int type index
            demo[0] = 59;
            demo[1] = 69;
            demo[2] = 79;

            // Displaying values
            Console.WriteLine("Values with int index:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Index {i}: {demo[i]}");
            }

            // Additional information
            Console.WriteLine("\nLab No.: 4.a");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No.: 31");
        }
    }
}
