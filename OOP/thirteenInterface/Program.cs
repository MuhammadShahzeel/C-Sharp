// =========================================================
// ⭐ USING DIRECTIVES
// ---------------------------------------------------------
// Ye top pe likhte hain jo C# ki built-in libraries ko import karte hain
// e.g. Console.WriteLine, List<T> waghera ke liye
// =========================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirteenInterface
{
    // =======================================================
    // ⭐ PROGRAM CLASS: Entry Point of Console App
    // -------------------------------------------------------
    // C# mein program ka start point "Main" method hota hai
    // =======================================================
    internal class Program
    {
        static void Main(string[] args)
        {
            // =======================================================
            // ⭐ RECOMMENDED WAY
            // -------------------------------------------------------
            // Interface type ka reference use karo (Best Practice)
            // Polymorphism enable hota hai
            // Code flexible aur maintainable hota hai
            // =======================================================

            IPrey preyRabbit = new Rabbit();        // Rabbit as IPrey
            IPredator predatorHawk = new Hawk();    // Hawk as IPredator

            IPrey preyFish = new Fish();            // Fish as IPrey
            IPredator predatorFish = new Fish();    // Fish as IPredator

            // -------------------------------------------------------
            // ✅ OLD WAY (Direct class reference) — COMMENTED OUT
            // -------------------------------------------------------
            // Rabbit rabbit = new Rabbit();   // Rabbit = Prey
            // Hawk hawk = new Hawk();         // Hawk = Predator
            // Fish fish = new Fish();         // Both

            // =======================================================
            // ✅ METHOD CALLS via INTERFACE REFERENCES
            // -------------------------------------------------------
            // Interface references ke through methods call karo
            // =======================================================
            preyRabbit.Flee();
            predatorHawk.Hunt();

            preyFish.Flee();
            predatorFish.Hunt();

            // =======================================================
            // ✅ USING LISTS AND FOREACH
            // -------------------------------------------------------
            // Interface type ki lists banao aur sab pe loop chalao
            // Polymorphism ka best use
            // =======================================================

            // ⭐ List of all Prey Animals
            List<IPrey> preyAnimals = new List<IPrey> { preyRabbit, preyFish };

            Console.WriteLine("\n⭐ All Prey Animals (via List):");
            foreach (var prey in preyAnimals)
            {
                prey.Flee();
            }

            // ⭐ List of all Predator Animals
            List<IPredator> predatorAnimals = new List<IPredator> { predatorHawk, predatorFish };

            Console.WriteLine("\n⭐ All Predator Animals (via List):");
            foreach (var predator in predatorAnimals)
            {
                predator.Hunt();
            }

            // =======================================================
            // ⭐ Wait for User Input to Close
            // =======================================================
            Console.ReadKey();
        }
    }

    // =======================================================
    // ⭐ INTERFACE RULES (Roman Urdu + English)
    // -------------------------------------------------------
    // 1️⃣ Interface sirf methods ya properties declare karta hai
    // 2️⃣ Usme koi implementation nahi hoti
    // 3️⃣ Jo class interface implement karegi, usko SAB methods likhne honge
    // 4️⃣ Interface se **multiple inheritance** ho sakti hai
    // -------------------------------------------------------
    //  ⭐⭐ YE sabse BADA advantage hai interfaces ka ⭐⭐
    //  ➜ C# mein classes se multiple inheritance nahi hoti
    //  ➜ Interfaces allow karti hain ek class ko multiple roles dena
    //     e.g. Fish : IPrey, IPredator
    // =======================================================

    // =======================================================
    // ⭐ IPrey Interface
    // -------------------------------------------------------
    // Ye contract hai: Har prey ko bhaagna aana chahiye
    // =======================================================
    interface IPrey
    {
        void Flee();  // WHAT (how nahi)
    }

    // =======================================================
    // ⭐ IPredator Interface
    // -------------------------------------------------------
    // Ye contract hai: Har predator ko shikar karna aana chahiye
    // =======================================================
    interface IPredator
    {
        void Hunt();  // WHAT (how nahi)
    }

    // =======================================================
    // ⭐ Rabbit Class implementing IPrey
    // -------------------------------------------------------
    // Rabbit ko IPrey ka contract follow karna padega
    // Matlab usko Flee() method likhna hi hoga
    // =======================================================
    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away quickly!");
        }
    }

    // =======================================================
    // ⭐ Hawk Class implementing IPredator
    // -------------------------------------------------------
    // Hawk ko IPredator ka contract follow karna padega
    // Matlab usko Hunt() method likhna hi hoga
    // =======================================================
    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk soars and hunts its prey!");
        }
    }

    // =======================================================
    // ⭐ Fish Class implementing BOTH Interfaces
    // -------------------------------------------------------
    // Fish is both Prey and Predator
    // Usko dono interfaces ke methods likhne honge
    // Ye example hai **multiple inheritance** ka interfaces se
    // =======================================================
    class Fish : IPrey, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The fish darts away in the water!");
        }

        public void Hunt()
        {
            Console.WriteLine("The fish hunts smaller fish!");
        }
    }

    // =======================================================
    // ⭐ BENEFITS OF INTERFACES (Roman Urdu Explanation)
    // -------------------------------------------------------
    // ⭐ 1️⃣ CONTRACT: Tum sure ho ke class ye methods likhe gi
    // ⭐ 2️⃣ **MULTIPLE INHERITANCE**: Sabse BADA advantage
    //     ➜ Ek class multiple interfaces se inherit kar sakti hai
    //     ➜ Classes se nahi hota (single inheritance hi hoti hai)
    // ⭐ 3️⃣ FLEXIBILITY: Tumhara design easy to expand hota hai
    // ⭐ 4️⃣ SECURITY: Tum rules set karte ho jo sab follow karte hain
    // ⭐ 5️⃣ PLUG-AND-PLAY: Tumhare objects interchangeable ban jate hain
    // ⭐ 6️⃣ POLYMORPHISM: List<Interface> bana ke sab pe same method call kar lo
    // -------------------------------------------------------
}
