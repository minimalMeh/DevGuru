using DevGuru.Core;
using DevGuru.Patterns.Observer.Classic;
using DevGuru.Patterns.Observer.Classic.Subscribers;
using DevGuru.Patterns.Observer.Models;
using System;

namespace DevGuru.Patterns.Observer
{
    public class ObserverPattern : PatternBase
    {
        public override string Name => "Observer";
        protected override string DescriptionFormatted => "\t[Defines a one-to-many dependency between objects so that when one object changes state,]\n\t[all its dependents are notified and updated automatically.]\n";
        protected override string IdeaFormatted => "\t[Event Manager publishes notification when new events appear. Event could be science or business.\n\tBiseness Affiche, Internet Bilet, Robots School and Technical University whant to be]\n\t[aware about the new events.]\n";

        protected override void RunCore()
        {
            var ib = new InternetBilet();
            var ba = new BusinessAffiche();
            var tu = new TechnicalUniversity();
            var rs = new RobotsSchool();

            var eventMan = new EventManager();
            eventMan.AttachAllEventsListener(ib);
            eventMan.AttachBusinessListener(ba);
            eventMan.AttachSienceListener(tu);
            eventMan.AttachSienceListener(rs);

            eventMan.AddBusinessEnvent(new BusinessEvent(DateTime.UtcNow, DateTime.UtcNow.AddHours(3)));
            eventMan.AddSienceEnvent(new SienceEvent(DateTime.UtcNow, "Central Park"));
            eventMan.AddSienceEnvent(new SienceEvent(DateTime.UtcNow, "Jellyfish Museum"));

            ib.PrintEventsSchedule();
            ba.PrintEventsSchedule();
            tu.PrintEventsSchedule();
            rs.PrintEventsSchedule();
        }
    }
}
