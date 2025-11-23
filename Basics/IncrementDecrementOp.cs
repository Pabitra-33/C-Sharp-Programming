using System;

namepspace Basics
{
    class IncrementDecrementOp
    {
        static void Main(string[] args)
        {
            int num = 5;

            // Increment operator
            Console.WriteLine("After Pre-Increment: " + ++num);
            Console.WriteLine("After Post-Increment: " + num++);

            // Decrement operator
            Console.WriteLine("After Pre-Decrement: " + --num);
            Console.WriteLine("After Post-Decrement: " + num--);
        }
    }
}