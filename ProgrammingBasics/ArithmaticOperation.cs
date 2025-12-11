using System;

namespace ProgrammingBasics
{
    public class ArithmaticOperation
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            return (double)a / b;
        }
        static void Main(string[] args)
        {
            ArithmaticOperation operations = new ArithmaticOperation();

            Console.WriteLine("Addition: " + operations.Add(10, 5));
            Console.WriteLine("Subtraction: " + operations.Subtract(10, 5));
            Console.WriteLine("Multiplication: " + operations.Multiply(10, 5));
            Console.WriteLine("Division: " + operations.Divide(10, 5));
        }
    }
}