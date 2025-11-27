using System;

namespace FlowControl
{
    class IfElseStatement{
        static void Main(string[] args)
        {
            int number = 10;

            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else
            {
                Console.WriteLine("The number is not positive.");
            }
        }
    }
}