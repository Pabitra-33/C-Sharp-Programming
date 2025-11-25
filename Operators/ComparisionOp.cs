using System;

namespace Operators
{
    class Comparision
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("a == b: " + (a == b)); // Equal to
            Console.WriteLine("a != b: " + (a != b)); // Not equal to
            Console.WriteLine("a > b: " + (a > b));   // Greater than
            Console.WriteLine("a < b: " + (a < b));   // Less than
            Console.WriteLine("a >= b: " + (a >= b)); // Greater than or equal to
            Console.WriteLine("a <= b: " + (a <= b)); // Less than or equal to
        }
    }
}