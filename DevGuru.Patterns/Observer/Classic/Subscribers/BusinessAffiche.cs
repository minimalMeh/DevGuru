using DevGuru.Patterns.Observer.Interfaces;
using System;
using System.Collections.Generic;

namespace DevGuru.Patterns.Observer.Classic.Subscribers
{
    public class BusinessAffiche : Subscriber
    {
        private List<IBusinessEvent> FollowingEvents { get; } = new List<IBusinessEvent>();

        public override void AddEvent(IEvent @event)
        {
            FollowingEvents.Add(@event as IBusinessEvent);
        }

        public override void PrintEventsSchedule()
        {
            Console.WriteLine("\t\t_________________");
            Console.WriteLine("\t\tBUSINESS AFFICHE:");

            if (FollowingEvents.Count == 0)
            {
                Console.WriteLine("\t\tNo events yet.");
                return;
            }

            foreach (var e in FollowingEvents)
            {
                Console.WriteLine("\t\t###");
                Console.WriteLine($"\t\t[Date: {e.StartDateTime.ToLocalTime().ToLongDateString()}]");
                Console.WriteLine($"\t\t[Q&A Session: {e.QASessionDateTime.ToLocalTime().ToLongDateString()} {e.QASessionDateTime.ToLocalTime().ToLongTimeString()}]");
            };

            Console.WriteLine("\t\t_________________");
            Console.WriteLine();
        }
    }
}
