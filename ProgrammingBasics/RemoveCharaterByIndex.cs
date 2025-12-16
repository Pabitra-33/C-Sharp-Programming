using System;

namespace ProgrammingBasics
{
    class RemoveCharacterByIndex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();

            Console.WriteLine("Enter the index of the character to remove:");
            int index;
            while (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= inputString.Length)
            {
                Console.WriteLine("Invalid index. Please enter a valid index:");
            }

            string resultString = RemoveCharacterAtIndex(inputString, index);
            Console.WriteLine("Resulting string: " + resultString);
        }

        static string RemoveCharacterAtIndex(string str, int index)
        {
            return str.Remove(index, 1);
        }
    }
}