using System;

namespace ProgrammingTasks
{
    public class ReversingWordSentence
    {
        public static string ReverseWordsInSentence(string sentence)
        {
            //checking for null or empty string
            if (string.IsNullOrWhiteSpace(sentence)) {
                return sentence;
            }

            // Split the sentence into words, reverse the array of words, and join them back into a string
            string[] words = sentence.Split(' ');
            Array.Reverse(words);// Reversing the array of words
            return string.Join(" ", words);// Joining the reversed words back into a single string
        }

        public static void Main(string[] args)
        {
            string sentence = "Hello World from C#";//given sentence
            string reversed = ReverseWordsInSentence(sentence);
            Console.WriteLine(reversed); // Output: "C# from World Hello"
        }
    }
}