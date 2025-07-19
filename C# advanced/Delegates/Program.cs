using System;

namespace Delegates
{
    /*
     * ============================================================
     * ⚡ BEST PRACTICE:
     * ➜ Define delegates after the namespace and before the class.
     * ➜ Makes them accessible to all classes in the namespace.
     * ============================================================
     */

    // Step 1: Define delegates
  
    delegate int SumDelegate(int a, int b);
    delegate string StringDelegate(string input);

    internal class Program
    {
     
        static void Main(string[] args)
        {
     
            //create insrtance of StringManipulation class to access its method
            StringManipulation strMan= new StringManipulation();


            // step 2: Create delegate instances
            SumDelegate sumDel = new SumDelegate(Sum); //static so directly use method name
           //you can also write like this
            StringDelegate stringDel = strMan.AddHello;
            
            
            
            //only one refrence of method 
            //we can assign multiple using multicast delegates, but here we are using single method reference




            // Call delegates
            int result = sumDel(10, 15);
            //string greeting = stringDel("Shahzeel");
            string greeting = stringDel.Invoke("Shahzeel"); // using Invoke method

            // Display results
            Console.WriteLine("Sum of 10 and 15 is: " + result);
            Console.WriteLine(greeting);
        }

        // Method for SumDelegate
        public static int Sum(int x, int y)
        {
            return x + y;
        }

    
    }

    class StringManipulation
    {
        // Method for StringDelegate
        public string AddHello(string name)
        {
            return "Hello " + name;
        }
    }

    /*
     * ============================================================
     * THEORY SUMMARY:
     * ============================================================
     * ➜ A delegate is a type-safe function pointer.
     * ➜ It holds a reference to a method with a matching signature.(same return type and parameters)
     * ➜ Delegates enable flexible, reusable, and decoupled design.
     * ➜ Commonly used in event handling and callbacks.
     * ============================================================
     */
}
