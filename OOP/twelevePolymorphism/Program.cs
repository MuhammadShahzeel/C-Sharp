using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twelevePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        // two types of polymorphisum

        // 1. compile time ==> method overloading: aik hi class my name same different parameters is my inheritence nhi hy
        // 2. runtime ==> method overriding name same method same inheritence my hoga yeh
        // public hy to public hi rehna chahiye overrite my bhi

        {
            // ===================================================
            // ⭐ POLYMORPHISM = "many forms"
            // ---------------------------------------------------
            // Parent type ka reference use karke
            // different child objects ko control karna
            // Same method naam se alag alag behavior lana
            // ===================================================

            // ====================================
            // ✅ 1️⃣ WITHOUT ARRAY EXAMPLE
            // ====================================
            Console.WriteLine("=== Without Array ===");

            // ✅ Parent type ka reference aur child object
            Vehicle vehicle1 = new Car();
            vehicle1.Go();  // Car ka Go() chalega

            Vehicle vehicle2 = new Bicycle();
            vehicle2.Go();  // Bicycle ka Go() chalega

            Vehicle vehicle3 = new Boat();
            vehicle3.Go();  // Boat ka Go() chalega

            // ✅ BENEFIT (Roman Urdu):
            // ------------------------------
            // Tumhe alag alag variable types nahi banane padte
            // Tumhara code flexible aur clean ho jata hai
            // ------------------------------

            // ====================================
            // ✅ 2️⃣ WITH ARRAY EXAMPLE
            // ====================================
            Console.WriteLine("\n=== With Array ===");

            // ✅ Sab child objects ko ek array mein store kiya
            Vehicle[] vehicles = { new Car(), new Bicycle(), new Boat() };

            // ✅ Loop se sab ka Go() method call kiya
            foreach (Vehicle v in vehicles)
            {
                v.Go();  // Har object apna Go() run karega
            }

            // ✅ BENEFIT (Roman Urdu):
            // ------------------------------
            // Tum easily 100 objects bhi handle kar sakte ho
            // Tum loop se sab ko ek hi command de sakte ho
            // Tumhara code short aur maintainable ho jata hai
            // ------------------------------

            // ====================================
            // ✅ WHY POLYMORPHISM IS USEFUL?
            // ====================================
            // ➜ Tum general code likh sakte ho jo sab child classes pe chale
            // ➜ Tum new vehicle types add kar sakte ho bina purana code change kiye
            // ➜ Example: Truck class add karo, bas override Go() likho
            // ➜ Tumhara loop same hi rahega
            // ➜ Ye real power hai: "Code reusability" + "Flexibility"
            // ===================================================

            Console.ReadKey();
        }
    }

    // ====================================================
    // ✅ Parent Class: Vehicle
    // ====================================================
    class Vehicle
    {
        // ✅ virtual = Parent ka method jo child override karega
        public virtual void Go()
        {
            Console.WriteLine("Vehicle is moving (default version)");
        }
    }

    // ====================================================
    // ✅ Child Class: Car
    // ====================================================
    class Car : Vehicle
    {
        // ✅ override = Parent ke method ka apna version
        public override void Go()
        {
            Console.WriteLine("The car is moving!");
        }
    }

    // ====================================================
    // ✅ Child Class: Bicycle
    // ====================================================
    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving!");
        }
    }

    // ====================================================
    // ✅ Child Class: Boat
    // ====================================================
    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving!");
        }
    }
}
