using System;

namespace ProgrammingTasks
{
    class StringLowercase
    {
        // Main method
        static void Main(string[] args) {
          Console.WriteLine("\nInput a string:"); 
          string input = Console.ReadLine();

          Console.WriteLine(result(input));
        }
        
        //convert a string to lowercase
        public static string result(string str) {
            return str.ToLower();
        }
    }
}