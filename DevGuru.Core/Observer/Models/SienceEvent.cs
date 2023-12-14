using DevGuru.Core.Observer.Interfaces;
using System;

namespace DevGuru.Core.Observer.Models
{
    public class SienceEvent : ISienceEvent
    {
        public SienceEvent(DateTime start, string location)
        {
            StartDateTime = start;
            Location = location;
        }

        public string Location { get; set; }

        public DateTime StartDateTime { get; set; }
    }
}
