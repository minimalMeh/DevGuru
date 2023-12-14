using DevGuru.Core.AbstractFactory.Interfaces;
using System;

namespace DevGuru.Core.AbstractFactory.Windows
{
    public class WinTextbox : ITextbox
    {
        public void Draw() => Console.WriteLine($"{nameof(WinTextbox)} is drawn");
    }
}
