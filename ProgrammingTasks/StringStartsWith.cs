using System;

namespace ProgrammingTasks
{
    // This program checks if a string starts with the letter 'a' or 'A'
    public class StringStartsWith
    {
        // method to check if string starts with 'a' or 'A'
        public static bool DoesStringStartsWith(string input){
            if(string.IsNullOrEmpty(input)){
                return false; // return false for null or empty strings
            }
            //checking if string starts with 'a' or 'A'
            return input.StartsWith("a", StringComparison.OrdinalIgnoreCase);
        }
        // main method
        public static void Main(string[] args)
        {
            string input = "apple"; //string initialization

            bool result = DoesStringStartsWith(input); //calling method

            //printing result
            if (result)
            {
                Console.WriteLine($"\"{input}\" starts with 'a' or 'A'.");
            }
            else
            {
                Console.WriteLine($"\"{input}\" does not start with 'a' or 'A'.");
            }
        } // main method end
    }
}