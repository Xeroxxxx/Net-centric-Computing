using System;
using System.Diagnostics;

namespace NCIT_LAB_Suprem
{
    class BuiltinAttribute
    {
        // Using Obsolete attribute to mark a method as obsolete
        [Obsolete("This method is obsolete. Use NewMethod instead.")]
        public void OldMethod()
        {
            Console.WriteLine("Old method is called.");
        }

        // Using Conditional attribute to conditionally include a method in debug builds
        [Conditional("DEBUG")]
        public void DebugMethod()
        {
            Console.WriteLine("Debug method is called.");
        }
    }
    class Programsixteen
    {
        static void Main(string[] args)
        {
            // Creating an instance of the Person class
            BuiltinAttribute person = new BuiltinAttribute();

            // Calling the obsolete method
            person.OldMethod(); // Generates a warning due to Obsolete attribute

            // Calling the debug method
            person.DebugMethod(); // This line will only execute in debug builds
            // Additional information
            Console.WriteLine("\nLab No.: 16.a");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No./Section: 31");
        }
    }
}
