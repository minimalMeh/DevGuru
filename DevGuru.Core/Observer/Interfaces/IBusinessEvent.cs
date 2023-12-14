using System;

namespace DevGuru.Core.Observer.Interfaces
{
    public interface IBusinessEvent : IEvent
    {
        DateTime QASessionDateTime { get; }
    }
}
