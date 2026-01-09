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

            //calling the method to check if number is in range
            bool result = IsNumberInRange10(number);//storing the boolean result

            Console.WriteLine($"Is the number in the range of -10 to 10 inclusive? {result}");
        }
    }
}