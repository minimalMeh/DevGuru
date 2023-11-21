using System;
using DevGuru.Core.Bridge.Controls;
using DevGuru.Core.Bridge.Speakers;

namespace DevGuru.Patterns.Bridge
{
    public class BridgePattern : IPattern
    {
        public void Run()
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
