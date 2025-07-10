using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifteenGetterSetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ============================================
            // ✅ Constructor ke through value set karna
            // ✅ Getter se value get karna
            // ✅ Setter se value change karna
            // ✅ Validation bhi hogi
            // ============================================

            Player player1 = new Player("Shahzeel");

            // ✅ Getter: naam print karo
            Console.WriteLine("Player Name: " + player1.Name);

            // ✅ Setter: naam change karo
            player1.Name = "Ali";
            Console.WriteLine("Updated Name: " + player1.Name);

            // ✅ Setter with invalid value (empty)
            player1.Name = ""; // validation fail hoga

            Console.ReadKey();
        }
    }

    // ============================================
    // ✅ Player Class
    // ============================================
    class Player
    {
        // --------------------------------------------
        // ✅ Private field
        // Hum isay private rakhte hain taake koi bahar
        // se isay directly access na kar sake.
        //
        // ❌ Direct access karna = BAD PRACTICE
        // Kyun? Kyunke koi bhi bina rules ke kuch bhi
        // assign kar sakta hai (no validation).
        // --------------------------------------------
        private string name;

        // --------------------------------------------
        // ✅ Constructor
        // Jab object banta hai, name assign hota hai
        // Lekin hum setter (property) ke through hi set karte hain
        // Taake validation ho sake
        // --------------------------------------------
        public Player(string name)
        {
         Name = name; // yahan setter call ho raha hai
        }

        // --------------------------------------------
        // ✅ Property with Getter and Setter
        // ⭐ Ye encapsulation ka example hai
        // Encapsulation = data ko hide karke controlled
        // access provide karna (get & set with rules)
        // --------------------------------------------
        public string Name
        {
            get
            {
                // ✅ Getter: value read karne ke liye
                return name;
            }
            set
            {
                // ✅ Setter: value assign karne ke liye (with validation)
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("❌ Invalid name! Name cannot be empty or whitespace.");
                }
            }
        }
    }
}
