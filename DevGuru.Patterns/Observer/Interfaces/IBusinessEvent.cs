using System;

namespace DevGuru.Patterns.Observer.Interfaces
{
    public interface IBusinessEvent : IEvent
    {
        DateTime QASessionDateTime { get; }
    }
}
