using System;

namespace ProgrammingTasks
{
    // This program converts a given string to lowercase
    public class StringLowercase
    {
        // Main method
        static void Main(string[] args) {
          Console.WriteLine("\nInput a string:"); 
          string input = Console.ReadLine();//read input from user

          Console.WriteLine(result(input));
        }
        
        //convert a string to lowercase
        public static string result(string str) {
            return str.ToLower();//converting to lowercase
        }
    }
}