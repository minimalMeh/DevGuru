namespace DevGuru.Patterns.Bridge.Controls
{
    public interface IRemoteControl
    {
        bool PowerState { get; }
        void TogglePower();
    }
}
