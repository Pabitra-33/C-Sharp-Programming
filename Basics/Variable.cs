using System;

nampespace Basics
{
    class InputOutput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");

            Console.WriteLine("Enter your age:");
            string ageInput = Console.ReadLine();
            int age = int.Parse(ageInput);
            Console.WriteLine("You are " + age + " years old.");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}