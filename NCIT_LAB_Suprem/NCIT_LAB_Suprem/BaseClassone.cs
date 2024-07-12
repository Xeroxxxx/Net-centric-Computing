using System;

namespace NCIT_LAB_Suprem
{
    // Base class
    public class BaseClassone
    {
        // Field in the base class
        protected string baseField = "Base Field";

        // Method in the base class
        public void DisplayBaseField()
        {
            Console.WriteLine($"Base Field: {baseField}");
        }
    }

    // Derived class
    class DerivedClass : BaseClassone
    {
        // Method in the derived class that accesses the base class field using the 'base' keyword
        public void DisplayBaseFieldFromDerived()
        {
            // Accessing the base class field using the 'base' keyword
            Console.WriteLine($"Accessing Base Field from Derived: {base.baseField}");
        }
    }

    // Program class with the Main method
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the derived class
            DerivedClass derivedObj = new DerivedClass();

            // Call method to display base class field from the derived class
            derivedObj.DisplayBaseFieldFromDerived();

            // Additional information
            Console.WriteLine("\nLab No.: 5.a");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No.: 31");
        }
    }
}
