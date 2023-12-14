using System;

namespace DevGuru.Patterns.Bridge.Controls
{
    public class PhoneRemoteControl : IRemoteControl
    {
        public bool PowerState { get; private set; }

        public void TogglePower()
        {
            PowerState = !PowerState;
            Console.WriteLine($"Execute {nameof(PhoneRemoteControl)}.{nameof(TogglePower)}: New state is {PowerState}");
        }
    }
}
