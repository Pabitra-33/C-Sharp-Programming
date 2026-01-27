using System;

namespace ProgrammingBasics
{
    // This program adds the first character of a given string to both the front and back of the string.
    public class AddFirstCharacterToFrontLast
    {
        //main method starts here
        static void Main(string[] args)
        {
            string str; // Declaring a variable to store the input string

            Console.Write("Input a string : ");
            str = Console.ReadLine(); // Reading the input string from the user

            // Checking if the input string has a length of at least 1 character
            if (str.Length >= 1)
            {
                var s = str.Substring(0, 1); // Extracting the first character of the string

                // Printing the string with the first character added at the beginning and end
                Console.WriteLine(s + str + s);
            }
        }
    }
}