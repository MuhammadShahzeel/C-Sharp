using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nineteenPartialClasses
{
    // ===========================
    // Partial Classes Explained
    // ===========================

    /*
     * Partial classes ki help se hum aik class ko multiple files mein divide kar sakte hain.
     * Jab program compile hota hai, compiler in tamam parts ko combine karke aik class banata hai.
     *
     * Fayde:
     * - Bada code manageable ho jata hai.
     * - Team mein multiple developers alag files pe kaam kar sakte hain.
     * - Designer/auto-generated code alag file mein rehta hai.
     */

    // ===========================
    // PART 1 of Student class
    // ===========================
    public partial class Student
    {
        // Properties - Part 1
        public string Name { get; set; }
        public int Age { get; set; }

        // Method - Part 1
        public void PrintBasicInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // ===========================
    // PART 2 of Student class
    // ===========================
    public partial class Student
    {
        // Properties - Part 2
        public string Address { get; set; }

        // Method - Part 2
        public void PrintAddress()
        {
            Console.WriteLine($"Address: {Address}");
        }
    }

    // ===========================
    // Example of Partial Methods
    // ===========================
    /*
     * Partial methods mein hum aik method declare karte hain aik part mein,
     * aur implement karte hain doosre part mein.
     * Agar implement na karo to compiler usay hata deta hai (no error, no call).
     */

    public partial class Calculator
    {
        partial void BeforeCalculate(); // Declaration

        public void Calculate()
        {
            BeforeCalculate(); // Agar implemented hai to call hoga
            Console.WriteLine("Calculation complete.");
        }
    }

    public partial class Calculator
    {
        // Optional implementation
        partial void BeforeCalculate()
        {
            Console.WriteLine("Preparing to calculate...");
        }
    }

    // ===========================
    // MAIN Program
    // ===========================
    internal class Program
    {
        static void Main(string[] args)
        {
            // Student class ka example
            Student student = new Student
            {
                Name = "Ali",
                Age = 20,
                Address = "Karachi"
            };

            student.PrintBasicInfo();  // Output: Name: Ali, Age: 20
            student.PrintAddress();    // Output: Address: Karachi

            Console.WriteLine(); // Line break

            // Calculator class ka example
            Calculator calc = new Calculator();
            calc.Calculate();
            // Output:
            // Preparing to calculate...
            // Calculation complete.

            Console.ReadLine(); // Keep console open
        }
    }
}
