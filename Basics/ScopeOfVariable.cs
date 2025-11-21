using System;

nampespace Basics
{
    class InputOutput
    {
        int myGlobalVar = 10; // Global variable

        static void Main(string[] args)
        {
            int myLocalVar = 20; // Local variable
            Console.WriteLine("Global Variable: " + new InputOutput().myGlobalVar);
            Console.WriteLine("Local Variable: " + myLocalVar);

            {
                int blockVar = 30; // Block scope variable
                Console.WriteLine("Block Variable: " + blockVar);
            }
            // Console.WriteLine("Block Variable: " + blockVar); // This will cause an error
        }
    }
}