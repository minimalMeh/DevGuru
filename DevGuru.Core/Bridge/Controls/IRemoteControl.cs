namespace DevGuru.Core.Bridge.Controls
{
    public interface IRemoteControl
    {
        bool PowerState { get; }
        void TogglePower();
    }
}
