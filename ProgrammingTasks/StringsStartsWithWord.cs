using System;

namespace ProgrammingTasks
{
    // This program checks if a string starts with a specified word
    public class StringsStartsWithWord
    {
        //method to check if a string starts with a specified word
        public static bool StartsWithWord(string str, string word)
        {
            //handle null cases
            if (str == null || word == null)
            {
                return false;//return false if either string is null
            }
            //check if str starts with word
            return str.StartsWith(word, StringComparison.Ordinal);
        }

       //main method
        public static void Main(string[] args)
        {
            //test cases
            Console.WriteLine(StartsWithWord("hello world", "hello")); // True
            Console.WriteLine(StartsWithWord("hello world", "world")); // False
            Console.WriteLine(StartsWithWord("hello world", ""));      // True
            Console.WriteLine(StartsWithWord(null, "hello"));          // False
            Console.WriteLine(StartsWithWord("hello world", null));    // False
        } 
    }
}