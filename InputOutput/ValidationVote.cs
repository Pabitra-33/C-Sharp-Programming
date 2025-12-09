using System;

namespace InputOutput
{
    class ValidationVote
    {
        static void Main(){
            Console.WriteLine("Enter your age: ");
            int age = Convert.Int32(Console.ReadLine());
            Console.WriteLine(age >= 18 ? "Eligible to vote":"Not Eligible to vote");
        }
    }
}