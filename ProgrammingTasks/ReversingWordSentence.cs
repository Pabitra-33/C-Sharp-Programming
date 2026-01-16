using System;

namespace ProgrammingTasks
{
    // This program reverses the order of words in a given sentence
    public class ReversingWordSentence
    {
        // Method to reverse the words in a sentence
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

        //main method
        public static void Main(string[] args)
        {
            string sentence = "Hello World from C#";//given sentence
            string reversed = ReverseWordsInSentence(sentence);
            Console.WriteLine(reversed); // Output: "C# from World Hello"
        }//main end
    }
}