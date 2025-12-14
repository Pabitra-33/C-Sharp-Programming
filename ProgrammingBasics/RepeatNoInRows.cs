using System;

namespace ProgrammingBasics
{
    class ReapeatNoInRows
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of rows:");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}