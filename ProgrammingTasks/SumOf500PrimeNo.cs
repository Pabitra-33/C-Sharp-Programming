using System;

namespace ProgrammingTasks
{
    public static void Main() 
    {     
        Console.WriteLine("\nSum of the first 500 prime numbers: ");

        int sum = 0;
        int counter = 0; 
        int n = 2; // Starting from the first prime number

        // Looping to find and sum the first 500 prime numbers
        while (counter < 500)
        {
            if (isPrime(n)) // Checking if 'n' is a prime number by calling the 'isPrime' method
            {
                sum += n; // Adding the prime number 'n' to the sum
                counter++; // Incrementing the counter of prime numbers found
            }
            n++; // Moving to the next number for evaluation
        }

        Console.WriteLine(sum); // Displaying the sum
    }

    // Method to check if a number is prime
    public static bool isPrime(int num)
    {
        int root = (int)Math.Floor(Math.Sqrt(num)); // Calculating the square root of 'num'

        if (num == 1) return false; // 1 is not a prime number
        if (num == 2) return true; // 2 is a prime number

        // Loop to check if 'num' is divisible by any number from 2 to square root of 'num'
        for (int i = 2; i <= root; ++i)
        {
            if (num % i == 0) return false; // If 'num' is divisible by 'i', it's not a prime number
        }

        return true; // 'n' is prime if not divisible by any number except 1 and itself
    }
}