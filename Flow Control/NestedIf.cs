using System;

namespace FlowControl
{
    class NestedIf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 0)
            {
                if (age < 13)
                {
                    Console.WriteLine("You are a child.");
                }
                else if (age >= 13 && age < 20)
                {
                    Console.WriteLine("You are a teenager.");
                }
                else
                {
                    Console.WriteLine("You are an adult.");
                }
            }
            else
            {
                Console.WriteLine("Invalid age entered.");
            }
        }
    }
}