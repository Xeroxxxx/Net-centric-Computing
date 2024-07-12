using System;

namespace NCIT_LAB_Suprem
{
    // Partial class
    public partial class Employee
    {
        // Fields
        private string name;
        private int age;

        // Constructor
        public Employee(string n, int a)
        {
            name = n;
            age = a;
        }

        // Method to display employee details
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    // Partial class (continued)
    public partial class Employee
    {
        // Additional fields and methods can be defined here
    }

    // Program class with the Main method
    internal class PartialClass
    {
        static void Main(string[] args)
        {
            // Create an instance of the partial class
            Employee employee = new Employee("Condoriyano", 37);

            // Display employee details
            employee.DisplayDetails();

            // Additional information
            Console.WriteLine("\nLab No.: 8.c");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No.: 31");
        }
    }
}
