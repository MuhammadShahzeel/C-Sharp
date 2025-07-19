using System;

namespace DelegatesLambda
{
    // Delegate definition
    delegate void ShowMessage(string msg);

    internal class Program
    {
        // ✅ Traditional Named Method
        static void NamedMethod(string msg)
        {
            Console.WriteLine("Named Method: " + msg);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Delegate Examples ===");

            // 1️⃣ Named Method
            ShowMessage show1 = NamedMethod;
            show1("Hello from Named Method!");

            // 2️⃣ Anonymous Method
            ShowMessage show2 = delegate (string msg)
            {
                Console.WriteLine("Anonymous Method: " + msg);
            };
            show2("Hello from Anonymous Method!");

            // 3️⃣ Lambda Expression
            // ✅ One-line lambda does NOT need { }
            ShowMessage show3 = msg => Console.WriteLine("Lambda Expression: " + msg);
            show3("Hello from Lambda Expression!");
        }
    }
}
