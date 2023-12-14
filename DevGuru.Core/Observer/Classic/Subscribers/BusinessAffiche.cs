using DevGuru.Core.Observer.Interfaces;
using System;
using System.Collections.Generic;

namespace DevGuru.Core.Observer.Classic.Subscribers
{
    public class BusinessAffiche : Subscriber
    {
        private List<IBusinessEvent> FollowingEvents { get; } = new List<IBusinessEvent>();

        public override void AddEvent(IEvent @event)
        {
            FollowingEvents.Add(@event as IBusinessEvent);
        }

        public override void Print()
        {
            Console.WriteLine("\t\t\tSUCCESS AFFICHE");

            if (FollowingEvents.Count == 0)
            {
                Console.WriteLine("\t\t\tNo events.");
                return;
            }

            foreach (var e in FollowingEvents)
            {
                Console.WriteLine($"\t\tDate: {e.StartDateTime.ToLocalTime().ToLongDateString()}");
                Console.WriteLine($"\t\tQ&A Session: {e.QASessionDateTime.ToLocalTime().ToLongDateString()}");
            };

            Console.WriteLine();
        }
    }
}
