using System;

namespace InputOutput
{
    class UserInput
    {
        static void Main(){
            Console.WriteLine("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Number is: "+input);
        }
    }
}