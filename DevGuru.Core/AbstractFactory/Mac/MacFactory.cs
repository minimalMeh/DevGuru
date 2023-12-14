using DevGuru.Core.AbstractFactory.Interfaces;
using System;

namespace DevGuru.Core.AbstractFactory.Mac
{
    public class MacFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            Console.WriteLine($"{nameof(MacFactory)} is creating {nameof(MacButton)}.");
            return new MacButton();
        }

        public ITextbox CreateTextbox()
        {
            Console.WriteLine($"{nameof(MacFactory)} is creating {nameof(MacTextbox)}.");
            return new MacTextbox();
        }
    }
}
