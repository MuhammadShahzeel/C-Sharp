using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace sevenAbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ===========================
            // ⭐ ABSTRACT CLASS EXAMPLE
            // ===========================
            // Abstract class ka object nahi bana sakte
            // Vehicle vehicle = new Vehicle(); // ❌ Error

            // ✔️ Lekin child classes ka object bana sakte hain
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            // ===========================
            // ⭐ Accessing Inherited + Own Members
            // ===========================
            Console.WriteLine("=== CAR ===");
            Console.WriteLine("Speed: " + car.speed);
            Console.WriteLine("Wheels: " + car.wheels);
            Console.WriteLine("Max Speed: " + car.maxSpeed);
            car.go();

            Console.WriteLine("\n=== BICYCLE ===");
            Console.WriteLine("Speed: " + bicycle.speed);
            Console.WriteLine("Wheels: " + bicycle.wheels);
            Console.WriteLine("Max Speed: " + bicycle.maxSpeed);
            bicycle.go();

            Console.WriteLine("\n=== BOAT ===");
            Console.WriteLine("Speed: " + boat.speed);
            Console.WriteLine("Wheels: " + boat.wheels);
            Console.WriteLine("Max Speed: " + boat.maxSpeed);
            boat.go();
        }
    }


    // ================================================================
    // ⭐ ABSTRACT CLASS
    // ================================================================
    // ➜ Abstract class = Incomplete design / Idea
    // ➜ Object nahi bana sakte
    // ➜ Child classes inherit karti hain
    // ➜ Common fields/methods define karti hai
    // ➜ Syntax: abstract class ClassName
    abstract class Vehicle
    {
        // ==============================
        // ⭐ Common Field
        // ==============================
        public int speed = 0;
        // Sab vehicles ki speed hoti hai

        // ==============================
        // ⭐ Common Method
        // ==============================
        public void go()
        {
            // Sab vehicles move karte hain
            Console.WriteLine("This vehicle is moving!");
        }
    }

    // ================================================================
    // ⭐ CHILD CLASS 1: Car
    // ================================================================
    // ➜ Inherits Vehicle
    // ➜ Apni properties bhi rakhti hai
    class Car : Vehicle
    {
        // Inherited: speed, go()
        // Own properties:
        public int wheels = 4;
        public int maxSpeed = 500;
    }

    // ================================================================
    // ⭐ CHILD CLASS 2: Bicycle
    // ================================================================
    // ➜ Inherits Vehicle
    class Bicycle : Vehicle
    {
        // Inherited: speed, go()
        // Own properties:
        public int wheels = 2;
        public int maxSpeed = 50;
    }

    // ================================================================
    // ⭐ CHILD CLASS 3: Boat
    // ================================================================
    // ➜ Inherits Vehicle
    class Boat : Vehicle
    {
        // Inherited: speed, go()
        // Own properties:
        public int wheels = 0;
        public int maxSpeed = 100;
    }
}
