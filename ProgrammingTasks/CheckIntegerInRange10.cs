using System;

namespace ProgrammingTasks
{
    public class CheckIntegerInRange10
    {
        //checking if number is in the range of 10 to 20 inclusive
        public static bool IsNumberInRange10To20(int number)
        {
            return number >= -10 && number <= 10;
        }

        //main method
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");//asking user input
            int number = Convert.ToInt32(Console.ReadLine());//converting input to integer

            bool result = IsNumberInRange10To20(number);//storing the boolean result

            Console.WriteLine($"Is the number in the range of 10 to 20 inclusive? {result}");
        }
    }
}