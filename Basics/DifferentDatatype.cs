using System;

namespace Basics
{
    class DifferentDatatype
    {
        static void Main(string[] args)
        {
            // Integer variable
            int intValue = 42;
            Console.WriteLine("Integer Value: " + intValue);

            // For Double variable no need to specify 'd' suffix
            double doubleValue = 3.14159;
            Console.WriteLine("Double Value: " + doubleValue);

            //For Float variable we need to specify 'f' suffix
            float floatValue = 2.71828f;
            Console.WriteLine("Float Value: " + floatValue);

            // For Decimal variable we need to specify 'm' suffix
            decimal decimalValue = 19.99m;
            Console.WriteLine("Decimal Value: " + decimalValue);

            // Character variable
            char charValue = 'A';
            Console.WriteLine("Character Value: " + charValue);

            // String variable
            string stringValue = "Hello, World!";
            Console.WriteLine("String Value: " + stringValue);

            // Boolean variable
            bool boolValue = true;
            Console.WriteLine("Boolean Value: " + boolValue);
        }
    }
}