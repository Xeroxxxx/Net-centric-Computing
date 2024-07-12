using System;

namespace NCIT_LAB_Suprem
{
    internal class ExceptionHandlingWithThrow
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
            catch (Exception ex)
            {
                // Catch any other exceptions and handle them
                Console.WriteLine("Unknown error occurred: " + ex.Message);
            }
            finally
            {
                // The finally block always executes, regardless of whether an exception occurred
                Console.WriteLine("Finally block executed.");
            }

            // Additional information
            Console.WriteLine("\nLab No.: 15.b");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No.: 31");
        }

        // Method that performs division
        static int Divide(int dividend, int divisor)
        {
            // Check if divisor is zero
            if (divisor == 0)
            {
                // Throw a custom exception if divisor is zero
                throw new InvalidOperationException("Cannot divide by zero.");
            }
            return dividend / divisor;
        }
    }
}