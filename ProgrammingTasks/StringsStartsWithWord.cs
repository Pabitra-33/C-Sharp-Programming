using System;

namespace ProgrammingTasks
{
    public class StringsStartsWithWord
    {
        public static bool StartsWithWord(string str, string word)
        {
            if (str == null || word == null)
            {
                return false;
            }

            return str.StartsWith(word, StringComparison.Ordinal);
        }

       //main method
        public static void Main(string[] args)
        {
            Console.WriteLine(StartsWithWord("hello world", "hello")); // True
            Console.WriteLine(StartsWithWord("hello world", "world")); // False
            Console.WriteLine(StartsWithWord("hello world", ""));      // True
            Console.WriteLine(StartsWithWord(null, "hello"));          // False
            Console.WriteLine(StartsWithWord("hello world", null));    // False
        } 
    }
}