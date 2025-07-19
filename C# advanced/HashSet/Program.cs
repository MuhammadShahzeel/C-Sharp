using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // **************************************
            // HashSet<T> EXPLAINED - COMPLETE GUIDE
            // **************************************

            /*
             * ✅ WHAT IS A HashSet<T>?
             * -------------------------
             * - A HashSet<T> is a collection that stores UNIQUE elements.
             * - It belongs to System.Collections.Generic namespace.
             * - It does NOT allow duplicate values.
             * - The order of elements is NOT guaranteed (it's not like List or Array).
             * - Very fast for checking if an item exists (O(1) on average).
             * 
             * Think of it like a mathematical set in real life:
             * {1, 2, 3} is a set. You can't have {1, 2, 2, 3}.
             */

            // ✅ HOW TO DECLARE A HashSet
            HashSet<string> fruits = new HashSet<string>();

            // ✅ HOW TO ADD ELEMENTS
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Mango");

            // ✅ Duplicates are automatically ignored
            bool addedAgain = fruits.Add("Apple"); // Will return false because "Apple" already exists

            Console.WriteLine("Contents of HashSet:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            /*
             * ✅ OUTPUT EXAMPLE:
             * Apple
             * Banana
             * Mango
             * 
             * Note: Order may vary! HashSet does NOT maintain insertion order.
             */

            // ✅ CHECK IF ELEMENT EXISTS
            if (fruits.Contains("Banana"))
            {
                Console.WriteLine("Banana is in the HashSet!");
            }

            // ✅ REMOVE AN ELEMENT
            fruits.Remove("Mango");
            Console.WriteLine("After removing Mango:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // ✅ COUNT
            Console.WriteLine($"Total items: {fruits.Count}");

            // ✅ CLEAR ALL ELEMENTS
            fruits.Clear();
            Console.WriteLine($"Count after clear: {fruits.Count}");

            /*
             * ✅ INITIALIZE WITH COLLECTION
             */
            HashSet<int> numbers = new HashSet<int> { 1, 2, 3, 4, 5, 5, 5 };
            Console.WriteLine("Numbers HashSet:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num); // Duplicates are removed
            }

            /*
             * ✅ SET OPERATIONS
             * HashSet is useful for set-theory operations like:
             * - Union
             * - Intersection
             * - Difference
             * - SymmetricDifference
             */

            HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4 };
            HashSet<int> setB = new HashSet<int> { 3, 4, 5, 6 };

            // ✅ UNION: All unique elements from both sets
            setA.UnionWith(setB);
            Console.WriteLine("Union of A and B:");
            foreach (var item in setA) Console.WriteLine(item);
            // A now contains {1, 2, 3, 4, 5, 6}

            // ✅ RESET sets for next operation
            setA = new HashSet<int> { 1, 2, 3, 4 };
            setB = new HashSet<int> { 3, 4, 5, 6 };

            // ✅ INTERSECTION: Only common elements
            setA.IntersectWith(setB);
            Console.WriteLine("Intersection of A and B:");
            foreach (var item in setA) Console.WriteLine(item);
            // A now contains {3, 4}

            // ✅ DIFFERENCE: Items in A but not in B
            setA = new HashSet<int> { 1, 2, 3, 4 };
            setB = new HashSet<int> { 3, 4, 5, 6 };

            setA.ExceptWith(setB);
            Console.WriteLine("Difference A - B:");
            foreach (var item in setA) Console.WriteLine(item);
            // A now contains {1, 2}

            // ✅ SYMMETRIC DIFFERENCE: Items in A or B but NOT both
            setA = new HashSet<int> { 1, 2, 3, 4 };
            setB = new HashSet<int> { 3, 4, 5, 6 };

            setA.SymmetricExceptWith(setB);
            Console.WriteLine("Symmetric Difference of A and B:");
            foreach (var item in setA) Console.WriteLine(item);
            // A now contains {1, 2, 5, 6}

            /*
             * ✅ WHY USE HashSet?
             * -------------------
             * - To maintain a collection of unique items automatically.
             * - To do fast lookups (Contains) with O(1) average time.
             * - To perform set operations (Union, Intersection, etc.) easily.
             * 
             * ✅ WHEN NOT TO USE HashSet
             * --------------------------
             * - If you care about the order of elements -> use List instead.
             * - If you need duplicates -> use List.
             */

            /*
             * ✅ HASHSET VS LIST
             * ------------------
             * - List allows duplicates, HashSet doesn't.
             * - HashSet is faster for checking if an item exists (Contains).
             * - HashSet doesn't guarantee order.
             */

            /*
             * ✅ TIP
             * -----
             * HashSet<T> needs that your type T implements good GetHashCode and Equals methods
             * so it can determine if two elements are the same.
             * For built-in types (int, string, etc.) this is already handled.
             */
        }
    }
}
