using DevGuru.Patterns.Observer.Interfaces;
using System;
using System.Collections.Generic;

namespace DevGuru.Patterns.Observer.Classic.Subscribers
{
    public class TechnicalUniversity : Subscriber
    {
        private List<ISienceEvent> FollowingEvents { get; } = new List<ISienceEvent>();

        public override void AddEvent(IEvent @event)
        {
            FollowingEvents.Add(@event as ISienceEvent);
        }

        public override void PrintEventsSchedule()
        {
            Console.WriteLine("\t\t[TECHNICAL UNIVERSITY AFFICHE]");

            if (FollowingEvents.Count == 0)
            {
                Console.WriteLine("\t\tNo events yet.");
                return;
            }

            foreach (var e in FollowingEvents)
            {
                Console.WriteLine($"\t\t[Date: {e.StartDateTime.ToLocalTime().ToLongDateString()}]");
                Console.WriteLine($"\t\t[Location: {e.Location}]");
            };

            Console.WriteLine();
        }
    }
}
