using System;

namespace Structures
{
    public struct Person
    {
        public string name;
        public int age;
        public int birthMonth;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ======================
            // 1. STRUCT DEMONSTRATION
            // ======================
            Console.WriteLine("=== Struct Demonstration ===");

            // Direct initialization
            Person person1;
            person1.name = "Aba";
            person1.age = 23;
            person1.birthMonth = 5;
            Console.WriteLine($"Direct: {person1.name} - {person1.age} - {person1.birthMonth}");

            // ======================
            // 2. REFERENCE PARAMETERS
            // ======================
            Console.WriteLine("\n=== Reference Parameters ===");

            string refName = "";
            int refAge = 0;
            int refMonth = 0;

            // Using reference parameters to modify variables
            GetPersonByRef(ref refName, ref refAge, ref refMonth);
            Console.WriteLine($"By Reference: {refName} - {refAge} - {refMonth}");

            // ======================
            // 3. RETURN STRUCT METHOD (NEW APPROACH)
            // ======================
            Console.WriteLine("\n=== Return Struct Method ===");

            // Using factory method to create Person
            Person person3 = ReturnPerson();
            Console.WriteLine($"By Return: {person3.name} - {person3.age} - {person3.birthMonth}");

            Console.ReadLine();
        }

        // ======================
        // REFERENCE PARAMETERS METHOD
        // ======================
        static void GetPersonByRef(ref string name, ref int age, ref int birthMonth)
        {
            Console.Write("Enter name (ref): ");
            name = Console.ReadLine();

            Console.Write("Enter age (ref): ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter birth month (ref): ");
            birthMonth = Convert.ToInt32(Console.ReadLine());
        }

        // ======================
        // RETURN STRUCT METHOD
        // ======================
        static Person ReturnPerson()
        {
            /* Why this approach is better:
             * 1. Encapsulation: All creation logic in one place
             * 2. Immutability: Prevents partial initialization
             * 3. Readability: Clear intent of creating a Person
             * 4. Safety: No need to pre-initialize variables
             * 5. Return value is a coherent unit (Person struct)
             */

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your birth month: ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            // Create and return a fully initialized struct
            return new Person
            {
                name = name,
                age = age,
                birthMonth = birthMonth
            };
        }
    }
}