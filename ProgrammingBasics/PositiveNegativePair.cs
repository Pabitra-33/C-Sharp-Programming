using System;

namespace ProgrammingBasics
{
    class PositiveNegativePair
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if ((number1 > 0 && number2 < 0) || (number1 < 0 && number2 > 0))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}