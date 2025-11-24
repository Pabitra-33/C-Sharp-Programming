using System;

namespace Basics
{
    class TernaryOp
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            // Using the ternary operator to find the maximum of two numbers
            int max = (a > b) ? a : b;

            Console.WriteLine("The maximum value is: " + max); // Output: The maximum value is: 20
        }
    }
}