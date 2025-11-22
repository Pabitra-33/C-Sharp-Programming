using System;

namespace Basics
{
    class ConstantsExample
    {
        const double Pi = 3.14159; // Constant variable

        static void Main(string[] args)
        {
            Console.WriteLine("Value of Pi: " + Pi);
            // Pi = 3.14; // This will cause a compile-time error
        }
    }
}