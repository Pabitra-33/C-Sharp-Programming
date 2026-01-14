using System;

namespace ProgrammingTasks
{
    //askking the user for a number and checking if it is multiple of 3 or 7
    public class MultipleOf3Or7
    {
        //method to check if number is multiple of 3 or 7
        public static bool IsMultipleOf3Or7(int number)
        {
            //checking if number is multiple of 3 or 7
            return (number % 3 == 0) || (number % 7 == 0);
        }

        // main method
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool result = IsMultipleOf3Or7(number); //calling method and storing boolean result
            
            //checking result and printing appropriate message
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