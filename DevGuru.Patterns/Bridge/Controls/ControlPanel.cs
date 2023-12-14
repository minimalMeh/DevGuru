using System;

namespace DevGuru.Patterns.Bridge.Controls
{
    public class ControlPanel : IRemoteControl
    {
        private readonly string connectionString;
        public bool PowerState { get; private set; } = false;

        public ControlPanel(string connectionString)
        {
            this.connectionString = connectionString;
            Console.WriteLine($"{nameof(ControlPanel)} connection '{connectionString}' established.");
        }

        public void TogglePower()
        {
            PowerState = !PowerState;
            Console.WriteLine($"Execute {nameof(ControlPanel)}.{nameof(TogglePower)}: New state is {PowerState}.");
        }
    }
}
