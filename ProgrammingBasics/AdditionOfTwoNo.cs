using System;

namespace ProgrammingBasics
{
    // This program adds two numbers provided by the user.
    class AdditionOfTwoNo
    {
        //main method starts here
        static void Main(string[] args)
        {
            // Declaring variables to store the two numbers and their sum
            int num1, num2, sum;

            //fetching input from user
            Console.WriteLine("Enter first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;//calculating sum of two numbers

            Console.WriteLine("The sum of {0} and {1} is: {2}", num1, num2, sum);
        }
    }
}