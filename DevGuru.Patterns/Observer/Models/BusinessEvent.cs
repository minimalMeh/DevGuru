using DevGuru.Patterns.Observer.Interfaces;
using System;

namespace DevGuru.Patterns.Observer.Models
{
    public class BusinessEvent : IBusinessEvent
    {
        public BusinessEvent(DateTime startDateTime, DateTime afterPartyDateTime)
        {
            QASessionDateTime = afterPartyDateTime;
            StartDateTime = startDateTime;
        }

        public DateTime QASessionDateTime { get; set; }

        public DateTime StartDateTime { get; set; }
    }
}
