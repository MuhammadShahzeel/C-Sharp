using System;

namespace DelegatesAnonymousMethod
{
    // ✅ Delegate definition
    delegate void ShowMessage(string message);

    // ✅ Another simple delegate (no parameters)
    delegate void SimpleDelegate();

    internal class Program
    {
        // ✅ Yeh hai Traditional Named Method
        // Matlab method ka apna naam hota hai jo delegate ko assign karte hain
        static void DisplayMessage(string msg)
        {
            Console.WriteLine("Traditional Method says: " + msg);
        }

        static void Main(string[] args)
        {
            // ✅ ============= EXPLANATION =================
            // ✅ ANONYMOUS METHOD KYA HOTA HAI?
            // ➜ Anonymous Method wo hota hai jo bina naam ke likha jata hai.
            // ➜ Hum delegate ko direct ek method body assign karte hain.
            // ➜ Useful jab choti si logic inline likhni ho.
            // ➜ Syntax:
            //      delegate(parameters) { /* code */ };
            // =================================================

            // ✅ 1️⃣ Traditional Method assign karna delegate ko
            ShowMessage traditional = DisplayMessage;
            traditional("Hello from Traditional Method");

            // ✅ 2️⃣ Anonymous Method assign karna delegate ko
            ShowMessage anonymous = delegate (string msg)
            {
                Console.WriteLine("Anonymous Method says: " + msg);
            };
            anonymous("Hello from Anonymous Method");

            // ✅ 3️⃣ Anonymous Method without parameters
            SimpleDelegate greet = delegate ()
            {
                Console.WriteLine("Anonymous Method without parameters");
            };
            greet();

            // ✅ Program end message
            Console.WriteLine("Program Complete!");
        }
    }
}
