

namespace SynchronousProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 👇👇👇 Synchronous Programming Kya Hoti Hai? (Roman Urdu mein) 👇👇👇
            //
            // Synchronous programming ka matlab hai step-by-step execution.
            // Har kaam tab tak rukta hai jab tak pehla kaam complete na ho jaye.
            //
            // Matlab:
            // - Pehle Task1 chalega aur poora hoga.
            // - Uske baad Task2 start hoga.
            // - Task2 ke complete hone ke baad hi Task3 chalega.
            //
            // Ye sab kaam sequentially (line by line) hote hain bina overlap ke.


            Task1(); // Pehle Task1 chalega (4 second delay ke sath)
            Task2(); // Jab Task1 complete ho jaega tab Task2 chalega (3 second delay)
            Task3(); // Jab Task2 complete ho jaega tab Task3 chalega (2 second delay)

          
        }

        static void Task1()
        {
            Console.WriteLine("Task 1 Starting.."); // Console pe print karega
            Thread.Sleep(4000); // 4 second ka delay, is waqt program ruk jaega
            Console.WriteLine("Task 1 Completed.."); // 4 sec ke baad ye line execute hogi
        }

        static void Task2()
        {
            Console.WriteLine("Task 2 Starting..");
            Thread.Sleep(3000); // 3 sec ka delay
            Console.WriteLine("Task 2 Completed..");
        }

        static void Task3()
        {
            Console.WriteLine("Task 3 Starting..");
            Thread.Sleep(2000); // 2 sec ka delay
            Console.WriteLine("Task 3 Completed..");
        }
    }
}
