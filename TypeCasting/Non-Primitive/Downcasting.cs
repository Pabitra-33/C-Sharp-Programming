using System;

nampespace TypeCasting.Non_Primitive
{
    // Base class
    class Animal
    {
        public void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }

    // Derived class
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the base class
            Animal myAnimal = new Animal();

            // Downcasting: Explicitly converting base class to derived class
            Dog myDog = (Dog)myAnimal;

            // Calling method from the derived class
            myDog.Bark();
        }
    }
}