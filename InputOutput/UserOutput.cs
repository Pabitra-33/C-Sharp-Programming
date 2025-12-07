using System;

namespace InputOutput
{
    class UserOutput
    {
        Console.Write("Enter Your name: ");//Console.Write() is used to print something in the console and stays in the same line for new line we use Console.WriteLine().
        string name = Console.ReadLine();
        
        Console.WriteLine($"Your name is: {name}");
        Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if(age < 18){
            Console.WriteLine("You are not eligible for vote. Your age is too low!");
        }
        else{
            Console.WriteLine("You are eligible for vote");
        }
    }
}