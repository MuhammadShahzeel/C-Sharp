using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourteenListofObj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // ⭐ List of Objects Example (Roman Urdu Comments)
            // ==========================================================
            // Hum Player objects ki list banayenge
            // List<Player> ka matlab hai Player type ki dynamic list
            // ==========================================================

            // ✅ List create karo
            List<Player> players = new List<Player>();

            // ✅ Players add karo list mein
            players.Add(new Player("Chad"));
            players.Add(new Player("Steve"));
            players.Add(new Player("Karen"));

            // ==========================================================
            // ✅ Loop through list aur har player ko print karo
            // ==========================================================
            foreach (Player player in players)
            {
                // Console.WriteLine(player) automatically player.ToString() call karega
                Console.WriteLine(player);
            }

            Console.ReadKey();
        }
    }

    // ==========================================================
    // ✅ Player Class (Roman Urdu Explanation)
    // ==========================================================
    // Ye ek simple class hai jo username store karti hai
    // ==========================================================
    class Player
    {
        public string username;

        // ✅ Constructor: object banate waqt username set hota hai
        public Player(string username)
        {
            this.username = username;
        }

        // ✅ ToString() override
        // By default: object print hota to class name aata
        // Is override se hum username return karte hain
        public override string ToString()
        {
            return username;
        }
    }

    // ==========================================================
    // ✅ Benefits (Roman Urdu):
    // ----------------------------------------------------------
    // 1️⃣ List dynamic hoti hai - jitne marzi players add kar sakte ho
    // 2️⃣ Objects store kar ke unka data manage karna easy hota hai
    // 3️⃣ ToString() override se output clean aur readable hoti hai
    // 4️⃣ Real-world mein aise hi data lists manage hoti hain
    // ==========================================================
}


]





//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace ListOfObjectsExample
//{
//    // ✅ Define the Person class
//    public class Person
//    {
//        // Properties
//        public string Name { get; set; }
//        public int Age { get; set; }

//        // Default constructor
//        public Person() { }

//        // Constructor with parameters
//        public Person(string name, int age)
//        {
//            Name = name;
//            Age = age;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // =====================================================
//            // ✅ 1️⃣ Create an empty List of Person objects
//            // =====================================================
//            List<Person> people = new List<Person>();


//            // =====================================================
//            // ✅ 2️⃣ Add() with object initializer (using { })
//            // Creates and adds an object in one line
//            // =====================================================
//            people.Add(new Person { Name = "Ali", Age = 25 });



//            // =====================================================
//            // ✅ 3️⃣ Add() with constructor
//            // Constructor assigns the values
//            // =====================================================
//            people.Add(new Person("Sara", 30));



//            // =====================================================
//            // ✅ 4️⃣ Add() with manual property assignment
//            // Step by step:
//            //    1. Create object
//            //    2. Set properties separately
//            //    3. Add to list
//            // This is like your "myPerson.p1 = 'something'" example
//            // =====================================================
//            Person p1 = new Person();
//            p1.Name = "Hassan";
//            p1.Age = 28;
//            people.Add(p1);



//            // =====================================================
//            // ✅ 5️⃣ AddRange() to add multiple items at once
//            // Pass in a List of new Person objects
//            // =====================================================
//            people.AddRange(new List<Person>
//            {
//                new Person { Name = "Fatima", Age = 22 },
//                new Person("Usman", 27)
//            });



//            // =====================================================
//            // ✅ 6️⃣ Insert() to add at a specific index
//            // Insert at index 0 (start of the list)
//            // =====================================================
//            people.Insert(0, new Person { Name = "Zara", Age = 20 });



//            // =====================================================
//            // ✅ 7️⃣ Initialize list with collection initializer
//            // Create and fill a new list in one statement
//            // =====================================================
//            List<Person> morePeople = new List<Person>
//            {
//                new Person { Name = "Aisha", Age = 23 },
//                new Person("Bilal", 35)
//            };



//            // =====================================================
//            // ✅ 8️⃣ From array
//            // Create array of Person, then convert to List
//            // =====================================================
//            Person[] personArray = new Person[]
//            {
//                new Person("Ahmed", 30),
//                new Person("Zainab", 25)
//            };
//            List<Person> peopleFromArray = new List<Person>(personArray);



//            // =====================================================
//            // ✅ 9️⃣ AddRange from an array
//            // Add all elements of array into existing list
//            // =====================================================
//            people.AddRange(personArray);



//            // =====================================================
//            // ✅ 🔟 LINQ projection from strings
//            // Make a list of names, create Person objects from them
//            // =====================================================
//            List<string> names = new List<string> { "Imran", "Lubna" };
//            List<Person> projectedPeople = names
//                .Select(name => new Person { Name = name, Age = 20 })
//                .ToList();



//            // =====================================================
//            // ✅ 11️⃣ Display all people in the list
//            // Using foreach to loop through the list
//            // =====================================================
//            Console.WriteLine("People in the list:");
//            foreach (var person in people)
//            {
//                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
//            }



//            // =====================================================
//            // ✅ 12️⃣ Add single inline in new list definition
//            // This is also valid!
//            // =====================================================
//            List<Person> singlePersonList = new List<Person>
//            {
//                new Person { Name = "Faizan", Age = 33 }
//            };

//            Console.WriteLine("\nSingle Person List:");
//            foreach (var person in singlePersonList)
//            {
//                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
//            }



//            // =====================================================
//            // ✅ 13️⃣ Custom bulk add with params
//            // Example method to add multiple people in one call
//            // =====================================================
//            AddPeople(people,
//                new Person("Nadia", 29),
//                new Person("Hamza", 24)
//            );

//            Console.WriteLine("\nAfter Adding with Custom AddPeople Method:");
//            foreach (var person in people)
//            {
//                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
//            }
//        }

//        // ✅ Custom Method to add multiple Person objects using params
//        static void AddPeople(List<Person> list, params Person[] newPeople)
//        {
//            list.AddRange(newPeople);
//        }
//    }
//}
