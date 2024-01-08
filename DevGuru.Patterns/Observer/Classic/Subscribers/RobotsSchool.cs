using DevGuru.Patterns.Observer.Interfaces;
using System;
using System.Collections.Generic;

namespace DevGuru.Patterns.Observer.Classic.Subscribers
{
    public class RobotsSchool : Subscriber
    {
        private List<ISienceEvent> FollowingEvents { get; } = new List<ISienceEvent>();

        public override void AddEvent(IEvent @event)
        {
            FollowingEvents.Add(@event as ISienceEvent);
        }

        public override void PrintEventsSchedule()
        {
            Console.WriteLine("\t\t< Our Robots school suggests you joining these events :) >");
            FollowingEvents.ForEach(e => Console.WriteLine($"\t\t<{e.Location} in {e.StartDateTime.ToLocalTime()}>"));
            Console.WriteLine();
        }
    }
}
