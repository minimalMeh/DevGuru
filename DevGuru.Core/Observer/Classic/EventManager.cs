using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevGuru.Core.Observer.Classic.Subscribers;
using DevGuru.Core.Observer.Interfaces;

namespace DevGuru.Core.Observer.Classic
{
    public class EventManager
    {
        private readonly List<Subscriber> sienceListeners = new List<Subscriber>();
        private readonly List<Subscriber> businessListeners = new List<Subscriber>();
        private readonly List<Subscriber> allEventsListeners = new List<Subscriber>();

        public void AttachSienceListener(Subscriber observer)
        {
            Console.WriteLine("Sience: Attached an observer.");
            sienceListeners.Add(observer);
        }

        public void AttachBusinessListener(Subscriber observer)
        {
            Console.WriteLine("Business: Attached an observer.");
            businessListeners.Add(observer);
        }

        public void AttachAllEventsListener(Subscriber observer)
        {
            Console.WriteLine("All events: Attached an observer.");
            allEventsListeners.Add(observer);
        }

        public void AddSienceEnvent(ISienceEvent @event)
        {
            sienceListeners.ForEach(s => s.AddEvent(@event));
            allEventsListeners.ForEach(s => s.AddEvent(@event));
        }

        public void AddBusinessEnvent(IBusinessEvent @event)
        {
            businessListeners.ForEach(s => s.AddEvent(@event));
            allEventsListeners.ForEach(s => s.AddEvent(@event));
        }
    }
}
