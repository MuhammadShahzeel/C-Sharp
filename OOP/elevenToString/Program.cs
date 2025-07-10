using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace elevenToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =============================
            // PART 1: Without ToString() Override
            // =============================

            Console.WriteLine("=== PART 1: Without ToString() override ===");

            SimpleCar simpleCar = new SimpleCar("Toyota", "Camry", 2020, "White");

            // Jab hum object ko print karte hain aur usme ToString() override nahi hota
            // Tab yeh default Object.ToString() use karta hai jo sirf class ka naam deta hai
            Console.WriteLine(simpleCar);  // Output: MyFirstProgram.SimpleCar

            // =============================
            // PART 2: With ToString() Override
            // =============================

            Console.WriteLine("\n=== PART 2: With ToString() override ===");

            Car car = new Car("Chevy", "Corvette", 2022, "Blue");

            // Ab humari class mein ToString() override kia gaya hai
            // Isliye jab hum object print karte hain toh woh humara custom text return karta hai
            Console.WriteLine(car);  // Output: This is a Chevy Corvette
        }
    }

    // ====================================
    // Class WITHOUT ToString() override
    // ====================================
    class SimpleCar
    {
        String make;
        String model;
        int year;
        String color;

        public SimpleCar(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        // ❌ ToString() override nahi hai
        // Isliye Console.WriteLine(simpleCar) likhne par default class ka naam print hota hai
    }

    // ====================================
    // Class WITH ToString() override
    // ====================================
    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        // ✅ Humne ToString() override kia
        // Iska faida: Jab bhi object print hoga yeh custom text return karega
        public override string ToString()
        {
            // Tum jo bhi return karoge wahi Console.WriteLine mein print hoga
            return "This is a " + make + " " + model + " (" + year + ") in " + color + " color.";
        }
    }
}
