using System;

namepspace Basics
{
    class LogicalOp
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;

            // Logical AND
            bool andResult = a && b;
            Console.WriteLine("Logical AND (a && b): " + andResult);

            // Logical OR
            bool orResult = a || b;
            Console.WriteLine("Logical OR (a || b): " + orResult);

            // Logical NOT
            bool notResult = !a;
            Console.WriteLine("Logical NOT (!a): " + notResult);
        }
    }
}