using System;

namespace Basics
{
    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class EnumExample
    {
        static void Main(string[] args)
        {
            DaysOfWeek today = DaysOfWeek.Wednesday;
            Console.WriteLine("Today is: " + today);

            // Converting enum to int
            int dayValue = (int)today;
            Console.WriteLine("Numeric value of today: " + dayValue);

            // Converting int to enum
            DaysOfWeek anotherDay = (DaysOfWeek)5;
            Console.WriteLine("The day with numeric value 5 is: " + anotherDay);
        }
    }
}