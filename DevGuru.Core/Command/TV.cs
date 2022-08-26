using System;

namespace DevGuru.Core.Command
{
    // Receiver
    public class TV
    {
        private bool state = false;

        public void On()
        {
            if (!state)
            {
                state = true;
                Console.WriteLine("TV is ON.");
            }
        }

        public void Off()
        {
            if (state)
            {
                state = false;
                Console.WriteLine("TV is OFF.");
            }
        }
    }
}
