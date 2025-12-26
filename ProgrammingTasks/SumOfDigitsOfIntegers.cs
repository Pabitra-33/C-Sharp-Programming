using System;

namespace ProgrammingTasks
{
    public class SumOfDigitsOfIntegers
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer N to calculate the sum of the numbers in it:");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while(num != 0)
            {
                sum += num % 10; // Extracting the last digit and adding it to sum
                num /= 10; // Removing the last digit from num
            }
            Console.WriteLine("Sum of digits: " + sum);
        }
    }
}