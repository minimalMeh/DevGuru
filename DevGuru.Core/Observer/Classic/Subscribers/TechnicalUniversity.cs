using System;
using System.Collections.Generic;
using DevGuru.Core.Observer.Interfaces;

namespace DevGuru.Core.Observer.Classic.Subscribers
{
    public class TechnicalUniversity : Subscriber 
    {
        private List<ISienceEvent> FollowingEvents { get; } = new List<ISienceEvent>();

        public override void AddEvent(IEvent @event)
        {
            FollowingEvents.Add(@event as ISienceEvent);
        }

        public override void Print()
        {
            Console.WriteLine("\t\t\tTECHNICAL UNIVERSITY AFFICHE");

            if (FollowingEvents.Count == 0)
            {
                Console.WriteLine("\t\t\tNo events.");
                return;
            }

            foreach (var e in FollowingEvents)
            {
                Console.WriteLine($"\t\tDate: {e.StartDateTime.ToLocalTime().ToLongDateString()}");
                Console.WriteLine($"\t\tLocation: {e.Location}");
            };

            Console.WriteLine();
        }
    }
}
