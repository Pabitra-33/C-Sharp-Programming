using System;

namespace ProgrammingTasks
{
    public class MultipleOf3Or7
    {
        public static bool IsMultipleOf3Or7(int number)
        {
            //checking if number is multiple of 3 or 7
            return (number % 3 == 0) || (number % 7 == 0);
        }

        // main method
        public static void Main(string[] args)
        {
            int number = 21; //number initialization

            bool result = IsMultipleOf3Or7(number); //calling method

            if (result)
            {
                Console.WriteLine($"{number} is a multiple of 3 or 7.");
            }
            else
            {
                Console.WriteLine($"{number} is not a multiple of 3 or 7.");
            }
        } // main method end
    }
}