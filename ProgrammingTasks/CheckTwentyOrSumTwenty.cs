using System;

namespace ProgrammingTasks
{
    class CheckTwentyOrSumTwenty
    {
        //main method to test the function
        static void Main(string[] args)
        {
            Console.WriteLine(CheckTwentyOrSum(10, 10)); // Output: True
            Console.WriteLine(CheckTwentyOrSum(15, 5));  // Output: True
            Console.WriteLine(CheckTwentyOrSum(8, 7));   // Output: False
        }

        public static bool CheckTwentyOrSum(int a, int b)
        {
            // Check if either 'a' or 'b' is 20, or if their sum equals 20
            return a == 20 || b == 20 || (a + b) == 20;
        }
    }
}