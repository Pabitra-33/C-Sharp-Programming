using System;

namepspace Basics
{
    class StringConcatenationOp
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";

            // Concatenation using + operator
            string result = str1 + ", " + str2 + "!";
            Console.WriteLine("Concatenated String: " + result);
        }
    }
}