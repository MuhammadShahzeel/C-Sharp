
namespace AsyncProgrammingExample
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // 👇👇👇 Roman Urdu Explanation 👇👇👇
            //
            // Yeh program show karega ke async/await se multiple tasks parallel chal sakte hain
            // "Starting" messages foran print honge bina wait kiye
            // "Completed" messages delay ke baad ayenge
            //

            Console.WriteLine("Program Started..");

            // Saare tasks ek sath start karo
            var t1 = Task1();
            var t2 = Task2();
            var t3 = Task3();

            // Ab sab tasks parallel chal rahe hain, koi dusre ka intezaar nahi karega
            // Jab tak sab complete nahi hote, hum wait karenge
            await Task.WhenAll(t1, t2, t3);

            Console.WriteLine("Program Ended..");
        }

        //👇👇👇 Task1 method
        static async Task Task1()
        {
            Console.WriteLine("Task 1 Starting..");

            // ⚡️ Pehle Thread.Sleep(4000) tha jo thread ko block karta tha
            // Ab hum await Task.Delay(4000) use kar rahe hain jo async hota hai aur thread free rakhta hai
            await Task.Delay(4000);

            Console.WriteLine("Task 1 Completed..");

            // Yeh line sirf Task1 ke complete hone ke baad chalegi
            Console.WriteLine("i will run after task 1 completed");
        }

        //👇👇👇 Task2 method
        static async Task Task2()
        {
            Console.WriteLine("Task 2 Starting..");

            // Yahan bhi Thread.Sleep ko Task.Delay se replace kiya hai
            await Task.Delay(3000);

            Console.WriteLine("Task 2 Completed..");
        }

        //👇👇👇 Task3 method
        static async Task Task3()
        {
            Console.WriteLine("Task 3 Starting..");

            // Same concept, delay async hai
            await Task.Delay(2000);

            Console.WriteLine("Task 3 Completed..");
        }
    }
}
