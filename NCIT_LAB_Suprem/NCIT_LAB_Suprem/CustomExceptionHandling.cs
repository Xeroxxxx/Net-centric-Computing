using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCIT_LAB_Suprem
{
    internal class CustomExceptionHandling
    {
        static void Main(string[] args)
        {
            try
            {
                // Attempt to perform a risky operation
                int result = Divide(10, 0);
                Console.WriteLine("Result of division: " + result); // This line won't be reached
            }
            catch (CustomException ex)
            {
                // Catch the custom exception and handle it
                Console.WriteLine("Custom Error: " + ex.Message);
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
            Console.WriteLine("\nLab No.: 15.c");
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
                throw new CustomException("Cannot divide by zero.");
            }
            return dividend / divisor;
        }
    }

    // Custom exception class
    public class CustomException : Exception
    {
        // Constructor that accepts a message
        public CustomException(string message) : base(message)
        {
        }
    }
}
