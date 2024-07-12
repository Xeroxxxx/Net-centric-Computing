using System;

namespace NCIT_LAB_Suprem
{
    class MethodShadowingOverriding
    {
        // New method added
        public void MethodOverrideSix()
        {
            Console.WriteLine("MethodOverrideSix from Methodoverrideandshadow class");
        }
    }

    // Base class
    class BaseClassSix
    {
        // Method to be overridden
        public virtual void DisplayMessage()
        {
            Console.WriteLine("Message from BaseClass");
        }

        // Method to be hidden
        public void DisplayInfo()
        {
            Console.WriteLine("Info from BaseClass");
        }
    }

    // Derived class
    class DerivedClassSix : BaseClassSix
    {
        // Method overriding
        public override void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass");
        }

        // Method hiding (shadowing)
        new public void DisplayInfo()
        {
            Console.WriteLine("Info from DerivedClass");
        }
    }

    // Program class with the Main method
    class ProgramLabSix
    {
        static void Main(string[] args)
        {
            // Create an object of the derived class
            DerivedClassSix derivedObj = new DerivedClassSix();

            // Call method to display message from the derived class
            derivedObj.DisplayMessage(); // Method overriding

            // Call method to display info from the base class
            derivedObj.DisplayInfo(); // Method hiding (shadowing)

            // Call method to display info from the base class explicitly
            ((BaseClassSix)derivedObj).DisplayInfo(); // Accessing hidden method in base class

            // Create an object of the Methodoverrideandshadow class
            MethodShadowingOverriding newObject = new MethodShadowingOverriding();

            // Call the new method added to the Methodoverrideandshadow class
            newObject.MethodOverrideSix(); // New method added

            // Additional information
            Console.WriteLine("\nLab No.: 6.a");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No.: 31");
        }
    }
}
