using System;
using DevGuru.Core.Bridge.Controls;

namespace DevGuru.Core.Bridge.Speakers
{
    public class ConcertHallSpeaker : ISpeaker
    {
        private IRemoteControl device;
        private string DeviceName => device?.GetType().Name;

        public void TurnOn()
        {
            if (device is null)
            {
                throw new ArgumentNullException("Speaker is unpaired.");
            }

            if (!device.PowerState)
            {
                device.TogglePower();
                Console.WriteLine($"{nameof(ConcertHallSpeaker)}: Device {DeviceName} turned on.");
            }
        }

        public void TurnOff()
        {
            if (device is null)
            {
                throw new ArgumentNullException($"{nameof(ConcertHallSpeaker)}: Speaker is unpaired.");
            }

            if (device.PowerState)
            {
                device.TogglePower();
                Console.WriteLine($"{nameof(ConcertHallSpeaker)}: Device {DeviceName} turned off.");
            }
        }

        public void PairDevice(IRemoteControl device)
        {
            this.device = device;
            Console.WriteLine($"{nameof(ConcertHallSpeaker)}: The device {DeviceName} has been paired.");
        }
    }
}
