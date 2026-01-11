using System;

namespace ProgrammingTasks
{
    public class HexadecimalToDecimal
    {
        public static int ConvertHexToDecimal(string hexString)
        {
            // Validate input
            if (string.IsNullOrEmpty(hexString))
            {
                // Throw an exception if the input string is null or empty
                throw new ArgumentException("Input cannot be null or empty.", nameof(hexString));
            }

            int decimalValue = 0;
            int baseValue = 1; // 16^0

            // Process each character from right to left
            for (int i = hexString.Length - 1; i >= 0; i--)
            {
                char hexChar = hexString[i];
                int hexDigit;

                // Convert hex character to its decimal equivalent
                if (hexChar >= '0' && hexChar <= '9')
                {
                    hexDigit = hexChar - '0';
                }
                else if (hexChar >= 'A' && hexChar <= 'F') // Uppercase letters
                {
                    hexDigit = hexChar - 'A' + 10;
                }
                else if (hexChar >= 'a' && hexChar <= 'f') // Lowercase letters
                {
                    hexDigit = hexChar - 'a' + 10;
                }
                else
                {
                    throw new FormatException($"Invalid hexadecimal character: {hexChar}");
                }

                decimalValue += hexDigit * baseValue;
                baseValue *= 16;
            }

            return decimalValue;// Return the decimal value
        }

        // Main method to test the function
        public static void Main(string[] args)
        {
            string hexString = "1A3F";//given hexadecimal string

            // Convert and display the decimal value
            try
            {
                int decimalValue = ConvertHexToDecimal(hexString);
                Console.WriteLine($"The decimal value of hexadecimal '{hexString}' is {decimalValue}.");
            }
            catch (Exception ex)  // Catch any exceptions and display the message
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}