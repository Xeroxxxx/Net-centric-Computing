using System;

namespace NCIT_LAB_Suprem
{
     class BaseClassMrthod
    {
        // Method in the base class
        public void DisplayMessage()
        {
            Console.WriteLine("Message from BaseClassMrthod");
        }
    }
    // Derived class
    class DerivedClassTwo : BaseClassMrthod
    {
        // Method in the derived class that calls base class method using the 'base' keyword
        public void DisplayMessage()
        {
            // Call the base class method using the 'base' keyword
            base.DisplayMessage();
            Console.WriteLine("Message from DerivedClassTwo");
        }
    }

    // Program class with the Main method
    class ProgramBaseTwo
    {
        static void Main(string[] args)
        {
            // Create an object of the derived class
            DerivedClassTwo derivedObj = new DerivedClassTwo();

            // Call method to display message from the derived class
            derivedObj.DisplayMessage();

            // Additional information
            Console.WriteLine("\nLab No.: 5.b");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No.: 31");
        }
    }
}
