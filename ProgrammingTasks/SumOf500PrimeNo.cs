using System;

namespace ProgrammingTasks
{
    public static void Main() 
    {     
        Console.WriteLine("\nSum of the first 500 prime numbers: ");

        int sum = 0;
        int counter = 0; 
        int n = 2; // Starting from the first prime number

        // Loop to find and sum the first 500 prime numbers
        while (counter < 500)
        {
            if (isPrime(n)) // Checking if 'n' is a prime number by calling the 'isPrime' method
            {
                sum += n; // Adding the prime number 'n' to the sum
                counter++; // Incrementing the counter of prime numbers found
            }
            n++; // Moving to the next number for evaluation
        }

        Console.WriteLine(sum); // Displaying the sum of the first 500 prime numbers
    }

    // Method to check if a number is prime
    public static bool isPrime(int n)
    {
        int x = (int)Math.Floor(Math.Sqrt(n)); // Calculating the square root of 'n'

        if (n == 1) return false; // 1 is not a prime number
        if (n == 2) return true; // 2 is a prime number

        // Loop to check if 'n' is divisible by any number from 2 to square root of 'n'
        for (int i = 2; i <= x; ++i)
        {
            if (n % i == 0) return false; // If 'n' is divisible by 'i', it's not a prime number
        }

        return true; // 'n' is prime if not divisible by any number except 1 and itself
    }
}