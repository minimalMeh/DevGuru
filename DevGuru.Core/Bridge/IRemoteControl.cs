namespace DevGuru.Core.Bridge
{
    public interface IRemoteControl
    {
        bool PowerState { get; }

        void TogglePower();
    }
}
