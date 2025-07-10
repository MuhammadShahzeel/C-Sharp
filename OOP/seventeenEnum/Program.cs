using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seventeenEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ============================================================
            // ⭐ ENUMS kya hotay hain? (Roman Urdu Explanation)
            // ------------------------------------------------------------
            // enum = enumeration = ek special type jo named constants rakhta hai
            // ✔️ Tum fixed, predefined options ko naam de sakte ho
            // ✔️ Code readable aur maintainable ho jata hai
            // ✔️ Magic numbers avoid hote hain
            // 
            // Example: enum WeekDays { Monday, Tuesday, ... }
            // ============================================================

            // ⭐ Planets enum ka use
            // Planets enum mein har planet ka ek number hai
            Console.WriteLine(Planets.Mercury + " is planet #" + (int)Planets.Mercury);
            Console.WriteLine(Planets.Pluto + " is planet #" + (int)Planets.Pluto);
            Console.WriteLine();

            // ⭐ PlanetRadius enum ka use
            // PlanetRadius enum har planet ka radius (km) store karta hai
            // ✔️ Tum naam se uska numeric value nikal sakte ho

            // 1️⃣ Naam nikalna
            string name = PlanetRadius.Earth.ToString();

            // 2️⃣ Radius as int
            int radius = (int)PlanetRadius.Earth;

            // 3️⃣ Volume calculate karna
            double volume = Volume(PlanetRadius.Earth);

            // ⭐ Output
            Console.WriteLine("Planet: " + name);
            Console.WriteLine("Radius: " + radius + " km");
            Console.WriteLine("Volume: " + volume + " km^3");

            Console.ReadKey();
        }

        // ============================================================
        // ⭐ Function to Calculate Volume
        // ------------------------------------------------------------
        // Formula: Volume of Sphere = (4/3) * π * r³
        // ------------------------------------------------------------
        // Hum radius enum se lete hain, usay int mein cast karte hain
        // Phir volume calculate karte hain
        // ============================================================
        public static double Volume(PlanetRadius radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }
    }

    // ============================================================
    // ⭐ Planets Enum
    // ------------------------------------------------------------
    // ✔️ Simple mapping: Planet Name ➜ Planet Number
    // ✔️ Useful for indexing / numbering
    // ✔️ Fixed set of values
    // Example: Planets.Mercury ➜ Mercury
    //          (int)Planets.Mercury ➜ 1
    // ============================================================
    enum Planets
    {
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Neptune = 8,
        Pluto = 9
    }

    // ============================================================
    // ⭐ PlanetRadius Enum
    // ------------------------------------------------------------
    // ✔️ Stores radius of planets in kilometers
    // ✔️ Fixed, constant values
    // ✔️ Tumhara code readable aur safe ho jata hai
    // ✔️ Magic numbers avoid hote hain
    // Example:
    // PlanetRadius.Earth ➜ Earth
    // (int)PlanetRadius.Earth ➜ 6371
    // ============================================================
    enum PlanetRadius
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }
}
