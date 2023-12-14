using DevGuru.Patterns.AbstractFactory.Interfaces;
using System;

namespace DevGuru.Patterns.AbstractFactory.Windows
{
    public class WinFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            Console.WriteLine($"{nameof(WinFactory)} is creating {nameof(WinButton)}");
            return new WinButton();
        }

        public ITextbox CreateTextbox()
        {
            Console.WriteLine($"{nameof(WinFactory)} is creating {nameof(WinTextbox)}");
            return new WinTextbox();
        }
    }
}
