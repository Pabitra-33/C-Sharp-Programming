using System;

namespace ProgrammingTasks
{
    public class HexadecimalToDecimal
    {
        public static int ConvertHexToDecimal(string hexString)
        {
            if (string.IsNullOrEmpty(hexString))
            {
                throw new ArgumentException("Input cannot be null or empty.", nameof(hexString));
            }

            int decimalValue = 0;
            int baseValue = 1; // 16^0

            for (int i = hexString.Length - 1; i >= 0; i--)
            {
                char hexChar = hexString[i];
                int hexDigit;

                if (hexChar >= '0' && hexChar <= '9')
                {
                    hexDigit = hexChar - '0';
                }
                else if (hexChar >= 'A' && hexChar <= 'F')
                {
                    hexDigit = hexChar - 'A' + 10;
                }
                else if (hexChar >= 'a' && hexChar <= 'f')
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

            return decimalValue;
        }

        public static void Main(string[] args)
        {
            string hexString = "1A3F";

            try
            {
                int decimalValue = ConvertHexToDecimal(hexString);
                Console.WriteLine($"The decimal value of hexadecimal '{hexString}' is {decimalValue}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}