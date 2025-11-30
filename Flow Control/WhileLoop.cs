using System;

namespace FlowControl
{
    class WhileLoop
    {
        static void Main(string[] args)
        {
            int count = 1;

            Console.WriteLine("Counting from 1 to 5:");

            while (count <= 5)
            {
                Console.WriteLine(count);
                count++;
            }
        }
    }
}