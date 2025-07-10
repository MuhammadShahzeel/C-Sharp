using System;
using System.Collections.Generic; // System.Collections.Generic namespace mein List<T> class hoti hai

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =======================================================
            // 1️⃣ ARRAY IN C#
            // =======================================================
            // Array ek fixed-size data structure hai.
            // Uska size banate waqt fix ho jata hai aur change nahi hota.
            // Isliye dynamic scenarios ke liye arrays ideal nahi hain.

            Console.WriteLine("=== 1. ARRAY LIMITATIONS ===\n");

            // Example of fixed-size array
            int[] fixedArray = {1,2,3};
            //fixed sie of length 3





            Console.WriteLine("Fixed Array Elements:");
            foreach (int num in fixedArray) Console.WriteLine(num);

            // Limitations explained:
            // 1. Size fix hota hai - new elements add nahi kar sakte
            // 2. Remove karna mushkil hai - manual shifting karni padti hai
            // 3. Insert bhi manually karna padta hai
            // 4. No easy push/pop
            // 5. No built-in Add/Remove/Insert/Contains etc. methods

            // ✅ In short:
            Console.WriteLine("\nArray ki Limitations:");
            Console.WriteLine("- Size fix hota hai");
            Console.WriteLine("- Add/Remove/Insert easy nahi hai");
            Console.WriteLine("- Push/Pop nahi kar sakte");
            Console.WriteLine("- Limited functionality\n");



            // =======================================================
            // 2️⃣ LIST<T> IN C#
            // =======================================================
            // List<T> ek dynamic array hai jo grow/shrink hoti hai.
            // System.Collections.Generic namespace mein hoti hai.
            // Ismein bohot saare useful methods hote hain.


            // -------------------------------------------------------
            // 2.1 LIST CREATION
            // -------------------------------------------------------
            Console.WriteLine("=== 2.1 LIST CREATION ===\n");

            List<int> numbers = new List<int>();
            List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };
            Console.WriteLine(fruits[0]);

            Console.WriteLine("Empty Numbers List Created.");
            Console.WriteLine("Fruits List Created with values:");
            foreach (string fruit in fruits) Console.WriteLine(fruit);



            // -------------------------------------------------------
            // 2.2 ADDING ELEMENTS (Push equivalent)
            // -------------------------------------------------------
            Console.WriteLine("\n=== 2.2 ADDING ELEMENTS ===\n");

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            Console.WriteLine("Numbers after Add():");
            foreach (int num in numbers) Console.WriteLine(num);



            // -------------------------------------------------------
            // 2.3 INSERTING AT SPECIFIC INDEX
            // -------------------------------------------------------
            Console.WriteLine("\n=== 2.3 INSERTING AT INDEX ===\n");

            numbers.Insert(1, 15); // index 1 par 15
            Console.WriteLine("Numbers after Insert at index 1:");
            foreach (int num in numbers) Console.WriteLine(num);



            // -------------------------------------------------------
            // 2.4 REMOVING ELEMENT BY VALUE
            // -------------------------------------------------------
            Console.WriteLine("\n=== 2.4 REMOVING BY VALUE ===\n");

            numbers.Remove(15); // value 15 remove
            Console.WriteLine("Numbers after Remove(15):");
            foreach (int num in numbers) Console.WriteLine(num);



            // -------------------------------------------------------
            // 2.5 REMOVING ELEMENT BY INDEX (Pop equivalent)
            // -------------------------------------------------------
            Console.WriteLine("\n=== 2.5 REMOVING BY INDEX ===\n");

            numbers.RemoveAt(numbers.Count - 1); // last element "pop"
            Console.WriteLine("Numbers after RemoveAt(last index):");
            foreach (int num in numbers) Console.WriteLine(num);



            // -------------------------------------------------------
            // 2.6 CLEARING ENTIRE LIST
            // -------------------------------------------------------
            Console.WriteLine("\n=== 2.6 CLEARING LIST ===\n");

            List<int> tempList = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("Before Clear - Count: " + tempList.Count);
            tempList.Clear();
            Console.WriteLine("After Clear - Count: " + tempList.Count);



            // -------------------------------------------------------
            // 2.7 CHECKING IF ELEMENT EXISTS
            // -------------------------------------------------------
            Console.WriteLine("\n=== 2.7 CONTAINS METHOD ===\n");

            List<string> colors = new List<string> { "Red", "Green", "Blue" };

            Console.WriteLine("Colors List:");
            foreach (string color in colors) Console.WriteLine(color);

            Console.WriteLine("\nContains 'Green': " + colors.Contains("Green"));
            Console.WriteLine("Contains 'Yellow': " + colors.Contains("Yellow"));



            // -------------------------------------------------------
            // 2.8 FINDING INDEX OF ELEMENT
            // -------------------------------------------------------
            Console.WriteLine("\n=== 2.8 INDEXOF METHOD ===\n");

            List<int> dupNumbers = new List<int> { 5, 10, 15, 10, 20 };

            Console.WriteLine("First occurrence of 10: " + dupNumbers.IndexOf(10));
            Console.WriteLine("Second occurrence of 10 (start at 2): " + dupNumbers.IndexOf(10, 2));



            // -------------------------------------------------------
            // 2.9 COUNT PROPERTY
            // -------------------------------------------------------
            Console.WriteLine("\n=== 2.9 COUNT PROPERTY ===\n");

            Console.WriteLine("Colors Count: " + colors.Count);
            Console.WriteLine("Fruits Count: " + fruits.Count);



            // -------------------------------------------------------
            // 2.10 LOOPING THROUGH LIST
            // -------------------------------------------------------
            Console.WriteLine("\n=== 2.10 LOOPING ===\n");

            Console.WriteLine("Using for loop:");
            for (int i = 0; i < colors.Count; i++)
            {
                Console.WriteLine("Index " + i + ": " + colors[i]);
            }

            Console.WriteLine("\nUsing foreach loop:");
            foreach (string color in colors)
            {
                Console.WriteLine("Color: " + color);
            }



            // -------------------------------------------------------
            // 2.11 SORTING LIST
            // -------------------------------------------------------
            Console.WriteLine("\n=== 2.11 SORTING LIST ===\n");

            List<int> unsortedNumbers = new List<int> { 42, 5, 18, 23, 7 };
            Console.WriteLine("Before Sort:");
            foreach (int num in unsortedNumbers) Console.WriteLine(num);

            unsortedNumbers.Sort();

            Console.WriteLine("\nAfter Sort (Ascending):");
            foreach (int num in unsortedNumbers) Console.WriteLine(num);



            // -------------------------------------------------------
            // 2.12 REVERSING LIST
            // -------------------------------------------------------
            Console.WriteLine("\n=== 2.12 REVERSING LIST ===\n");

            unsortedNumbers.Reverse();

            Console.WriteLine("After Reverse (Descending):");
            foreach (int num in unsortedNumbers) Console.WriteLine(num);

            //convert list to array
            int[] numberArray = unsortedNumbers.ToArray();
            Console.WriteLine("\nConverted to Array:");


            // =======================================================
            // ✅ SUMMARY
            // =======================================================
            // Array:
            // - Fixed size
            // - Limited functionality
            //
            // List:
            // - Dynamic size
            // - Easy Add, Remove, Insert
            // - Supports Contains, IndexOf, Sort, Reverse
            //
            // List<T> is preferred when you need a resizable collection.
        }
    }
}
