using System;
using System.Collections.Generic;
using System.Text;

namespace DevGuru.Core.Bridge.Speakers
{
    public class ConcertHallSpeaker : ISpeaker
    {
        private IRemoteControl device;

        public void PairDevice(IRemoteControl device)
        {
            this.device = device;
            Console.WriteLine($"The device {device.GetType().Name} has been paired for {this.GetType().Name}.");
        }

        public void TurnOff()
        {
            if (device == null)
            {
                throw new ArgumentNullException("Speaker is unpaired.");
            }

            if (device.PowerState)
            {
                device.TogglePower();
                Console.WriteLine($"Device {device.GetType().Name} turned off.");
            }
        }

        public void TurnOn()
        {
            if (device == null)
            {
                throw new ArgumentNullException("Speaker is unpaired.");
            }

            if (!device.PowerState)
            {
                device.TogglePower();
                Console.WriteLine($"Device {device.GetType().Name} turned on.");
            }
        }
    }
}
