using System;

namespace ProgrammingBasics
{
    class DivisionOfTwoNo
    {
        static void Main(string[] args)
        {
            int num1, num2;
            float division;
            Console.WriteLine("Enter first number (dividend):");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number (divisor):");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 != 0)
            {
                division = (float)num1 / num2;
                Console.WriteLine("The division of {0} by {1} is: {2}", num1, num2, division);
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
        }
    }
}