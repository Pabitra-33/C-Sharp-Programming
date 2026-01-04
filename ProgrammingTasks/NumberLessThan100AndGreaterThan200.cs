using System;

namespace ProgrammingTasks
{
    oublic class NumberLessThan100AndGreaterThan200
    {
        //checking if number is less than 100 or greater than 200
        public static bool IsNumberLessThan100OrGreaterThan200(int number)
        {
            return number < 100 || number > 200;
        }

        //main method
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool result = IsNumberLessThan100OrGreaterThan200(number);
            Console.WriteLine($"Is the number less than 100 or greater than 200? {result}");
        }
    }
}