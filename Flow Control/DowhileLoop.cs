using System;

namespace Flow_Control
{
    class DowhileLoop
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine("Iteration: " + i);
                i++;
            } while (i <= 5);
        }
    }
}