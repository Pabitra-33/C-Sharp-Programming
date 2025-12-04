using System;

namespace TypeCasting.Non_Primitive
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
            // Creating an instance of the derived class
            Dog myDog = new Dog();

            // Upcasting: Implicitly converting derived class to base class
            Animal myAnimal = myDog;

            // Calling method from the base class
            myAnimal.Speak();
        }
    }
}