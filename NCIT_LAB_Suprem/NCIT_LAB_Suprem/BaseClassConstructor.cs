using System;

namespace NCIT_LAB_Suprem
{
    class BaseClassConstructor
    {
        // Field in the base class
        protected int baseField;

        // Base class constructor
        public BaseClassConstructor(int value)
        {
            baseField = value;
        }

        // Method in the base class
        public void DisplayBaseField()
        {
            Console.WriteLine($"Base Field: {baseField}");
        }
    }
    // Derived class
    class DerivedClassThree : BaseClassConstructor
    {
        // Derived class constructor
        public DerivedClassThree(int value) : base(value)
        {
            // Call the base class constructor using the 'base' keyword
            // and pass the value to initialize the baseField
        }
    }

    // Program class with the Main method
    class ProgramBaseThree
    {
        static void Main(string[] args)
        {
            // Create an object of the derived class
            DerivedClassThree derivedObj = new DerivedClassThree(69);

            // Call method to display base class field from the derived class
            derivedObj.DisplayBaseField();

            // Additional information
            Console.WriteLine("\nLab No.: 5.c");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No.: 31");
        }
    }

}
