using System;

namespace ProgrammingBasics
{
    class CelciusToKelvinAndFahrenheit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature in Celsius: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double celsius))
            {
                double kelvin = celsius + 273.15;
                double fahrenheit = (celsius * 9 / 5) + 32;

                Console.WriteLine($"Temperature in Kelvin: {kelvin:F2} K");
                Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2} °F");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }
    }
}