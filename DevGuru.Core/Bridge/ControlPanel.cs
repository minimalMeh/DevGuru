using System;

namespace DevGuru.Core.Bridge
{
    public class ControlPanel : IRemoteControl
    {
        private readonly string connectionString;
        public bool PowerState { get; private set; } = false;

        public ControlPanel(string connectionString)
        {
            this.connectionString = connectionString;
            Console.WriteLine($"Control panel connection '{this.connectionString}' established.");
        }

        public void TogglePower()
        {
            PowerState = !PowerState;
        }
    }
}
