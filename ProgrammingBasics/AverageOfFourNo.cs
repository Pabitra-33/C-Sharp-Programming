using System;

namespace ProgrammingBasics
{
    class AverageOfFourNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter four numbers:");

            // Read four numbers from the user
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());
            double num4 = Convert.ToDouble(Console.ReadLine());

            // Calculate the average
            double average = (num1 + num2 + num3 + num4) / 4;

            // Display the result
            Console.WriteLine("The average of the four numbers is: " + average);
        }
    }
}