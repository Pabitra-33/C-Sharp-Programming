using System;

namespace Operators
{
    class BitwiseOp
    {
        static void Main(string[] args)
        {
            int a = 60; // 60 = 0011 1100 
            int b = 13; // 13 = 0000 1101
            int result;

            // AND operator
            result = a & b; // result = 0000 1100 = 12
            Console.WriteLine("a & b = " + result);

            // OR operator
            result = a | b; // result = 0011 1101 = 61
            Console.WriteLine("a | b = " + result);

            // XOR operator
            result = a ^ b; // result = 0011 0001 = 49
            Console.WriteLine("a ^ b = " + result);

            // NOT operator
            result = ~a; // result = 1100 0011 (inverted bits of a)
            Console.WriteLine("~a = " + result);

            // Left shift operator
            result = a << 2; // result = 1111 0000 = 240
            Console.WriteLine("a << 2 = " + result);

            // Right shift operator
            result = a >> 2; // result = 0000 1111 = 15
            Console.WriteLine("a >> 2 = " + result);
        }
    }
}