using System;
using DevGuru.Core.AbstractFactory.Interfaces;

namespace DevGuru.Core.AbstractFactory.Windows
{
    public class WinTextbox : ITextbox
    {
        public void Draw() => Console.WriteLine($"{nameof(WinTextbox)} is drawn");     
    }
}
