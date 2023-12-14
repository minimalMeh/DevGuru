using System;

namespace DevGuru.Core.Bridge.Controls
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
