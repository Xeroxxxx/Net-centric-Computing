using System;

namespace NCIT_LAB_Suprem
{
    internal class GenericClassWithFieldAndMethod<T>
    {
        // Generic field
        private T genericField;

        // Constructor
        public GenericClassWithFieldAndMethod(T value)
        {
            genericField = value;
        }

        // Generic method
        public void Display()
        {
            Console.WriteLine("Generic Field Value: " + genericField);
        }
    }

    internal class ProgramLabEleven
    {
        static void Main(string[] args)
        {
            // Create an instance of the generic class with int type
            GenericClassWithFieldAndMethod<int> intInstance = new GenericClassWithFieldAndMethod<int>(10);
            intInstance.Display();

            // Create an instance of the generic class with string type
            GenericClassWithFieldAndMethod<string> stringInstance = new GenericClassWithFieldAndMethod<string>("Hello");
            stringInstance.Display();

            // Additional information
            Console.WriteLine("\nLab No.: 11");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No./Section: 31");
        }
    }
}
