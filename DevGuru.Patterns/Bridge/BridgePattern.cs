using DevGuru.Patterns.Bridge.Controls;
using DevGuru.Patterns.Bridge.Speakers;

namespace DevGuru.Patterns.Bridge
{
    public class BridgePattern : BasePattern
    {
        public override string Name => "Bridge";
        public override string IdeaFormatted => "\t[Concert Hall Speaker can be ON/OFF by different devices]\n";

        public override void RunCore()
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
