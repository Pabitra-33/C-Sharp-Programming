using System;

namespace ProgrammingBasics
{
    class PrintAgeMessage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");

            // Read age from the user
            int age = Convert.ToInt32(Console.ReadLine());

            // Display the message
            Console.WriteLine(age > 20 ? "You are an adult." : "You are a minor.");
        }
    }
}