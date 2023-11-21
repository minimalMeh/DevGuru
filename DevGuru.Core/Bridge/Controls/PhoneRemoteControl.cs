using System;

namespace DevGuru.Core.Bridge.Controls
{
    public class PhoneRemoteControl : IRemoteControl
    {
        public bool PowerState { get; private set; }

        public void TogglePower()
        {
            Console.WriteLine($"Execute {nameof(PhoneRemoteControl)}.{nameof(TogglePower)}; New state is {!PowerState}");
            PowerState = !PowerState;
        }
    }
}
