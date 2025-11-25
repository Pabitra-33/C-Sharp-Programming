using System;

namespace ShorthandOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            // Using shorthand operators
            a += b; // Equivalent to a = a + b
            Console.WriteLine("After += : " + a); // Output: 15

            a -= b; // Equivalent to a = a - b
            Console.WriteLine("After -= : " + a); // Output: 10

            a *= b; // Equivalent to a = a * b
            Console.WriteLine("After *= : " + a); // Output: 50

            a /= b; // Equivalent to a = a / b
            Console.WriteLine("After /= : " + a); // Output: 10

            a %= b; // Equivalent to a = a % b
            Console.WriteLine("After %= : " + a); // Output: 0
        }
    }
}