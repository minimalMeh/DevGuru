using DevGuru.Patterns.Observer.Interfaces;
using System;
using System.Collections.Generic;

namespace DevGuru.Patterns.Observer.Classic.Subscribers
{
    public class InternetBilet : Subscriber
    {
        public List<IEvent> FollowingEvents { get; } = new List<IEvent>();

        public override void AddEvent(IEvent @event)
        {
            FollowingEvents.Add(@event);
        }

        public override void PrintEventsSchedule()
        {
            Console.WriteLine("\t\t!!!INTERNET BILET!!!");

            if (FollowingEvents.Count == 0)
            {
                Console.WriteLine("\t\tNo local events yet.");
                return;
            }

            foreach (var e in FollowingEvents)
            {
                Console.WriteLine($"\t\t| Date of the {e.GetType().Name} event: {e.StartDateTime.ToLocalTime().ToLongDateString()} {e.StartDateTime.ToLocalTime().ToLongTimeString()} |");
            };

            Console.WriteLine();
        }
    }
}
