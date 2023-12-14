using DevGuru.Patterns.Bridge.Controls;

namespace DevGuru.Patterns.Bridge.Speakers
{
    public interface ISpeaker
    {
        void TurnOn();
        void TurnOff();
        void PairDevice(IRemoteControl remote);
    }
}
