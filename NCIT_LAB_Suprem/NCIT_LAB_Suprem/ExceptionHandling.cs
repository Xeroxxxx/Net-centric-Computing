using System;

namespace NCIT_LAB_Suprem
{
    public class ExceptionHandling
    {
        static void Main(string[] args)
        {
            try
            {
                // Attempt to perform a risky operation
                int result = Divide(10, 0);
                Console.WriteLine("Result of division: " + result); // This line won't be reached
            }
            catch (DivideByZeroException ex)
            {
                // Catch the DivideByZeroException and handle it
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // The finally block always executes, regardless of whether an exception occurred
                Console.WriteLine("Finally block executed.");
            }

            // Additional information
            Console.WriteLine("\nLab No.: 15.a");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No./Section: 31");
        }

        // Method that performs division
        static int Divide(int dividend, int divisor)
        {
            // Check if divisor is zero
            if (divisor == 0)
            {
                // Throw a DivideByZeroException if divisor is zero
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return dividend / divisor;
        }
    }
}
