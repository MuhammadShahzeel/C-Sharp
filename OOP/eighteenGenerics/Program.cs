using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eighteenGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // generic = "not specific to a particular data type"
            //generalize kr do hr data typr k liye chly ga 
            //           add <T> to: classes, methods, fields, etc.
            //           allows for code reusability for different data types

            // Example arrays of different types
            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            string[] stringArray = { "One", "Two", "Three" };

            //generic method
            // Calling the generic method for each array
            DisplayElements(intArray);
            DisplayElements(doubleArray);
            DisplayElements(stringArray);

        }

 
        public static void DisplayElements<T>(T[] array)
        {
            Console.WriteLine($"Displaying elements of {typeof(T)} array:");
            foreach (T item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }
    }
}


//----------------------generic classes-------------------------------
// 📂 File 1: GenericClassDemo.cs
/*


class Box<T>
{
    // Ye constructor hai jo item set karta hai
    public Box(T item)
    {
        Item = item;
    }

    public T Item { get; set; } // T kisi bhi type ka ho sakta hai

    public void Show()
    {
        Console.WriteLine("Box contains: " + Item);
    }
}

class Program
{
    static void Main()
    {
//kisi bhi type ka object bna skty hen
        // ✅ int type ka box
        Box<int> intBox = new Box<int>(10);
        intBox.Show(); // Output: Box contains: 10

        // ✅ string type ka box
        Box<string> strBox = new Box<string>("Hello Generics!");
        strBox.Show(); // Output: Box contains: Hello Generics!
    }
}
*/

/*
⭐ Roman Urdu:
Box<T> ek generic class hai
<T> matlab koi bhi type ho sakti hai
Constructor use kar ke tum value set karte ho
Ek hi class int, string, etc sab ke liye kaam karti hai
*/


//----------------------generic interfaces-------------------------------
/*
 // 📂 File 2: GenericInterfaceDemo.cs
using System;
using System.Collections.Generic;

// Generic Interface
interface IRepository<T>
{
    void Add(T item);
    void ShowAll();
}

// Class generic interface implement karti hai
class Repository<T> : IRepository<T>
{
    private List<T> items = new List<T>();

    // Constructor (empty for now)
    public Repository()
    {
        Console.WriteLine("Repository Created for type: " + typeof(T));
    }

    public void Add(T item)
    {
        items.Add(item);
    }

    public void ShowAll()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}

class Program
{
    static void Main()
    {
        IRepository<string> stringRepo = new Repository<string>();
        stringRepo.Add("Apple");
        stringRepo.Add("Banana");
        stringRepo.ShowAll(); // Apple Banana
    }
}
*/

/*
⭐ Roman Urdu:
IRepository<T> generic interface hai
<T> matlab koi bhi type
Repository<T> usay implement karti hai
Constructor bhi hai jo batata hai kis type ka repository bana
Ek hi class multiple types ke liye kaam kare
*/


//----------------------generic default-------------------------------

/*
 using System;

class Box<T>
{
    public T Item;

    // Constructor with no value given
    public Box()
    {
        Item = default(T);
    }

    // Constructor with value
    public Box(T item)
    {
        Item = item;
    }

    public void Show()
    {
        Console.WriteLine("Box contains: " + Item);
    }
}

class Program
{
    static void Main()
    {
        // Value diya
        Box<int> boxWithValue = new Box<int>(10);
        boxWithValue.Show(); // Box contains: 10

        // Value nahi diya - default
        Box<int> boxDefaultInt = new Box<int>();
        boxDefaultInt.Show(); // Box contains: 0

        Box<string> boxDefaultString = new Box<string>();
        boxDefaultString.Show(); // Box contains:
    }
}
 
 
 */

//-----------------------generic constraints-------------------------------
/*
 using System;

// Ye class generic hai aur constraint lagayi hai
// where T : class, new()
// matlab T sirf class type ho aur uske paas empty (parameterless) constructor ho
class Creator<T> where T : class, new()
{
    // Constructor - message show karne ke liye
    public Creator()
    {
        Console.WriteLine($"Creator bana for type: {typeof(T)}");
    }

    // Ye method ek naya T type ka object banayega
    // new T() = T type ka khaali object banao
    public T Make()
    {
        Console.WriteLine("Calling new T() to make a fresh object...");
        return new T();  // Ye line tabhi chalegi jab T ke paas empty constructor ho
    }
}

// Ek simple class jo T ke liye use hogi
class Person
{
    // Parameterless Constructor
    public Person()
    {
        Console.WriteLine("Person class ka object bana!");
    }

    // Override ToString method
    public override string ToString()
    {
        return "This is a Person Object";
    }
}

// Program ka start point
class Program
{
    static void Main()
    {
        Console.WriteLine("Starting the Creator Demo");

        // Creator class ka object bana rahe hain jahan T = Person hai
        Creator<Person> maker = new Creator<Person>();

        // maker.Make() call karein -> ye new T() karega
        Person p = maker.Make();

        Console.WriteLine("Result: " + p);

        Console.WriteLine("Program End");
    }
}

/*
Roman Urdu Explanation:

class Creator<T> where T : class, new()
   -> Constraint lagayi hai
   -> Sirf class type allow hogi
   -> Aur uske paas khaali constructor hona zaroori hai

new T()
   -> Ye ek nayi T type ki cheez banata hai
   -> Tum nahi jante ke T kya hai
   -> Tum kehte ho "Jo bhi ho, ek fresh bana do"

Person class
   -> Humne Person banayi jisme khaali constructor hai
   -> Isliye ye new T() se safely ban sakta hai

Use Case
   -> Tum generic factory bana rahe ho
   -> Jo kisi bhi class ka object bana sake
   -> Guarantee ho ke wo class ho aur khaali constructor ho

Faida
   -> Generic code re-usable
   -> Type safety (compiler check karega)
   -> No runtime error

Output Example:
   Starting the Creator Demo
   Creator bana for type: Person
   Calling new T() to make a fresh object...
   Person class ka object bana!
   Result: This is a Person Object
   Program End

Ek Line mein:
   -> new T() = "Ek nayi T type ki cheez banao without argument"
*/

