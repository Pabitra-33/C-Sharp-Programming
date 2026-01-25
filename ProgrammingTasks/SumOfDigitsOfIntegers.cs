using System;

namespace ProgrammingTasks
{
    // This program calculates the sum of the digits of a given positive integer N.
    public class SumOfDigitsOfIntegers
    {
        //main method
        public static void Main(string[] args)
        {
            // Prompting user for input
            Console.WriteLine("Enter a positive integer N to calculate the sum of the numbers in it:");
            // Reading input from user
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;// Variable to store the sum of digits
            while(num != 0)
            {
                sum += num % 10; // Extracting the last digit and adding it to sum
                num /= 10; // Removing the last digit from num
            }
            Console.WriteLine("Sum of digits: " + sum);
        }
    }
}