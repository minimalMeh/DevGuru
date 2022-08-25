using System;
using System.Collections.Generic;
using DevGuru.Core.Observer.Interfaces;

namespace DevGuru.Core.Observer.Classic.Subscribers
{
    public class RobotsSchool : Subscriber
    {
        private List<ISienceEvent> FollowingEvents { get; } = new List<ISienceEvent>();

        public override void AddEvent(IEvent @event)
        {
            FollowingEvents.Add(@event as ISienceEvent);
        }

        public override void Print()
        {
            Console.WriteLine("\t\t\tRobots school suggests joining:");
            FollowingEvents.ForEach(e => Console.WriteLine($"\t\t{e.Location} in {e.StartDateTime.ToLocalTime()}"));
            Console.WriteLine();
        }
    }
}
