using System;

nampespace TypeCasting.Primitive
{
    class Widening
    {
        static void Main(string[] args)
        {
            // Implicit widening conversions : no data loss
            int intValue = 100;
            long longValue = intValue; // int to long
            float floatValue = longValue; // long to float
            double doubleValue = floatValue; // float to double

            Console.WriteLine("Integer Value: " + intValue);
            Console.WriteLine("Long Value (widened): " + longValue);
            Console.WriteLine("Float Value (widened): " + floatValue);
            Console.WriteLine("Double Value (widened): " + doubleValue);
        }
    }
}