using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sixteenAutoIMplementedProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ============================================================
            // ⭐ Auto-Implemented Properties Example
            // ============================================================
            // ✔️ Constructor ke through Model set ho raha hai
            // ✔️ Property se Model get ho raha hai
            // ✔️ Short aur clean syntax
            // ============================================================

            Car car = new Car("Porsche");

            Console.WriteLine("Car Model: " + car.Model);

            Console.ReadKey();
        }
    }

    // ============================================================
    // ⭐ TRADITIONAL (LONG) WAY (Roman Urdu explanation in comments)
    // ============================================================
    /*
    class Car
    {
        // ✅ Private field manually define karni parti hai
        private string model;

        // ✅ Property with explicit getter and setter
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        // ✅ Constructor
        public Car(string model)
        {
            // Setter call hota hai yahan bhi
            Model = model;
        }
    }
    */

    // ============================================================
    // ⭐ AUTO-IMPLEMENTED PROPERTY WAY
    // ============================================================
    // ✔️ Short and clean syntax
    // ✔️ Compiler khud ek private hidden field bana leta hai
    // ✔️ Tum sirf { get; set; } likhte ho
    // ✔️ Jab koi extra logic/validation nahi chahiye ho
    //    tab best hota hai
    // ============================================================
    class Car
    {
        // ⭐ Auto-implemented property
        public string Model { get; set; }

        // ✅ Constructor
        public Car(string model)
        {
            // Setter call hota hai yahan bhi
            Model = model;
        }
    }

    // ============================================================
    // ⭐ Roman Urdu Summary (Already in Comments):
    // ============================================================
    /*
     Traditional Way:
     ----------------
     - Private field manually banana padta hai
     - Getter aur Setter likhne padte hain
     - Tab use hota hai jab validation ya extra logic chahiye ho

     Auto-Implemented Property:
     --------------------------
     - Short aur clean
     - Compiler automatically private backing field banata hai
     - Sirf get; set; likho
     - Jab koi extra logic nahi ho to perfect choice hai

     ⭐ Encapsulation dono mein hoti hai
    */
}






//also like this  
//using System;

//namespace TraditionalPropertyExample
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // ============================================================
//            // ⭐ Traditional property set karna (WITHOUT constructor parameter)
//            // ============================================================

//            // ✅ 1. Object create kiya
//            Car car = new Car();

//            // ✅ 2. Property set ki (setter call hua)
//            car.Model = "Suzuki";

//            // ✅ 3. Property get ki (getter call hua)
//            Console.WriteLine("Car Model: " + car.Model);

//            Console.ReadKey();
//        }
//    }

//    // ============================================================
//    // ⭐ Class with Auto-Implemented Property (No constructor needed)
//    // ============================================================
//    class Car
//    {
//        // ✅ Auto-implemented property
//        public string Model { get; set; }
//    }
//}

