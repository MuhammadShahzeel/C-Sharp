using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 1️⃣ INTRODUCTION TO DICTIONARY
            // ==========================================================
            // Dictionary ek collection hai jo key-value pairs store karti hai.
            // Keys unique hoti hain.
            // Fast lookup ke liye hashing use hota hai.

            Console.WriteLine("=== 1. INTRODUCTION ===\n");
            Console.WriteLine("Dictionary = Key-Value pair collection (Keys unique hoti hain)\n");



            // ==========================================================
            // 2️⃣ DICTIONARY CREATION
            // ==========================================================
            Console.WriteLine("=== 2. DICTIONARY CREATION ===\n");

            // Empty dictionary
            Dictionary<int, string> studentNames = new Dictionary<int, string>();

            // Initialize with values
            Dictionary<string, string> countryCodes = new Dictionary<string, string>
            {
                { "PK", "Pakistan" },
                { "IN", "India" },
                { "US", "United States" }
            };

            Console.WriteLine("CountryCodes Dictionary:");
            foreach (var pair in countryCodes)
            {
                Console.WriteLine(pair.Key + " : " + pair.Value);
            }



            // ==========================================================
            // 3️⃣ ADDING ELEMENTS
            // ==========================================================
            Console.WriteLine("\n=== 3. ADDING ELEMENTS ===\n");

            studentNames.Add(1, "Ali");
            studentNames.Add(2, "Ahmed");
            studentNames.Add(3, "Sara");

            Console.WriteLine("StudentNames Dictionary after Add():");
            foreach (var pair in studentNames)
            {
                Console.WriteLine(pair.Key + " : " + pair.Value);
            }



            // ==========================================================
            // 4️⃣ ACCESSING VALUES
            // ==========================================================
            Console.WriteLine("\n=== 4. ACCESSING VALUES ===\n");

            string name1 = studentNames[1];
            Console.WriteLine("Student with Roll No 1: " + name1);

            // If key not exists, direct access gives error:
            // Console.WriteLine(studentNames[99]); // ❌ Error



            // ==========================================================
            // 5️⃣ TRYGETVALUE (Safe Access)
            // ==========================================================
            Console.WriteLine("\n=== 5. TRYGETVALUE METHOD ===\n");

            if (studentNames.TryGetValue(2, out string studentName))
            {
                Console.WriteLine("Found: " + studentName);
            }
            else
            {
                Console.WriteLine("Not found");
            }

            if (studentNames.TryGetValue(99, out string notFoundName))
            {
                Console.WriteLine("Found: " + notFoundName);
            }
            else
            {
                Console.WriteLine("Key 99 not found");
            }



            // ==========================================================
            // 6️⃣ UPDATING VALUE
            // ==========================================================
            Console.WriteLine("\n=== 6. UPDATING VALUE ===\n");

            studentNames[1] = "Ali Updated";
            Console.WriteLine("After Updating Roll No 1:");
            foreach (var pair in studentNames)
            {
                Console.WriteLine(pair.Key + " : " + pair.Value);
            }



            // ==========================================================
            // 7️⃣ REMOVING ELEMENT
            // ==========================================================
            Console.WriteLine("\n=== 7. REMOVING ELEMENT ===\n");

            studentNames.Remove(2);
            Console.WriteLine("After Removing Roll No 2:");
            foreach (var pair in studentNames)
            {
                Console.WriteLine(pair.Key + " : " + pair.Value);
            }



            // ==========================================================
            // 8️⃣ CHECKING IF KEY EXISTS
            // ==========================================================
            Console.WriteLine("\n=== 8. CHECKING KEY EXISTS ===\n");

            Console.WriteLine("Contains Key 1: " + studentNames.ContainsKey(1));
            Console.WriteLine("Contains Key 2: " + studentNames.ContainsKey(2));



            // ==========================================================
            // 9️⃣ COUNT PROPERTY
            // ==========================================================
            Console.WriteLine("\n=== 9. COUNT PROPERTY ===\n");

            Console.WriteLine("Total Students: " + studentNames.Count);



            // ==========================================================
            // 1️⃣0️⃣ LOOPING THROUGH DICTIONARY
            // ==========================================================
            Console.WriteLine("\n=== 10. LOOPING DICTIONARY ===\n");

            Console.WriteLine("Using foreach:");
            foreach (var pair in studentNames)
            {
                Console.WriteLine("RollNo " + pair.Key + ": " + pair.Value);
            }

            Console.WriteLine("\nLooping Keys:");
            foreach (var key in studentNames.Keys)
            {
                Console.WriteLine("Key: " + key);
            }

            Console.WriteLine("\nLooping Values:");
            foreach (var value in studentNames.Values)
            {
                Console.WriteLine("Value: " + value);
            }



            // ==========================================================
            // 1️⃣1️⃣ CLEARING DICTIONARY
            // ==========================================================
            Console.WriteLine("\n=== 11. CLEARING DICTIONARY ===\n");

            studentNames.Clear();
            Console.WriteLine("After Clear - Count: " + studentNames.Count);



            // ==========================================================
            // ✅ SUMMARY
            // ==========================================================
            // Roman Urdu mein:
            // - Dictionary<Tkey, TValue> key-value pairs store karti hai.
            // - Keys unique hoti hain.
            // - Add, Remove, Update bohot easy.
            // - Fast lookup.
            // - ContainsKey, TryGetValue methods safe hain.
            // - Count se total elements pata chalta hai.
            // - Looping easy with foreach.
        }
    }
}
