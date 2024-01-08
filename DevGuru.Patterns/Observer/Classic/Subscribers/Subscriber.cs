using DevGuru.Patterns.Observer.Interfaces;

namespace DevGuru.Patterns.Observer.Classic.Subscribers
{
    public abstract class Subscriber
    {
        public abstract void AddEvent(IEvent @event);
        public abstract void PrintEventsSchedule();
    }
}
