using System;

namespace FlowControl
{
    class IfElseIfLadder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your score (0-100): ");
            int score = Convert.ToInt32(Console.ReadLine());
            char grade;

            if (score >= 90 && score <= 100)
            {
                grade = 'A';
            }
            else if (score >= 80 && score < 90)
            {
                grade = 'B';
            }
            else if (score >= 70 && score < 80)
            {
                grade = 'C';
            }
            else if (score >= 60 && score < 70)
            {
                grade = 'D';
            }
            else if (score >= 0 && score < 60)
            {
                grade = 'F';
            }
            else
            {
                Console.WriteLine("Invalid score entered.");
                return;
            }

            Console.WriteLine($"Your grade is: {grade}");
        }
    }
}