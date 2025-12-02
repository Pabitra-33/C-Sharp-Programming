using System;

namespace FlowControl
{
    class ForEachLoop
    {
        static void Main(string[] args)
        {
            string[] fruits = { "Apple", "Banana", "Cherry", "Date" };

            Console.WriteLine("Fruits in the array:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}