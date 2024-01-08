using DevGuru.Patterns.Observer.Interfaces;
using System;

namespace DevGuru.Patterns.Observer.Models
{
    public class BusinessEvent : IBusinessEvent
    {
        public DateTime QASessionDateTime { get; set; }
        public DateTime StartDateTime { get; set; }

        public BusinessEvent(DateTime startDateTime, DateTime qaSessionStartDateTime)
        {
            QASessionDateTime = qaSessionStartDateTime;
            StartDateTime = startDateTime;
        }
    }
}
