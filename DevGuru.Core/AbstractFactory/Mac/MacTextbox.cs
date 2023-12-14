using DevGuru.Core.AbstractFactory.Interfaces;
using System;

namespace DevGuru.Core.AbstractFactory.Mac
{
    public class MacTextbox : ITextbox
    {
        public void Draw()
        {
            Console.WriteLine($"{nameof(MacTextbox)} is drawn");
        }
    }
}
