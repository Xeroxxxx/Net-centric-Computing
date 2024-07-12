using System;

namespace NCIT_LAB_Suprem
{
    internal class AnonymousMethodAndEvent
    {
        // Define a delegate for the event
        public delegate void EventHandler(string message);

        // Define an event of type EventHandler
        public static event EventHandler MyEvent;

        static void Main(string[] args)
        {
            // Anonymous method assigned to the event
            MyEvent += delegate (string message)
            {
                Console.WriteLine("Anonymous Method: " + message);
            };

            // Fire the event
            MyEvent?.Invoke("Event fired with anonymous method");

            // Additional information
            Console.WriteLine("\nLab No.: 9 e&f ");
            Console.WriteLine("Name: Suprem Bhatta");
            Console.WriteLine("Roll No./Section: 31");
        }
    }
}
