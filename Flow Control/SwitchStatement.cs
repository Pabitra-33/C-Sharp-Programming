using System;

namespace FlowControl
{
    class SwichStatement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 5: ");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("You entered One.");
                    break;
                case 2:
                    Console.WriteLine("You entered Two.");
                    break;
                case 3:
                    Console.WriteLine("You entered Three.");
                    break;
                case 4:
                    Console.WriteLine("You entered Four.");
                    break;
                case 5:
                    Console.WriteLine("You entered Five.");
                    break;
                default:
                    Console.WriteLine("Number out of range.");
                    break;
            }
        }
    }
}