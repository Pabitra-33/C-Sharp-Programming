using System;

namespace ProgrammingBasics
{
    class TripleSumOfIntegers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first integer: ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second integer: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(TripleSum(input1, input2));
        }
        public static int SumTriple(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b; // If 'a' equals 'b', return the triple sum of 'a' and 'b', otherwise return their sum 
        }
    }
}