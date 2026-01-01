using System;

namespace ProgrammingTasks
{
    public class MultiplyingTwoArray
    {
        public static int[] MultiplyArrays(int[] array1, int[] array2)
        {
            //checking for null arrays
            if (array1 == null || array2 == null)
            {
                throw new ArgumentNullException("Input arrays cannot be null.");
            }

            //checking if both arrays have the same length
            if (array1.Length != array2.Length)
            {
                throw new ArgumentException("Input arrays must have the same length.");
            }

            int[] resultArray = new int[array1.Length];\

            //traversing through arrays and multiplying elements
            for (int i = 0; i < array1.Length; i++)
            {
                resultArray[i] = array1[i] * array2[i];
            }

            return resultArray;//returning resultant array
        }

        // main method
        public static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4 };//array1 initialization
            int[] array2 = { 5, 6, 7, 8 };//array2 initialization

            try
            {
                int[] resultArray = MultiplyArrays(array1, array2);//calling method
                Console.WriteLine("Resultant Array: " + string.Join(", ", resultArray));
                //joining array elements to print
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }// main method end
    }
}