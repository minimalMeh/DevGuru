using DevGuru.Core.Observer.Interfaces;

namespace DevGuru.Core.Observer.Classic.Subscribers
{
    public abstract class Subscriber
    {
        public abstract void AddEvent(IEvent @event);
        public abstract void Print();
    }
}
