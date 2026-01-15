using System;

namespace ProgrammingTasks
{
    oublic class NumberLessThan100AndGreaterThan200
    {
        //checking if number is less than 100 or greater than 200
        public static bool IsNumberLessThan100OrGreaterThan200(int number)
        {
            return number < 100 || number > 200;//returning boolean result
        }

        //main method
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");//asking user input
            int number = Convert.ToInt32(Console.ReadLine());//converting input to integer

            bool result = IsNumberLessThan100OrGreaterThan200(number);//storing the boolean result

            Console.WriteLine($"Is the number less than 100 or greater than 200? {result}");
        }// main method end
    }
}