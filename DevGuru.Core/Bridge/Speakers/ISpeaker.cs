using DevGuru.Core.Bridge.Controls;

namespace DevGuru.Core.Bridge.Speakers
{
    public interface ISpeaker
    {
        void TurnOn();
        void TurnOff();
        void PairDevice(IRemoteControl remote);
    }
}
