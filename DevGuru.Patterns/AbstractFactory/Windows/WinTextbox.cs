using DevGuru.Patterns.AbstractFactory.Interfaces;
using System;

namespace DevGuru.Patterns.AbstractFactory.Windows
{
    public class WinTextbox : ITextbox
    {
        public void Draw() => Console.WriteLine($"{nameof(WinTextbox)} is drawn");
    }
}
