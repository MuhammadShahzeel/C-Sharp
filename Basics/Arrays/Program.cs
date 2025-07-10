using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =============================
            // ARRAYS INTRO & CREATION
            // =============================

            Console.WriteLine("=== ARRAYS INTRO & CREATION ===\n");

            // 1. Array creation using size (new keyword)
            int[] numbersWithSize = new int[5];
            numbersWithSize[0] = 10;
            numbersWithSize[1] = 20;
            numbersWithSize[2] = 30;
            numbersWithSize[3] = 40;
            numbersWithSize[4] = 50;

            Console.Write("Array with size & manual assignment: ");
            foreach (int num in numbersWithSize) Console.Write(num + " ");
            Console.WriteLine("\n");

            // 2. Array shorthand
            string[] fruits = { "Apple", "Banana", "Orange", "Mango" };
            Console.Write("Array shorthand initialization: ");
            foreach (string fruit in fruits) Console.Write(fruit + " ");
            Console.WriteLine("\n");

            // 3. Array creation using new keyword with values
            int[] moreNumbers = new int[] { 1, 2, 3, 4, 5 };
            //int[] moreNumberss = new int[5] { 1, 2, 3, 4, 5 };
            Console.Write("Array with new keyword and values: ");
            foreach (int num in moreNumbers) Console.Write(num + " ");
            Console.WriteLine("\n");

            // Note about shorthand limitation
            // string[] fruits;
            // fruits = { "Apple", "Banana", "Orange" }; // Error
            // fruits = new string[] { "Apple", "Banana", "Orange" }; // Correct

            // 4. Array creation using var
            var numbersWithVar = new[] { 1, 2, 3, 4, 5 };
            Console.Write("Array using var: ");
            foreach (var num in numbersWithVar) Console.Write(num + " ");
            Console.WriteLine("\n");

            // 5. Looping through arrays
            Console.Write("Printing fruits using for loop: ");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.Write(fruits[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Printing fruits using foreach loop: ");
            foreach (string fruit in fruits)
            {
                Console.Write(fruit + " ");
            }
            Console.WriteLine("\n");



            // =============================
            // 1. SORTING SECTION
            // =============================

            Console.WriteLine("=== 1. SORTING ===\n");

            // String Array
            string[] fruitsForSort = { "Banana", "Apple", "Mango", "Orange" };
            Console.Write("Original Fruits Array: ");
            foreach (string fruit in fruitsForSort) Console.Write(fruit + " ");
            Console.WriteLine();

            Array.Sort(fruitsForSort);
            Console.Write("Sorted Fruits Array (A-Z): ");
            foreach (string fruit in fruitsForSort) Console.Write(fruit + " ");
            Console.WriteLine("\n");

            // Numbers Array
            int[] numbersForSort = { 42, 5, 18, 23, 7 };
            Console.Write("Original Numbers Array: ");
            foreach (int number in numbersForSort) Console.Write(number + " ");
            Console.WriteLine();

            Array.Sort(numbersForSort);
            Console.Write("Sorted Numbers Array (Ascending): ");
            foreach (int number in numbersForSort) Console.Write(number + " ");
            Console.WriteLine("\n");



            // =============================
            // 2. REVERSING SECTION
            // =============================

            Console.WriteLine("=== 2. REVERSING ===\n");

            Array.Reverse(fruitsForSort);
            Console.Write("Reversed Fruits Array (Z-A): ");
            foreach (string fruit in fruitsForSort) Console.Write(fruit + " ");
            Console.WriteLine();

            Array.Reverse(numbersForSort);
            Console.Write("Reversed Numbers Array (Descending): ");
            foreach (int number in numbersForSort) Console.Write(number + " ");
            Console.WriteLine("\n");



            // =============================
            // 3. CLEARING SECTION
            // =============================

            Console.WriteLine("=== 3. CLEARING ===\n");

            // 1. Using Array.Clear() (Full)
            Array.Clear(fruitsForSort, 0, fruitsForSort.Length);
            Console.Write("Fruits Array after Array.Clear() (Full): ");
            foreach (string fruit in fruitsForSort) Console.Write((fruit ?? "null") + " ");
            Console.WriteLine();

            Array.Clear(numbersForSort, 0, numbersForSort.Length);
            Console.Write("Numbers Array after Array.Clear() (Full): ");
            foreach (int number in numbersForSort) Console.Write(number + " ");
            Console.WriteLine("\n");



            // 2. Using Array.Clear() on Specific Range
            string[] fruitsPartial = { "Apple", "Banana", "Orange", "Mango", "Peach" };
            Console.Write("Fruits Array before Partial Clear: ");
            foreach (string fruit in fruitsPartial) Console.Write(fruit + " ");
            Console.WriteLine();

            Array.Clear(fruitsPartial, 1, 2);
            Console.Write("Fruits Array after Partial Clear (index 1, count 2): ");
            foreach (string fruit in fruitsPartial) Console.Write((fruit ?? "null") + " ");
            Console.WriteLine();

            int[] numbersPartial = { 10, 20, 30, 40, 50 };
            Console.Write("Numbers Array before Partial Clear: ");
            foreach (int number in numbersPartial) Console.Write(number + " ");
            Console.WriteLine();

            Array.Clear(numbersPartial, 2, 3);
            Console.Write("Numbers Array after Partial Clear (index 2, count 3): ");
            foreach (int number in numbersPartial) Console.Write(number + " ");
            Console.WriteLine("\n");



            // 3. For loop reset (Full custom default)
            for (int i = 0; i < fruitsForSort.Length; i++)
            {
                fruitsForSort[i] = "Unknown";
            }
            Console.Write("Fruits Array after FULL reset with for loop: ");
            foreach (string fruit in fruitsForSort) Console.Write(fruit + " ");
            Console.WriteLine();

            for (int i = 0; i < numbersForSort.Length; i++)
            {
                numbersForSort[i] = -1;
            }
            Console.Write("Numbers Array after FULL reset with for loop: ");
            foreach (int number in numbersForSort) Console.Write(number + " ");
            Console.WriteLine("\n");



            // 4. For loop reset on Specific Range
            for (int i = 1; i < 3; i++)
            {
                fruitsPartial[i] = "ClearedPart";
            }
            Console.Write("Fruits Array after Partial Reset with for loop (index 1-2): ");
            foreach (string fruit in fruitsPartial) Console.Write(fruit + " ");
            Console.WriteLine();

            for (int i = 2; i < 5; i++)
            {
                numbersPartial[i] = -99;
            }
            Console.Write("Numbers Array after Partial Reset with for loop (index 2-4): ");
            foreach (int number in numbersPartial) Console.Write(number + " ");
            Console.WriteLine();
            // =======================================================
            // 1️⃣ Array.IndexOf() - COMPLETE GUIDE (INTEGER ONLY)
            // =======================================================
            // Array.IndexOf() ek method hai jo array ke andar kisi value
            // ka index dhoondta hai. Agar value milti hai to uska pehla
            // index return karta hai, warna -1 deta hai.
            //
            // Syntax:
            // int index = Array.IndexOf(array, value);
            // int index = Array.IndexOf(array, value, startIndex);
            // int index = Array.IndexOf(array, value, startIndex, count);
            //
            // Neeche saare use cases diye hain integer array ke sath.
            // =======================================================

            Console.WriteLine("=== Array.IndexOf() Examples (Integer Only) ===\n");

            // Sample integer array with duplicates
            int[] numbers = { 5, 10, 15, 10, 20, 25, 10 };


            // --------------------------
            // 1. Basic Search
            // --------------------------
            // Poore array mein pehli baar 10 kaha hai
            int index1 = Array.IndexOf(numbers, 10);
            Console.WriteLine("1. First occurrence of 10: " + index1);
            // Output: 1


            // --------------------------
            // 2. Value Not Found
            // --------------------------
            // 99 array mein nahi hai
            int index2 = Array.IndexOf(numbers, 99);
            Console.WriteLine("2. Search for 99 (not found): " + index2);
            // Output: -1


            // --------------------------
            // 3. Search with startIndex
            // --------------------------
            // Index 2 se aage search karo
            int index3 = Array.IndexOf(numbers, 10, 2);
            Console.WriteLine("3. 10 found starting from index 2: " + index3);
            // Output: 3


            // --------------------------
            // 4. Search with startIndex and count
            // --------------------------
            // Sirf index 4 se 3 elements mein dekho
            int index4 = Array.IndexOf(numbers, 10, 4, 3);
            Console.WriteLine("4. 10 found in range (start=4, count=3): " + index4);
            // Output: 6


            // --------------------------
            // 5. Value Exists But Outside Range
            // --------------------------
            // Sirf index 4 check karo (count=1)
            int index5 = Array.IndexOf(numbers, 10, 4, 1);
            Console.WriteLine("5. 10 in range (start=4, count=1): " + index5);
            // Output: -1


            // --------------------------
            // 6. Single Occurrence Value
            // --------------------------
            // 25 sirf ek hi jagah hai
            int index6 = Array.IndexOf(numbers, 25);
            Console.WriteLine("6. 25 found at index: " + index6);
            // Output: 5


            // --------------------------
            // 7. StartIndex After Value's Location
            // --------------------------
            // 5 sirf index 0 par hai, hum 1 se start kar rahe hain
            int index7 = Array.IndexOf(numbers, 5, 1);
            Console.WriteLine("7. 5 found after index 1: " + index7);
            // Output: -1


            // --------------------------
            // 8. Empty Array Case
            // --------------------------
            // Khaali array mein kuch nahi milega
            int[] empty = { };
            int index8 = Array.IndexOf(empty, 10);
            Console.WriteLine("8. Search in empty array: " + index8);
            // Output: -1
        }






    }
}
