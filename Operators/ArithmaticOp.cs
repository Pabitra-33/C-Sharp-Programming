using System;

namespace Basics
{
    class ArithmaticOp
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 4;

            // Addition
            int sum = a + b;
            Console.WriteLine("Addition: " + sum);

            // Subtraction
            int difference = a - b;
            Console.WriteLine("Subtraction: " + difference);

            // Multiplication
            int product = a * b;
            Console.WriteLine("Multiplication: " + product);

            // Division
            int quotient = a / b;
            Console.WriteLine("Division: " + quotient);

            // Modulus
            int remainder = a % b;
            Console.WriteLine("Modulus: " + remainder);
        }
    }
}