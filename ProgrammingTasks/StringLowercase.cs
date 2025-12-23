using System;

namespace ProgrammingTasks
{
    class StringLowercase
    {
        static void Main(string[] args) {
          Console.WriteLine("\nInput a string:"); 
          string input = Console.ReadLine();

          Console.WriteLine(result(input));
        }
        
        public static string result(string str) {
            return str.ToLower();
        }
    }
}