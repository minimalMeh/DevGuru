using System;
using System.Collections.Generic;
using System.Text;

namespace DevGuru.Core.Bridge.Speakers
{
    public interface ISpeaker
    {
        void TurnOn();
        void TurnOff();
        void PairDevice(IRemoteControl remote);
    }
}
