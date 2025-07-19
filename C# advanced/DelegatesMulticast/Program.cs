using System;

namespace DelegatesMulticast
{
    /*
     * ============================================================
     * ⚡ Multicast delegates work only with methods that have the SAME SIGNATURE.
     * ➜ Usually void return type is used so all methods can run.
     * ============================================================
     */

    // ✅ Delegate with void return type
    delegate void NotifyDelegate(string message);

    class Notifier
    {
        public void SendEmail(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }

        public void SendSMS(string message)
        {
            Console.WriteLine("SMS sent: " + message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // ✅ Create instance of Notifier
            Notifier notifier = new Notifier();

            // ✅ Step 1: Assign first method
            NotifyDelegate notify = notifier.SendEmail;

            // ✅ Step 2: Add second method
            notify += notifier.SendSMS;

            // ✅ Step 3: Call multicast delegate
            notify("You have a new notification!");

            /*
             * ============================================================
             * ✅ Output:
             * Email sent: You have a new notification!
             * SMS sent: You have a new notification!
             * ============================================================
             * ⚡ NOTE:
             * ➜ Multicast delegates need methods with SAME SIGNATURE.
             * ➜ void return type ensures all methods are executed.
             * ============================================================
             */
        }
    }

}





/*
 using System;

namespace DelegatesMulticast
{
    /*
     * ============================================================
     * ⚡ Multicast delegates work with SAME SIGNATURE methods.
     * ➜ When return type is NOT void, only last method's return value is kept.
     * ============================================================
     */

// Delegate with string return type
delegate string NotifyDelegate(string message);

class Notifier
{
    public string SendEmail(string message)
    {
        Console.WriteLine("Email sent: " + message);
        return "Email Sent Successfully";
    }

    public string SendSMS(string message)
    {
        Console.WriteLine("SMS sent: " + message);
        return "SMS Sent Successfully";
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        // ✅ Create instance of Notifier
        Notifier notifier = new Notifier();

        // ✅ Step 1: Assign first method
        NotifyDelegate notify = notifier.SendEmail;

        // ✅ Step 2: Add second method
        notify += notifier.SendSMS;

        // ✅ Step 3: Call multicast delegate
        string result = notify("You have a new notification!");

        // ✅ Display result
        Console.WriteLine("Returned value from delegate: " + result);

        /*
         * ============================================================
         * ✅ Output in Console:
         * Email sent: You have a new notification!
         * SMS sent: You have a new notification!
         * Returned value from delegate: SMS Sent Successfully
         * ============================================================
         * ⚡ ISSUE:
         * ➜ Both methods execute.
         * ➜ BUT only LAST method's return value is returned.
         * ➜ First method's return is IGNORED.
         * ============================================================
         */
    }
}
}

  */
