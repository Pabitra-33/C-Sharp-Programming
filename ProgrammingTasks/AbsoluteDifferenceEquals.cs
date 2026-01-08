using System;

namespace ProgrammingTasks
{
    // checking if the absolute difference between n and 100 or 200 is within 20
    class AbsoluteDifferenceEquals
    {
        static void Main(string[] args) {
          Console.WriteLine("\nInput an integer:"); 
          int x = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine(result(x));
        }
        
        //method to check the absolute difference condition
        public static bool result(int n) {
            if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20){
                return true;//returning true if condition is met
            }
         return false;
        }
    }
}