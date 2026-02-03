using System;

namespace ProgrammingBasics
{
    // This class performs basic arithmetic operations.
    public class ArithmaticOperation
    {
        // Method to add two numbers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method to subtract two numbers
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // Method to multiply two numbers
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // Method to divide two numbers
        public double Divide(int a, int b)
        {
            // Check for division by zero
            if (b == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            return (double)a / b;// Ensuring floating point division
        }

        // Main method to test the arithmetic operations
        static void Main(string[] args)
        {
            // Creating an instance of ArithmaticOperation class
            ArithmaticOperation operations = new ArithmaticOperation();

            // Testing the methods
            Console.WriteLine("Addition: " + operations.Add(10, 5));
            Console.WriteLine("Subtraction: " + operations.Subtract(10, 5));
            Console.WriteLine("Multiplication: " + operations.Multiply(10, 5));
            Console.WriteLine("Division: " + operations.Divide(10, 5));
        }// End of Main method
    }
}