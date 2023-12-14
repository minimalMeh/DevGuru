using DevGuru.Patterns.AbstractFactory.Interfaces;
using System;

namespace DevGuru.Patterns.AbstractFactory.Windows
{
    public class WinButton : IButton
    {
        public void Click() => Console.WriteLine($"{nameof(WinButton)} clicked");

        public void Draw() => Console.WriteLine($"{nameof(WinButton)} is drawn");
    }
}
