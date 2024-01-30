using DevGuru.Core;
using DevGuru.Patterns.Bridge.Controls;
using DevGuru.Patterns.Bridge.Speakers;

namespace DevGuru.Patterns
{
    public class BridgePattern : PatternBase
    {
        public override string Name => "Bridge";
        protected override string DescriptionFormatted => "\t[Separates abstraction from implementation, allowing both to evolve independently,]\n\t[and promoting the composition of objects instead of inheritance.]\n";
        protected override string IdeaFormatted => "\t[Concert Hall Speaker can be ON/OFF by different devices]\n";

        protected override void RunCore()
        {
            var speaker = new ConcertHallSpeaker();

            var phoneControl = new PhoneRemoteControl();
            speaker.PairDevice(phoneControl);
            speaker.TurnOn();
            speaker.TurnOff();

            var controlPanel = new ControlPanel("connect:MainControlPanel");
            speaker.PairDevice(controlPanel);
            speaker.TurnOn();
            speaker.TurnOff();
        }
    }
}
