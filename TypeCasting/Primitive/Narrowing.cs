using System;

namespace TypeCasting.Primitive
{
    class Narrowing
    {
        static void Main(string[] args)
        {
            // Explicit narrowing conversions : potential data loss
            double doubleValue = 12345.67;
            float floatValue = (float)doubleValue; // double to float
            long longValue = (long)floatValue; // float to long
            int intValue = (int)longValue; // long to int

            Console.WriteLine("Double Value: " + doubleValue);
            Console.WriteLine("Float Value (narrowed): " + floatValue);
            Console.WriteLine("Long Value (narrowed): " + longValue);
            Console.WriteLine("Integer Value (narrowed): " + intValue);
        }
    }
}