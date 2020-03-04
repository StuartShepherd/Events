using System;

namespace Events
{
    public class Pub
    {
        // onChange property containing all the list of subscribers callback methods
        public event Action OnChange = delegate { };

        public void Raise()
        {
            // invoke OnChange Action
            OnChange();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Events");
            Console.WriteLine("An event can be used to provide notifications. You can subscribe to an event if you are interested in those notifications.");
            Console.WriteLine();

            var p = new Pub();

            // register for OnChange event - Subscriber 1
            p.OnChange += () => Console.WriteLine("Subscriber 1!");

            // register for OnChange event - Subscriber 2
            p.OnChange += () => Console.WriteLine("Subscriber 2!");

            // raise the event, after this Raise() method is called all subscribers callback methods will get invoked
            p.Raise();

            Console.ReadLine();
        }
    }
}