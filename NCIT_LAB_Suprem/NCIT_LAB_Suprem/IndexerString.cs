using System;


namespace NCIT_LAB_Suprem
{
    internal class IndexerString
    {
        private string[] data = new string[5];

        // Indexer when index is of string type
        public string this[string index]
        {
            get { return data[Convert.ToInt32(index)]; }
            set { data[Convert.ToInt32(index)] = value; }
        }

        static void Main(string[] args)
        {
            IndexerString demo = new IndexerString();

            // Using indexers with string type index
            demo["0"] = "Rimuru";
            demo["1"] = "Baji";
            demo["2"] = "Condoriano";

            // Displaying values
            Console.WriteLine("Values with string index:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Index {i}: {demo[i.ToString()]}");
            }

            // Additional information
            Console.WriteLine("\nLab No.: 4.b");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No.: 31");
        }
    }
}
