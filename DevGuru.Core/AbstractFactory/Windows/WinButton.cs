using System;
using DevGuru.Core.AbstractFactory.Interfaces;

namespace DevGuru.Core.AbstractFactory.Windows
{
    public class WinButton : IButton
    {
        public void Click() => Console.WriteLine($"{nameof(WinButton)} clicked");

        public void Draw() => Console.WriteLine($"{nameof(WinButton)} is drawn");
    }
}
