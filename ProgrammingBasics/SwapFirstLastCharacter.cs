using System;

namespace ProgrammingBasics
{
    class SwapFirstLastCharacter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) || input.Length == 1)
            {
                Console.WriteLine("Output: " + input);
            }
            else
            {
                char firstChar = input[0];
                char lastChar = input[input.Length - 1];
                string middleSubstring = input.Substring(1, input.Length - 2);

                string result = lastChar + middleSubstring + firstChar;
                Console.WriteLine("Output: " + result);
            }
        }
    }
}