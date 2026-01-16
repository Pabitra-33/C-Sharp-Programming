using System;

namespace ProgrammingTasks
{
    // This program displays all odd numbers from 1 to 100
    class OddNoFrom1To100
    {
        //main method
        public static void Main()
        {
            // Looping through numbers from 1 to 100
            for (int i = 1; i <= 100; i++)
            {
                // Checking if the number is odd
                if (i % 2 != 0)
                {
                    Console.WriteLine(i); // Displaying the odd number
                }
            }
        }// End of Main method
    }
}