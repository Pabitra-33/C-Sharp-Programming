using System;

namespace Operators
{
    class AssignmentOp
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("Initial values: a = {0}, b = {1}", a, b);

            // Using assignment operator
            a += 5; // Equivalent to a = a + 5
            b -= 10; // Equivalent to b = b - 10

            Console.WriteLine("After assignment operations: a = {0}, b = {1}", a, b);
        }
    }
}