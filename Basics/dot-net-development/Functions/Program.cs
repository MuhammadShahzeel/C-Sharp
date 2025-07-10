using System;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== COMPLETE C# FUNCTIONS GUIDE ===\n");

            // Functions are also called methods - reusable blocks of code that perform specific tasks

            // =====================================
            // 1. TRADITIONAL vs ARROW FUNCTION STYLES
            // =====================================
            Console.WriteLine("1. FUNCTION STYLES - Traditional vs Arrow:");

            Console.WriteLine("==== RETURN TYPE FUNCTION ====");
            // ✅ Traditional way
            int sum1 = AddTraditional(5, 10);
            Console.WriteLine("Traditional Add: " + sum1);

            // ✅ Short (arrow) way
            int sum2 = AddArrow(5, 10);
            Console.WriteLine("Arrow-style Add: " + sum2);

            Console.WriteLine("\n==== VOID TYPE FUNCTION ====");
            // ✅ Traditional way
            GreetTraditional("Ali");

            // ✅ Short (arrow) way
            GreetArrow("Sara");

            Console.WriteLine("✅ Both styles work the same - choose what you prefer!\n");

            // =====================================
            // 2. VOID FUNCTION WITH PARAMETERS
            // =====================================
            Console.WriteLine("2. VOID FUNCTIONS WITH DIFFERENT PARAMETERS:");
            WelcomeMessage();
            Greet("Ahmed");
            GreetWithAge("Fatima", 25);
            Console.WriteLine();

            // =====================================
            // 3. RETURN TYPE FUNCTIONS
            // =====================================
            Console.WriteLine("3. RETURN TYPE FUNCTIONS:");

            int result = Add(8, 12);
            Console.WriteLine($"Addition: {result}");

            double average = CalculateAverage(10, 20, 30);
            Console.WriteLine($"Average: {average}");

            string fullName = GetFullName("John", "Doe");
            Console.WriteLine($"Full Name: {fullName}");
            Console.WriteLine();

            // =====================================
            // 4. OPTIONAL PARAMETERS
            // =====================================
            Console.WriteLine("4. OPTIONAL PARAMETERS:");

            // Using default value for b (which is 2)
            int total1 = Sum(5);
            Console.WriteLine($"Sum with default parameter: {total1}");

            // Providing both parameters
            int total2 = Sum(5, 8);
            Console.WriteLine($"Sum with both parameters: {total2}");

            // String with optional parameter
            DisplayMessage("Hello");           // Uses default suffix
            DisplayMessage("Hello", " World"); // Uses custom suffix
            Console.WriteLine();

            Console.WriteLine(new string('-', 60) + "\n");

            // =====================================
            // 5. OUT PARAMETER - Getting Multiple Values
            // =====================================
            Console.WriteLine("5. OUT PARAMETER - Multiple Return Values:");

            // Problem: Normal functions can only return ONE value
            Console.WriteLine("❌ Normal function limitation:");
            int normalSum = Add(8, 4);
            Console.WriteLine($"We can only get sum: {normalSum}");
            Console.WriteLine("But what if we also want multiplication and division?\n");

            // Solution: OUT parameters
            Console.WriteLine("✅ OUT parameter solution:");
            int sumResult, multiplyResult, divideResult;

            // Get THREE values from ONE function call
            CalculateMultipleResults(8, 4, out sumResult, out multiplyResult, out divideResult);

            Console.WriteLine($"Sum: {sumResult}");
            Console.WriteLine($"Multiply: {multiplyResult}");
            Console.WriteLine($"Divide: {divideResult}");
            Console.WriteLine("✅ Got THREE values from ONE function!\n");

            // =====================================
            // 6. REAL-WORLD OUT EXAMPLE
            // =====================================
            Console.WriteLine("6. REAL-WORLD OUT EXAMPLE - Safe Number Conversion:");

            string[] testInputs = { "123", "abc", "456", "xyz" };

            foreach (string input in testInputs)
            {
                // TryParse returns bool (success/failure) AND converted number via OUT
                bool isSuccess = int.TryParse(input, out int convertedNumber);

                if (isSuccess)
                {
                    Console.WriteLine($"'{input}' → ✅ Converted to: {convertedNumber}");
                }
                else
                {
                    Console.WriteLine($"'{input}' → ❌ Invalid number!");
                }
            }
            Console.WriteLine();

            // =====================================
            // 7. REF PARAMETER - Modifying Original Variables
            // =====================================
            Console.WriteLine("7. REF PARAMETER - Modifying Original Variables:");

            // Problem: Normal parameters work with copies
            Console.WriteLine("❌ Normal parameter problem:");
            int normalValue = 100;
            Console.WriteLine($"Before normal function: {normalValue}");
            ModifyNormalParameter(normalValue);
            Console.WriteLine($"After normal function: {normalValue}");
            Console.WriteLine("Original value unchanged! (Only copy was modified)\n");

            // Solution: REF parameters
            Console.WriteLine("✅ REF parameter solution:");
            int refValue = 100;
            Console.WriteLine($"Before REF function: {refValue}");
            ModifyRefParameter(ref refValue);
            Console.WriteLine($"After REF function: {refValue}");
            Console.WriteLine("Original value was modified!\n");

            // =====================================
            // 8. PRACTICAL REF EXAMPLE - Variable Swapping
            // =====================================
            Console.WriteLine("8. PRACTICAL REF EXAMPLE - Swapping Variables:");

            int firstNumber = 25;
            int secondNumber = 75;

            Console.WriteLine($"Before swap: First={firstNumber}, Second={secondNumber}");
            SwapNumbers(ref firstNumber, ref secondNumber);
            Console.WriteLine($"After swap: First={firstNumber}, Second={secondNumber}");
            Console.WriteLine("✅ Variables successfully swapped!\n");

            // =====================================
            // 9. COMBINING OUT AND REF EXAMPLE
            // =====================================
            Console.WriteLine("9. COMBINING OUT AND REF - Banking Example:");

            decimal accountBalance = 1000m;
            Console.WriteLine($"Initial Balance: ${accountBalance}");

            // Using REF to modify balance and OUT to get transaction details
            string transactionMessage;
            bool withdrawSuccess = WithdrawMoney(ref accountBalance, 300m, out transactionMessage);

            Console.WriteLine($"Transaction Success: {withdrawSuccess}");
            Console.WriteLine($"Message: {transactionMessage}");
            Console.WriteLine($"New Balance: ${accountBalance}");
            Console.WriteLine();

            Console.ReadLine();
        }

        //using params keyword 




































        // =====================================
        // 1. TRADITIONAL vs ARROW FUNCTION STYLES
        // =====================================

        // RETURN TYPE FUNCTIONS
        // 1️⃣ Traditional style
        static int AddTraditional(int a, int b)
        {
            // Roman Urdu: yahan hum curly braces mein poori body likhte hain
            return a + b;
        }

        // 2️⃣ Arrow / Expression-bodied style
        static int AddArrow(int a, int b) => a + b;
        // Roman Urdu: Ye short form hai, sirf ek line mein return hota hai

        // VOID TYPE FUNCTIONS
        // 1️⃣ Traditional style
        static void GreetTraditional(string name)
        {
            // Roman Urdu: yahan hum multiple lines bhi likh sakte hain
            Console.WriteLine("Hello, " + name + "!");
        }

        // 2️⃣ Arrow / Expression-bodied style
        static void GreetArrow(string name) => Console.WriteLine("Hello, " + name + "!");
        // Roman Urdu: Ye bhi short form hai, ek line ka kaam sirf

        // =====================================
        // 2. BASIC VOID FUNCTIONS
        // =====================================
        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the App!");
        }

        static void Greet(string name)
        {
            Console.WriteLine("Welcome " + name);
        }

        static void GreetWithAge(string name, int age)
        {
            Console.WriteLine($"Welcome {name}, you are {age} years old!");
        }

        // =====================================
        // 3. RETURN TYPE FUNCTIONS
        // =====================================
        static int Add(int a, int b)
        {
            return a + b;
        }
        //method overloading - same name, different parameters
        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        //params keyword allows passing variable number of arguments
        static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }


        static double CalculateAverage(int num1, int num2, int num3)
        {
            return (num1 + num2 + num3) / 3.0;
        }

        static string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        // =====================================
        // 4. OPTIONAL PARAMETERS
        // =====================================
        static int Sum(int a, int b = 2) // b has default value 2
        {
            // You can also use: int b = default (which is 0 for int)
            // For string: string text = default (which is empty string)
            return a + b;
        }

        // Optional parameter with string
        static void DisplayMessage(string message, string suffix = "!")
        {
            Console.WriteLine($"{message}{suffix}");
        }

        // =====================================
        // 5. OUT PARAMETER - Multiple return values
        // =====================================
        static void CalculateMultipleResults(int a, int b, out int sum, out int multiply, out int divide)
        {
            // OUT parameters MUST be assigned inside the function
            sum = a + b;
            multiply = a * b;
            divide = a / b;

            // Now we can return THREE values through OUT parameters!
        }

        // =====================================
        // 6. NORMAL PARAMETER - Works with copy
        // =====================================
        static void ModifyNormalParameter(int value)
        {
            // This modifies only the COPY, not original
            value = value + 500;
            Console.WriteLine($"Inside function, value: {value}");
        }

        // =====================================
        // 7. REF PARAMETER - Modifies original
        // =====================================
        static void ModifyRefParameter(ref int value)
        {
            // This modifies the ORIGINAL variable
            value = value + 500;
            Console.WriteLine($"Inside function, value: {value}");
        }

        // =====================================
        // 8. PRACTICAL REF EXAMPLE - Swapping
        // =====================================
        static void SwapNumbers(ref int first, ref int second)
        {
            // REF allows us to modify original variables
            int temp = first;
            first = second;
            second = temp;
        }

        // =====================================
        // 9. COMBINING REF AND OUT
        // =====================================
        static bool WithdrawMoney(ref decimal balance, decimal amount, out string message)
        {
            // REF: Modify original balance
            // OUT: Return transaction message

            if (amount <= balance)
            {
                balance = balance - amount;  // Modify original balance using REF
                message = $"Successfully withdrew ${amount}";  // OUT parameter
                return true;
            }
            else
            {
                message = $"Insufficient funds! Available: ${balance}";  // OUT parameter
                return false;
            }
        }
    }
}

/* 
🎯 COMPLETE SUMMARY:

📌 FUNCTION STYLES:
✅ Traditional Style: Uses curly braces { }
   static int Add(int a, int b) { return a + b; }
   
✅ Arrow Style: Short one-liner =>
   static int Add(int a, int b) => a + b;

📌 BASIC FUNCTIONS:
✅ VOID - No return value, just executes code
✅ VOID with Parameters - Takes input, no return
✅ Return Functions - Takes input, returns output
✅ Optional Parameters - Some parameters have default values

📌 ADVANCED PARAMETERS:
✅ OUT - Get multiple values from one function
   • Don't need to initialize before passing
   • Function MUST assign values
   • Use when: Getting multiple results

✅ REF - Modify original variables
   • Must initialize before passing
   • Function can read and modify
   • Use when: Changing existing values

🔥 WHEN TO USE WHAT:

┌─────────────────────┬─────────────────────┬─────────────────────┐
│      Function       │      Use Case       │      Example        │
├─────────────────────┼─────────────────────┼─────────────────────┤
│ VOID                │ Action only         │ Print, Save, Clear  │
│ VOID + Parameter    │ Action with input   │ Greet user, Display │
│ Return              │ Calculate & return  │ Add, Convert, Get   │
│ Optional Parameters │ Flexible functions  │ Sum with defaults   │
│ OUT                 │ Multiple results    │ TryParse, GetStats  │
│ REF                 │ Modify original     │ Swap, Update        │
└─────────────────────┴─────────────────────┴─────────────────────┘

🚀 ARROW FUNCTION RULES:
✅ Use => for single expression functions
✅ No curly braces needed for one-liners
✅ No return keyword needed (automatic)
✅ Perfect for simple calculations
✅ Makes code shorter and cleaner

📝 BEST PRACTICES:
✅ Use descriptive function names
✅ Keep functions small and focused
✅ Use arrow functions for simple operations
✅ Use OUT for multiple returns
✅ Use REF for modifying originals
✅ Use optional parameters for flexibility
*/