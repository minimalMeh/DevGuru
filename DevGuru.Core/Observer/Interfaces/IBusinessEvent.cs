using System;
using System.Collections.Generic;
using System.Text;

namespace DevGuru.Core.Observer.Interfaces
{
    public interface IBusinessEvent : IEvent
    {
        DateTime QASessionDateTime { get; }
    }
}
