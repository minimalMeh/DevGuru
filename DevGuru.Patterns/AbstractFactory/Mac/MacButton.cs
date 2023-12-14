using DevGuru.Patterns.AbstractFactory.Interfaces;
using System;

namespace DevGuru.Patterns.AbstractFactory.Mac
{
    public class MacButton : IButton
    {
        public void Click()
        {
            Console.WriteLine($"{nameof(MacButton)} clicked");
        }

        public void Draw()
        {
            Console.WriteLine($"{nameof(MacButton)} is drawn");
        }
    }
}
