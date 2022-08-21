namespace DevGuru.Core.Bridge
{
    public class PhoneRemoteControl : IRemoteControl
    {
        public bool PowerState { get; private set; } = false;

        public void TogglePower()
        {
            PowerState = !PowerState;
        }
    }
}
