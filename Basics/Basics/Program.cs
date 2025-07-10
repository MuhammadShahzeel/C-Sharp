using System;
using System.Threading;
namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*



             //C# BASICS - NOTES WITH EXAMPLES
           

            // ----------------------------------------------
            // 1️ Hello World
            // ----------------------------------------------
            Console.WriteLine("hello world");

            // ----------------------------------------------
            // 2️ DATA TYPES
            // ----------------------------------------------

            // Integer
            int number = 10;
            Console.WriteLine("int.MinValue: " + int.MinValue);
            Console.WriteLine("int.MaxValue: " + int.MaxValue);

            // Long (64-bit)
            long largeNumber = 10000000000L;

            // Double (default for decimals with .)
            double decimalNumber = 10.5;

            // Float (needs 'F' suffix)
            float floatNumber = 10.5F;

            // Boolean
            bool isTrue = true;

            // Character (single quotes)
            char character = 'A';

            // DateTime
            DateTime currentDate = DateTime.Now;
            Console.WriteLine("Current Date and Time: " + currentDate);

            // ----------------------------------------------
            // 3️ VARIABLE DECLARATION AND INITIALIZATION
            // ----------------------------------------------

            // Multiple variables in one line
            int x = 1, y = 2;

            // Declaration without initialization
            int p;
            p = 3;  // Initial value
            p = 4;  // Reassigned value

            // ----------------------------------------------
            // 4️ STRINGS
            // ----------------------------------------------
            string name = "John Doe";

            // ⚠️ Note: Use "" for strings, not ''
            Console.Write("Your name is: ");
            Console.Write(name);
            // Console.Write does not add a newline

            // ----------------------------------------------
            // 5️ CHAR
            // ----------------------------------------------
            char initial = 'J';
            // ⚠️ Note: Use '' for char, not ""

            // ----------------------------------------------
            // 6️ TYPE CONVERSIONS
            // ----------------------------------------------

            // ➜ String to Int
            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine("\nString to Int: " + age);

            // ➜ Int to String
            int number1 = 42;
            string numberAsString = number1.ToString();
            Console.WriteLine("Int to String: " + numberAsString);

            // ➜ String to Long
            string textBigNumber = "-90000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine("String to Long: " + bigNumber);

            // ➜ String to Double
            string textNegative = "-55.2";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine("String to Double: " + negative);

            // ➜ String to Float
            string textPrecision = "5.000001";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine("String to Float: " + precision);

            // ➜ String to Decimal
            string textMoney = "14.99";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine("String to Decimal: " + money);

            //operators
            int num = 10;
            num++;
            // Increment
            Console.WriteLine("Incremented num: " + num);
            num--;
            // Decrement
            Console.WriteLine("Decremented num: " + num);
            num += 5; // Add and assign
            Console.WriteLine("Added 5 to num: " + num);
            string greeting = "Hello";
            greeting += " World"; // Concatenate
            Console.WriteLine("Concatenated greeting: " + greeting);

            // Char arithmetic (adds Unicode values)
            char abc = 'a';
            abc = (char)(abc + 'h');
            Console.WriteLine("after concatenating: " + abc);

            // Arithmetic operations
            int sum = 5 + 3; // Addition
            Console.WriteLine("Sum: " + sum);
            int difference = 10 - 2; // Subtraction
            Console.WriteLine("Difference: " + difference);
            int product = 4 * 2; // Multiplication
            Console.WriteLine("Product: " + product);
            int quotient = 8 / 2; // Division
            Console.WriteLine("Quotient: " + quotient);
            int remainder = 10 % 3; // Modulus
            Console.WriteLine("Remainder: " + remainder);

            // var keyword
            //instead of using string,int just use var
            var dynamicString = "This is a dynamic string";
            var dynamicInt = 42;
            var bigNumberx = 1234567890123456789L; // Long type
            Console.WriteLine("Dynamic String: " + dynamicString);
            //note: var is implicitly typed, so it must be initialized at declaration
            //var a; // This will cause an error because 'a' is not initialized

            //const keyword
            const int constantValue = 100; // Constant value
            //constantValue = 200; // This will cause an error because constants cannot be changed
            Console.WriteLine("Constant Value: " + constantValue);

            //some calculations
            const int vat = 20;
            const double percentVAT = vat / 100D;

            int balance = 1000;
            Console.WriteLine(balance * percentVAT);

            //get user input 
            Console.Write("Enter your name:");
            string userName = Console.ReadLine();
            Console.WriteLine("enter your age:");
            //note: ReadLine returns a string, so we need to convert it to int
            string userAgeInput = Console.ReadLine();
            int userAge = Convert.ToInt32(userAgeInput);
            Console.WriteLine("hello " + userName + ", you are " + userAgeInput + " years old.");

            //if else
            if (userAge == 18)
            {
                Console.WriteLine("You are an adult now!");
            }
            else if (userAge == 17)
            {
                Console.WriteLine("You are almost an adult!");
            }
            else
            {
                Console.WriteLine("You are not an adult yet.");
            }

            //switch case
            Console.WriteLine("Enter a number between 1 and 3:");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("You entered one.");
                    break;
                case "2":
                    Console.WriteLine("You entered two.");
                    break;
                case "3":
                    Console.WriteLine("You entered three.");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }

            //for loops
            Console.WriteLine("Counting from 1 to 5:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            //while loop
            Console.WriteLine("Counting down from 5 to 1:");
            int countdown = 5;
            while (countdown > 0)
            {
                Console.WriteLine(countdown);
                countdown--;
            }
            //dowhile loop
            Console.WriteLine("Counting down from 5 to 1 using do-while:");
            int doWhileCountdown = 5;
            do
            {
                Console.WriteLine(doWhileCountdown);
                doWhileCountdown--;
            } while (doWhileCountdown > 0);
            //difference between while and do-while
            //while checks the condition before executing the loop body,

            // Conditional operator (ternary operator)
            string result = 10 > 0 ? "a is greater than b" : "b is greater than or equal to a";
            Console.WriteLine("Conditional Operator Result: " + result);

            //numeric formatting
            double value = 3.33333333;

            // Print the original value
            Console.WriteLine(value);  // Output: 3.33333333

            // Format with no decimals — rounds to nearest whole number
            Console.WriteLine(string.Format("{0:0}", value)); // Output: 3

            // Format with 1 decimal place
            Console.WriteLine(string.Format("{0:0.0}", value)); // Output: 3.3

            // Format with 2 decimal places
            Console.WriteLine(string.Format("{0:0.00}", value)); // Output: 3.33

            // ---------------------------------------------
            // Currency formatting example
            // ---------------------------------------------

            double money1 = -10D / 3D;  // money1 = -3.33333333

            // Print the unformatted result
            Console.WriteLine(money1); // Output: -3.33333333

            // Format with custom message and 2 decimal places
            Console.WriteLine(string.Format("£10 / £3 = £{0:0.00}", money1));
            // Output: £10 / £3 = £-3.33

            // --- Currency Format using Current Culture (e.g., UK: £, US: $) ---
            Console.WriteLine(money1.ToString("C"));
            // Example Output (UK): £-3.33
            // Example Output (US): $-3.33

            // Currency with 0 decimal places
            Console.WriteLine(money1.ToString("C0")); // Output: £-3

            // Currency with 1 decimal place
            Console.WriteLine(money1.ToString("C1")); // Output: £-3.3

            // Currency with 2 decimal places
            Console.WriteLine(money1.ToString("C2")); // Output: £-3.33

            // --- Currency using specific cultures ---
            Console.WriteLine(money1.ToString("C", System.Globalization.CultureInfo.CurrentCulture));
            Console.WriteLine(money1.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money1.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(money1.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-AU")));

            //try parse
            string s = "123";
int n = int.Parse(s);  // works fine

            string s = "abc";
int n = int.Parse(s);  // ERROR, crash ho jayega!


            //try parse check krta hy k string convert ho skta hy ya nh agr ho skta hy to result wrna 0 dyga agr hm try parse nh krdty to error ata hy agr convert nh kr skty to 
            string s = "123";
bool success = int.TryParse(s, out int n);

Console.WriteLine(success);  // True
Console.WriteLine(n);        // 123

            string s = "abc";
bool success = int.TryParse(s, out int n);

Console.WriteLine(success);  // False
Console.WriteLine(n);        // 0




            bool success = true;
            while (success)
            {
                Console.Write("Enter a number: ");
                string numInput = Console.ReadLine();
                if (int.TryParse(numInput, out int numTryParse))
                {
                    success = false;
                    Console.WriteLine(numTryParse);
                }
                else
                {
                    Console.WriteLine("Failed to convert!");
                }
            }

            // Multiplication table
            Console.Write("Enter a number: ");
            int numberx = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, numberx, i * numberx);
            }

            // Example 1: Escaping double quotes and backslashes, new line
            string speech = "He said \"something\"";
            string path = "C:\\Users\\CoffeeNCode\\Desktop\\C# Course\nNew line test";
            Console.WriteLine(path);
            Console.WriteLine(speech);

            // Example 2: Using single quotes inside double quotes
            string namez = "Hello 'someone'";
            Console.WriteLine(namez);

            // Call Practice.practice() if it exists
            // Practice.practice();

            //string interpolation
            string firstName = "John";
            string lastName = "Doe";
            int agez = 30;
            string xullName = $"{firstName} {lastName} is {agez} years old.";

            //better way for empty strings
            string emptyString = string.Empty; // Preferred way to create an empty string

            // String comparison examples
            string str1 = "Apple";
            string str2 = "Apple";
            if (str1 == str2)
            {
                Console.WriteLine("Example 1 (==): Same");
            }
            else
            {
                Console.WriteLine("Example 1 (==): Different");
            }
            if (str1.Equals(str2))
            {
                Console.WriteLine("Example 1 (.Equals()): Same");
            }
            else
            {
                Console.WriteLine("Example 1 (.Equals()): Different");
            }

            string message = "Hello";
            object newCompare = "Hello";
            if (message == newCompare as string)
            {
                Console.WriteLine("Example 2 (==): Same");
            }
            else
            {
                Console.WriteLine("Example 2 (==): Different");
            }
            if (message.Equals(newCompare))
            {
                Console.WriteLine("Example 2 (.Equals()): Same");
            }
            else
            {
                Console.WriteLine("Example 2 (.Equals()): Different");
            }

            string messagess = "C# is awesome";
            Console.WriteLine(messagess[0]); // 'C'
            Console.WriteLine(messagess[1]); // '#'
            for (int i = 0; i < messagess.Length; i++)
            {
                Console.WriteLine(messagess[i]);
            }
            




            //cool effect sleep
            // System.Threading.Thread.Sleep(1000); // Sleep for 1 second
            //loop using sleep
             for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
                Thread.Sleep(500); // Sleep for 0.5 seconds
            }

             Console.Write(messagess.Contains("#")); // Check if the string contains "#

            //null or empty
            string nullString = null;
            string emptyStringz = string.Empty;


            Console.WriteLine(string.IsNullOrEmpty(nullString));
                Console.WriteLine(string.IsNullOrEmpty(emptyStringz));


         */





















            // ----------------------------------------------
            // 7️ END
            // ----------------------------------------------




            Console.ReadLine();
        }
    }
}