using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenMethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ⭐ Example 1: Method Overriding using virtual/override
            Console.WriteLine("=== Example 1: Virtual / Override ===");

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak(); // Overridden version
            cat.Speak(); // Base class version

            // ⭐ Example 2: Method Overriding with Abstract Class
            Console.WriteLine("\n=== Example 2: Abstract Class / Override ===");

            // Abstract class ka object nahi banta, isliye AnimalBase a = new AnimalBase(); nahi chalega
            // Hum derived class ka object banayenge:

            Dog2 dog2 = new Dog2();
            Cat2 cat2 = new Cat2();

            dog2.Speak();
            cat2.Speak();

        }
    }
    }

// ================================================================
// ✅ Example 1: virtual / override method
// ================================================================

class Animal
{
    // virtual = allow derived classes to override this method
    public virtual void Speak()
    {
        Console.WriteLine("The animal goes *brrr*");
    }
}

class Dog : Animal
{
    // override = new version of Speak
    public override void Speak()
    {
        Console.WriteLine("The dog goes *woof*");
    }
}

class Cat : Animal
{
    // No override here, uses base class method
    // Speak() is not redefined here, so Cat uses Animal's Speak()
}

// ================================================================
// ✅ Example 2: abstract class / abstract method
// ================================================================

// abstract class = cannot be instantiated directly
// abstract method = MUST be overridden in derived classes
abstract class AnimalBase
{
    public abstract void Speak();  // No body here
}

class Dog2 : AnimalBase
{
    // MUST override
    public override void Speak()
    {
        Console.WriteLine("The dog says *woof woof* (abstract override)");
    }
}

class Cat2 : AnimalBase
{
    // MUST override
    public override void Speak()
    {
        Console.WriteLine("The cat says *meow* (abstract override)");
    }
}
