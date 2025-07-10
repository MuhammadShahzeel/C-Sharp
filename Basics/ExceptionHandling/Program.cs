using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("✅ Try-Catch DEMO - Basic to Advanced");
            Console.WriteLine("-------------------------------------\n");

            // ====================================
            // 1️⃣ Basic Try-Catch (sabse simple)
            // ====================================
            Console.WriteLine("1️⃣ Basic Try-Catch Example");
            try
            {
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());  // Error ho sakti hai
                Console.WriteLine($"You entered: {number}");
            }
            catch
            {
                // Har error ke liye generic message
                Console.WriteLine("❌ Invalid input! Please enter a number.");
            }
            Console.WriteLine("✅ Program continues...\n"); // Agla code chal gaya


            // =================================================
            // 2️⃣ Specific Exception (FormatException example)
            // =================================================
            Console.WriteLine("2️⃣ Specific Exception Type Example");
            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You entered: {num}");
            }
            catch (FormatException ex)
            {
                // Jab user ne string di ho instead of number
                Console.WriteLine("❌ Please enter only numeric value!");
                Console.WriteLine("Details: " + ex.Message);
            }
            Console.WriteLine("✅ Code continues after specific catch.\n");


            // ====================================================
            // 3️⃣ Multiple Catch (Overflow + Format + General)
            // ====================================================
            Console.WriteLine("3️⃣ Multiple Catch Blocks");
            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You entered: {num}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("❌ Number too big! Must be less than 2 billion.");
            }
            catch (FormatException)
            {
                Console.WriteLine("❌ Only enter numbers, no text!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Unknown Error: " + ex.Message);
            }
            Console.WriteLine("✅ Chaining done, code continues...\n");


            // ================================
            // 4️⃣ Exception Object & .GetType
            // ================================
            Console.WriteLine("4️⃣ Using Exception Object");
            try
            {
                Console.Write("Enter a number: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You entered: {n}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error occurred!");
                Console.WriteLine("Error Message: " + ex.Message);
                Console.WriteLine("Error Type: " + ex.GetType());
            }
            Console.WriteLine("✅ Error info shown, program continues.\n");


            // ============================
            // 5️⃣ Finally Block Example
            // ============================
            Console.WriteLine("5️⃣ Finally Block");
            try
            {
                Console.Write("Enter a number: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You entered: {x}");
            }
            catch
            {
                Console.WriteLine("❌ Something went wrong.");
            }
            finally
            {
                // Hamesha chalega, chahe error aaye ya na aaye
                Console.WriteLine("✅ finally block always runs.");
            }
            Console.WriteLine();


            // ===========================================
            // 6️⃣ Tumhari IMAGE wali style example
            // ===========================================
            Console.WriteLine("6️⃣ Tumhari Image Wali Example (Clean Format)");
            int userInput = 0;

            try
            {
                Console.Write("Enter a number: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"✅ You entered: {userInput}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("❌ Please enter a number less than 2 billion!");
            }
            catch (FormatException)
            {
                Console.WriteLine("❌ Please only enter valid numeric value!");
            }
            catch (Exception)
            {
                Console.WriteLine("❌ Something has gone wrong!");
            }
            finally
            {
                Console.WriteLine("✅ Goodbye from image-style example.");
            }
            Console.WriteLine();


            // ===================================================
            // 7️⃣ Extra: Sirf General Catch use karna (allowed?)
            // ===================================================
            Console.WriteLine("7️⃣ Only General Catch Example (Quick)");
            try
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine($"You entered: {number}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ General catch: " + ex.Message);
            }
            Console.WriteLine("✅ Code survived with just one catch.\n");



            // ====================================================
            // 8️⃣ What happens after error? (Agla code chalega?)
            // ====================================================
            Console.WriteLine("8️⃣ Try ke andar error ke baad agla code chalega?");
            try
            {
                Console.WriteLine("Line A - Before Error");
                int num = int.Parse("abc"); // Format error here
                Console.WriteLine("Line B - This won't run"); // Ye skip hoga
            }
            catch
            {
                Console.WriteLine("❌ Error caught!");
            }
            Console.WriteLine("✅ Line C - Code continues normally\n");


            Console.WriteLine("🎉 Program Finished. Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
