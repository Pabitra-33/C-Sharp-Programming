using System;

namespace Basics
{
    class BitShiftingOp
    {
        static void Main(string[] args)
        {
            int num = 8; // Binary: 0000 1000

            // Left Shift
            int leftShiftResult = num << 2; // Shifts bits to the left by 2 positions
            Console.WriteLine("Left Shift (num << 2): " + leftShiftResult); // Output: 32 (Binary: 0010 0000)

            // Right Shift
            int rightShiftResult = num >> 2; // Shifts bits to the right by 2 positions
            Console.WriteLine("Right Shift (num >> 2): " + rightShiftResult); // Output: 2 (Binary: 0000 0010)
        }
    }
}