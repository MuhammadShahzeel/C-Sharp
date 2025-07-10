using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourWithStatic
{
    internal class CarWS
    {
        // ⭐ Static = belongs to the class.
        //    ➡️ Only one copy.
        //    ➡️ Access with class name.
        //    ➡️ No need to create an object.

        public string model;

        // ============================
        // Static variable
        // ============================
        // Shared by all Car objects
        public static int numberOfCars;

        // ============================
        // Constructor
        // ============================
        // Runs every time you create a new Car
        public CarWS(string model)
        {
            this.model = model;  // Sets this car's unique model
            numberOfCars++;         // Increments shared static counter
        }

        // ============================
        // Static method
        // ============================
        // Belongs to the class, not to any object
        // Can be called without creating an object
        public static void AnnounceRace()
        {
            Console.WriteLine("Get ready! The race is starting!");
        }
    }
}
