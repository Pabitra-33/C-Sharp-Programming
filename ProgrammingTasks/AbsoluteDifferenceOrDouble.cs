using System;

namespace ProgrammingTasks
{
    static void Main(string[] args)
    {
        Console.WriteLine(AbsoluteDifferenceOrDouble(5, 8));  // Output: 3
        Console.WriteLine(AbsoluteDifferenceOrDouble(10, 4)); // Output: 6
        Console.WriteLine(AbsoluteDifferenceOrDouble(7, 7));  // Output: 0
    }
    public static int AbsoluteDifferenceOrDouble(int a, int b)
    {
        if (a > b)
        {
            // If 'a' is greater than 'b', return the difference of 'a' and 'b' multiplied by 2
            return (a - b) * 2;
        }
        // If 'a' is not greater than 'b', return the difference of 'b' and 'a'
        return b - a;
    }
}