using System;

namespace DelegatesBuiltin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Built-in Delegates Example ===");

            // ✅ 1️⃣ Action
            // Action delegate void return type hota hai
            // Parameters jitne bhi ho sakte hain
            Action<string> showMessage = msg =>
            {
                Console.WriteLine("Action called!");
                Console.WriteLine("Message: " + msg);
            };
            showMessage("Hello from Action!");

            Console.WriteLine();

            // ✅ 2️⃣ Func
            // Func delegate return type rakhta hai
            // Last generic type return type hota hai
            Func<int, int, int> add = (a, b) => a + b;
            int sum = add(5, 7);
            Console.WriteLine("Func result (5 + 7): " + sum);

            Console.WriteLine();

            // ✅ 3️⃣ Predicate
            // Predicate<T> hamesha bool return karta hai
            // Sirf 1 parameter leta hai
            Predicate<int> isEven = number => number % 2 == 0;
            bool check = isEven(10);
            Console.WriteLine("Predicate result (is 10 even?): " + check);
        }
    }
}
