using System;

namespace ProgrammingBasics
{
    class SwapTwoNumbers
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.WriteLine("Enter first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping:");
            Console.WriteLine("First number: {0}", num1);
            Console.WriteLine("Second number: {0}", num2);

            // Swapping logic
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After swapping:");
            Console.WriteLine("First number: {0}", num1);
            Console.WriteLine("Second number: {0}", num2);
        }
    }
}