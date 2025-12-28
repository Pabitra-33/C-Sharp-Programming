using System;

namespace ProgrammingTasks
{
    public class ReversingWordSentence
    {
        public static string ReverseWordsInSentence(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                return sentence;
            }

            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        public static void Main(string[] args)
        {
            string sentence = "Hello World from C#";
            string reversed = ReverseWordsInSentence(sentence);
            Console.WriteLine(reversed); // Output: "C# from World Hello"
        }
    }
}