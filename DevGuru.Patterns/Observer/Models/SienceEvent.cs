using DevGuru.Patterns.Observer.Interfaces;
using System;

namespace DevGuru.Patterns.Observer.Models
{
    public class SienceEvent : ISienceEvent
    {
        public string Location { get; set; }
        public DateTime StartDateTime { get; set; }

        public SienceEvent(DateTime start, string location)
        {
            StartDateTime = start;
            Location = location;
        }
    }
}
