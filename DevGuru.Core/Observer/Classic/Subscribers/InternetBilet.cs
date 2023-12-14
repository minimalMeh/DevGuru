using DevGuru.Core.Observer.Interfaces;
using System;
using System.Collections.Generic;

namespace DevGuru.Core.Observer.Classic.Subscribers
{
    public class InternetBilet : Subscriber
    {
        public List<IEvent> FollowingEvents { get; } = new List<IEvent>();

        public override void AddEvent(IEvent @event)
        {
            FollowingEvents.Add(@event);
        }

        public override void Print()
        {
            Console.WriteLine("\t\t\tINTERNET BILET");

            if (FollowingEvents.Count == 0)
            {
                Console.WriteLine("\t\t\tNo events.");
                return;
            }

            foreach (var e in FollowingEvents)
            {
                Console.WriteLine($"\t\tDate of the {GetEventType(e)} event: {e.StartDateTime.ToLocalTime().ToLongDateString()}");
            };

            Console.WriteLine();
        }

        private string GetEventType(IEvent @event)
        {
            if (@event is IBusinessEvent)
            {
                return "Business";
            }
            if (@event is ISienceEvent)
            {
                return "Sience";
            }
            return null;
        }
    }
}
